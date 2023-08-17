using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık
{
    internal class kitap
    {
        int ıd;
        string ad;
        string yazar;

        public int ID
        {
            get { return ıd; }
            set { ıd = value; }
        }
        public string Ad
        {
            get { return ad; } 
            set {  ad = value; } 
        }

        public string Yazar
        { 
            get { return yazar; } 
            
            set { yazar = value; }
        }

    }
}
