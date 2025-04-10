using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Otomasyonu.Models
{
    public class SatisRaporuModel
    {
        public int SatisID { get; set; }
        public string IlacAdi { get; set; }
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime SatisTarihi { get; set; }


    }
}
