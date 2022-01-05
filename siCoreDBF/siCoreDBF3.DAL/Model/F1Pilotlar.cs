using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class F1Pilotlar
    {
        public int PilotId { get; set; }
        public string PilotName { get; set; }

        public virtual F119Pilotlar F119Pilotlar { get; set; }
        public virtual F120Pilotlar F120Pilotlar { get; set; }
        public virtual F121Pilotlar F121Pilotlar { get; set; }
    }
}
