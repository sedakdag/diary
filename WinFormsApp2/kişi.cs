
namespace WinFormsApp2
{
    internal class kişi
    {
        private int v;
        private string kullaniciAdi;
        private int sifre;
        private string email;

        public kişi(int v, string kullaniciAdi, int sifre, string email)
        {
            this.v = v;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.email = email;
        }

        internal string getkulisim()
        {
            throw new NotImplementedException();
        }

        internal int getkulşifre()
        {
            throw new NotImplementedException();
        }
    }
}