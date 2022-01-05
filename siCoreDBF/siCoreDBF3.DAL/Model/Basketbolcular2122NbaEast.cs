using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class Basketbolcular2122NbaEast
    {
        public int TakimId { get; set; }
        public int FutbolcuId { get; set; }
        public string FutbolcuIsim { get; set; }
        public double? AtilanBasketOrtalamasi { get; set; }
        public double? YapilanAsistOrtalamasi { get; set; }

        public virtual BasketbolTakimlar Takim { get; set; }
    }
}
