using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    interface IBilgisayarToplayicisi
    {
        Bilgisayar Bilgisayar { get; }
        void CdRom_Olustur();
        void Hdd_Olustur();
        void Monitor_Olustur();
        void Ram_Olustur();
    }
}
