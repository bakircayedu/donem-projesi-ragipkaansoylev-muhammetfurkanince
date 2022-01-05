using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class F119Pilotlar
    {
        public int TakimId { get; set; }
        public int PilotId { get; set; }
        public int Win { get; set; }
        public int PolePosition { get; set; }
        public int? Podium { get; set; }
        public int? Puan { get; set; }

        public virtual F1Pilotlar Pilot { get; set; }
        public virtual F1Takimlar Takim { get; set; }
    }
}
