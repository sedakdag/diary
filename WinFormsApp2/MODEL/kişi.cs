using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.MODEL
{
    public class kisi
    {
        public int kulid { get; set; }
        public string kulisim { get; set; }
        public int kulsifre { get; set; }
        public string kuleposta { get; set; }
        
        public kisi()
        {
            
        }
        public kisi(int kulid,string kulisim, int kulsifre,string kuleposta)
        {
            this.kulid = kulid;
            this.kulisim = kulisim;
            this.kulsifre = kulsifre;
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
        public void setkulsifre(int kulsifre)
        {
            this.kulsifre = kulsifre;
        }
        public int getkulsifre()
        {
            return this.kulsifre;
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
