using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDeseni
{
    class Bilgisayar
    {
        private string Bilgisayar_Tipi;
        private System.Collections.Hashtable parcalar = new System.Collections.Hashtable();

        public Bilgisayar(string Bilgisayar_Tipi) {
            this.Bilgisayar_Tipi = Bilgisayar_Tipi;
        }

        public object this[string key] {
            get {
                return parcalar[key];
            }
            set {
                parcalar[key] = value;
            }
        }

        public void Bilgisayari_Goster() {
            Console.WriteLine("Bilgisayar Tipi: " + Bilgisayar_Tipi);
            Console.WriteLine("- CdRom modeli: " + parcalar["cdRom"]);
            Console.WriteLine("- Hdd modeli: " + parcalar["hdd"]);
            Console.WriteLine("- Monitör modeli: " + parcalar["monitor"]);
            Console.WriteLine("- Ram modeli: " + parcalar["ram"]);
        }
    }
}
