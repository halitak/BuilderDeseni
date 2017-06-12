using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            TeknikServis teknikServis = new TeknikServis();

            IBilgisayarToplayicisi BT1 = new GoldPc();
            IBilgisayarToplayicisi BT2 = new SilverPc();

            teknikServis.Bilgisayar_Topla(BT1);
            teknikServis.Bilgisayar_Topla(BT2);

            BT1.Bilgisayar.Bilgisayari_Goster();
            Console.WriteLine();
            BT2.Bilgisayar.Bilgisayari_Goster();

            Console.ReadKey();
        }
    }
}
