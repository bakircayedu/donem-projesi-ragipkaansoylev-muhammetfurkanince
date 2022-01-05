using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class Futbolcular2021Tr
    {
        public int TakimId { get; set; }
        public int FutbolcuId { get; set; }
        public string FutbolcuIsim { get; set; }
        public int? AtilanGol { get; set; }
        public int? YapilanAsist { get; set; }

        public virtual FutbolTakimlar Takim { get; set; }
    }
}
