using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    class TeknikServis
    {
        public void Bilgisayar_Topla(IBilgisayarToplayicisi BilgisayarToplayicisi) {
            BilgisayarToplayicisi.CdRom_Olustur();
            BilgisayarToplayicisi.Hdd_Olustur();
            BilgisayarToplayicisi.Monitor_Olustur();
            BilgisayarToplayicisi.Ram_Olustur();
        }
    }
}
