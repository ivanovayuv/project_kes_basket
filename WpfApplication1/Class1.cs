using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Komanda
    {
        public Komanda(string imya, string gorod)
        {
            this.imya = imya;
            this.gorod = gorod;
        }
        public string imya;
        private string Imya
        {
            get
            {
                return imya;
            }
            set
            {
                imya = value;
            }
        }
        public string gorod;
        private string Gorod
        {
            get
            {
                return gorod;
            }
            set
            {
                gorod = value;
            }
        }
    }
}
