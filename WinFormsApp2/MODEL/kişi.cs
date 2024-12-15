using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.MODEL
{
    public class kişi
    {
        public int kulid { get; set; }
        public string kulisim { get; set; }
        public int kulşifre { get; set; }
        public string kuleposta { get; set; }
        
        public kişi()
        {
            
        }
        public kişi(int kulid,string kulisim, int kulşifre,string kuleposta)
        {
            this.kulid = kulid;
            this.kulisim = kulisim;
            this.kulşifre = kulşifre;
            this.kuleposta = kuleposta;
           
        }
        public void setkulid(int kulid)
        {
            this.kulid = kulid;
        }
        public int getkulid()
        {
            return this.kulid;
        }
        public void setkulisim(string kulisim)
        {
            this.kulisim = kulisim;
        }
        public string getkulisim()
        {
            return this.kulisim;
        }
        public void setkulşifre(int kulşifre)
        {
            this.kulşifre = kulşifre;
        }
        public int getkulşifre()
        {
            return this.kulşifre;
        }
        public void setkuleposta(string kuleposta)
        {
            this.kuleposta = kuleposta;
        }
        public string getkuleposta(string kuleposta)
        {
            return this.kuleposta;
        }
       

        public override string ToString()
        {
            return "isim :" + this.kulisim;
        }
    }
}
