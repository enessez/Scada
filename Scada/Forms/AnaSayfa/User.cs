using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Scada.AnaSayfa
{
    public class User
    {

        #region Constructions

        public User(NormFeedDBDataset _dataset,Form parentForm)
        {
            this.dataset = _dataset;

            KullaniciTuruChanged += KullaniciTuruChanged_Method;
            Kullanici_Turu = UserTypes.Misafir;

            KullaniciTuruChanged?.Invoke(Kullanici_Turu, EventArgs.Empty);

            parentForm.Closing += (sender, args) => GirisCikisKaydiTut(false);
            this.timer.Tick += TimerOnTick;

        }
        public User(string kullaniciAdi, UserTypes kullaniciTuru)
        {
            Kullanici_Adi = kullaniciAdi;
            Kullanici_Turu = kullaniciTuru;
            KullaniciTuruChanged?.Invoke(Kullanici_Turu, EventArgs.Empty);
        }

        #endregion

        #region Private Fields
        private NormFeedDBDataset dataset;

        private UserTypes _kullanici_Turu;
        private string _kullaniciAdi;

        private Timer timer = new Timer() { Interval = 1000 };
        private int saniye = 0;
        #endregion

        #region Public Fields
        public enum UserTypes
        {
            Misafir = 1,
            Operator,
            Yonetici,
            Admin,
            Rasyon
        }
        public NormFeedDBDataset.tbl_UsersRow kullaniciRow;
        #endregion

        #region Properties
        public string Kullanici_Adi
        {
            get => _kullaniciAdi;
            set
            {
                if (value == _kullaniciAdi) return;
                _kullaniciAdi = value;
                KullaciAdiChanged?.Invoke(value, EventArgs.Empty);
            }
        }

        public UserTypes Kullanici_Turu
        {
            get => _kullanici_Turu;
            set
            {
                if (value == _kullanici_Turu) return;
                _kullanici_Turu = value;
                KullaniciTuruChanged?.Invoke(value, EventArgs.Empty);
            }
        }
        #endregion

        #region Public Methods
        public void GirisCikisKaydiTut(bool GirisCikis)
        {
            if (kullaniciRow is null || kullaniciRow.KullaniciAdi =="Misafir")
                return;
            var adapter = new NormFeedDBDatasetTableAdapters.tbl_UserGirisCikisLogTableAdapter();
            adapter.InsertQuery(kullaniciRow.Id, GirisCikis);
        }

        public void CikisYap()
        {
            GirisCikisKaydiTut(false);
            Kullanici_Turu = UserTypes.Misafir;
        }
        public void GirisYap(string KullaniciAdi, string Sifre)
        {
            if (dataset.tbl_UserRoles.Rows.Count == 0)
            {
                var adapter = new NormFeedDBDatasetTableAdapters.tbl_UserRolesTableAdapter();
                adapter.Fill(dataset.tbl_UserRoles);
            }

            var usersadapter = new NormFeedDBDatasetTableAdapters.tbl_UsersTableAdapter();
           
            usersadapter.Fill(dataset.tbl_Users);

            var userarama = Enumerable.Where(dataset.tbl_Users, u => u.KullaniciAdi.ToUpper() == KullaniciAdi.ToUpper());
            NormFeedDBDataset.tbl_UsersRow kullanici;
            bool GirisBasiriliMi = false;
            
            if (!userarama.Any())  //kullanıcı bulunamadı ise
            {
                this.Kullanici_Turu = UserTypes.Misafir;
                throw new Exception("Kullanıcı Bulunamadı");
            }
            else if (userarama.First().KullaniciAdi == "Misafir") return;
            else
            {
                kullanici = userarama.First();
                GirisBasiriliMi = PasswordControl(Sifre, kullanici.Sifre);

                if (GirisBasiriliMi)
                {
                    this.Kullanici_Adi = kullanici.KullaniciAdi;
                    this.Kullanici_Turu = (UserTypes)((int)kullanici.UserRole);
                    this.kullaniciRow = kullanici;
                    GirisCikisKaydiTut(true);
                }
                else
                {
                    this.Kullanici_Turu = UserTypes.Misafir;
                    throw new Exception("Şifre Yanlış");
                }
            }
        }

        public bool SifreKontrol(string sifre)
        {
            if (dataset.tbl_UserRoles.Rows.Count == 0)
            {
                var adapter = new NormFeedDBDatasetTableAdapters.tbl_UserRolesTableAdapter();
                adapter.Fill(dataset.tbl_UserRoles);
            }
            return !(kullaniciRow is null) && PasswordControl(sifre, kullaniciRow.Sifre);
        }

        public bool SifreDegistir(string yeniSifre)
        {
            try
            {
                var adapter = new NormFeedDBDatasetTableAdapters.tbl_UsersTableAdapter();
                adapter.UpdateQuery(SifreHash(yeniSifre), kullaniciRow.Id);
                this.CikisYap();
                return true;
            }
            catch (Exception e)
            {
                this.CikisYap();
                return false;
            }
        }

        #endregion

        #region Private Methods


        private string SifreHash(string sifre)
        {
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(sifre, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedpassword = Convert.ToBase64String(hashBytes);
            return savedpassword;
        }
        private bool PasswordControl(string denenensifre, string sifreHashString)
        {
            byte[] HashBytes = Convert.FromBase64String(sifreHashString);
            byte[] salt = new byte[16];
            Array.Copy(HashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(denenensifre, salt, 10000);
            byte[] tryingHash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 16; i++)
            {
                if (tryingHash[i] != HashBytes[i + 16]) return false;
            }
            return true;
        }
        private void KullaniciTuruChanged_Method(object sender, EventArgs e)
        {
            if (!(sender is UserTypes uType)) return;
            if (uType == UserTypes.Misafir)
            {
                this.Kullanici_Adi = "Misafir";

                kullaniciRow = new NormFeedDBDataset.tbl_UsersDataTable().Newtbl_UsersRow();
                kullaniciRow.Id = 1;
                kullaniciRow.UserRole = 1;
                kullaniciRow.KullaniciAdi = "Misafir";

                this.timer.Stop();
            }
            else
            {
                this.timer.Start();
            }
            this.saniye = 0;


        }
        private void TimerOnTick(object sender, EventArgs e)
        {
            saniye++;
            SaniyeEvent?.Invoke(saniye,EventArgs.Empty);

            if (saniye == 28800) //8 saat
                this.CikisYap();
        }

        #endregion

        #region Events
        public event EventHandler SaniyeEvent;
        public EventHandler KullaniciTuruChanged;
        public EventHandler KullaciAdiChanged;
        #endregion

    }
}
