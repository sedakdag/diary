namespace WinFormsApp2
{
    internal class Kisi
    {
        private int id;
        private string kullaniciAdi;
        private int sifre;
        private string email;

        public Kisi(int id, string kullaniciAdi, int sifre, string email)
        {
            this.id = id;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.email = email;
        }

        public string GetKullaniciAdi()
        {
            return this.kullaniciAdi;
        }

        public int GetSifre()
        {
            return this.sifre;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public int GetId()
        {
            return this.id;
        }
    }
}