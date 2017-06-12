using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    class SilverPc:IBilgisayarToplayicisi
    {
        private Bilgisayar bilgisayar;

        public Bilgisayar Bilgisayar
        {
            get { return bilgisayar; }
        }

        public SilverPc() {
            bilgisayar = new Bilgisayar("Silver Pc");
        }

        public void CdRom_Olustur()
        {
            bilgisayar["cdRom"] = "48x Creative";
        }

        public void Hdd_Olustur()
        {
            bilgisayar["hdd"] = "30gb Maxtor";
        }

        public void Monitor_Olustur()
        {
            bilgisayar["monitor"] = "15' Vestel";
        }

        public void Ram_Olustur()
        {
            bilgisayar["ram"] = "256mb Sd Kingston";
        }
    }
}
