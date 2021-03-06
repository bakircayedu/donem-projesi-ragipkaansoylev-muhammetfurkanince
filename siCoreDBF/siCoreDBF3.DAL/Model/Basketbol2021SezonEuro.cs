using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class Basketbol2021SezonEuro
    {
        public int TakimId { get; set; }
        public int? TakimGalibiyet { get; set; }
        public int? TakimMaglubiyet { get; set; }
        public int? TakimAtılanBasket { get; set; }
        public int? TakimYenilenBasket { get; set; }
        public int? TakimAveraj { get; set; }
        public int? TakimPuan { get; set; }

        public virtual BasketbolTakimlar Takim { get; set; }
    }
}
