using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Otomasyonu.Models
{
    public class IlacKullanimiModel
    {

        public int IlacID { get; set; }
        public string BarkodNo { get; set; }
        public string IlacAdi { get; set; }
        public decimal Fiyat { get; set; }
        public string GunlukDozaj { get; set; }
        public string Olcek { get; set; }
        public string ZamanAraliklari { get; set; }

    }
}
