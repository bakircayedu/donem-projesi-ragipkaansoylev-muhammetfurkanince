using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class F1Takimlar
    {
        public F1Takimlar()
        {
            F119Pilotlar = new HashSet<F119Pilotlar>();
            F120Pilotlar = new HashSet<F120Pilotlar>();
            F121Pilotlar = new HashSet<F121Pilotlar>();
        }

        public int TakimId { get; set; }
        public string TakimAdi { get; set; }

        public virtual F119Takimlar F119Takimlar { get; set; }
        public virtual F120Takimlar F120Takimlar { get; set; }
        public virtual F121Takimlar F121Takimlar { get; set; }
        public virtual ICollection<F119Pilotlar> F119Pilotlar { get; set; }
        public virtual ICollection<F120Pilotlar> F120Pilotlar { get; set; }
        public virtual ICollection<F121Pilotlar> F121Pilotlar { get; set; }
    }
}
