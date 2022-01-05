using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class F120Takimlar
    {
        public int TakimId { get; set; }
        public int? TakimPuan { get; set; }

        public virtual F1Takimlar Takim { get; set; }
    }
}
