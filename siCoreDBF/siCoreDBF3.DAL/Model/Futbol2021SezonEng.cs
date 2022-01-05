using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class Futbol2021SezonEng
    {
        public int TakimId { get; set; }
        public int? TakimGalibiyet { get; set; }
        public int? TakimMaglubiyet { get; set; }
        public int? TakimBeraberlik { get; set; }
        public int? TakimAtılanGol { get; set; }
        public int? TakimYenilenGol { get; set; }
        public int? TakimAveraj { get; set; }
        public int? TakimPuan { get; set; }

        public virtual FutbolTakimlar Takim { get; set; }
    }
}
