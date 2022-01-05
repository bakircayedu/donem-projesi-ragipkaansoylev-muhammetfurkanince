using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class FutbolTakimlar
    {
        public FutbolTakimlar()
        {
            Futbolcular1920Eng = new HashSet<Futbolcular1920Eng>();
            Futbolcular1920Ita = new HashSet<Futbolcular1920Ita>();
            Futbolcular1920Tr = new HashSet<Futbolcular1920Tr>();
            Futbolcular2021Eng = new HashSet<Futbolcular2021Eng>();
            Futbolcular2021Ita = new HashSet<Futbolcular2021Ita>();
            Futbolcular2021Tr = new HashSet<Futbolcular2021Tr>();
            Futbolcular2122Eng = new HashSet<Futbolcular2122Eng>();
            Futbolcular2122Ita = new HashSet<Futbolcular2122Ita>();
            Futbolcular2122Tr = new HashSet<Futbolcular2122Tr>();
        }

        public int TakimId { get; set; }
        public string TakimAdi { get; set; }

        public virtual Futbol1920SezonEng Futbol1920SezonEng { get; set; }
        public virtual Futbol1920SezonIta Futbol1920SezonIta { get; set; }
        public virtual Futbol1920SezonTr Futbol1920SezonTr { get; set; }
        public virtual Futbol2021SezonEng Futbol2021SezonEng { get; set; }
        public virtual Futbol2021SezonIta Futbol2021SezonIta { get; set; }
        public virtual Futbol2021SezonTr Futbol2021SezonTr { get; set; }
        public virtual Futbol2122SezonEng Futbol2122SezonEng { get; set; }
        public virtual Futbol2122SezonIta Futbol2122SezonIta { get; set; }
        public virtual Futbol2122SezonTr Futbol2122SezonTr { get; set; }
        public virtual ICollection<Futbolcular1920Eng> Futbolcular1920Eng { get; set; }
        public virtual ICollection<Futbolcular1920Ita> Futbolcular1920Ita { get; set; }
        public virtual ICollection<Futbolcular1920Tr> Futbolcular1920Tr { get; set; }
        public virtual ICollection<Futbolcular2021Eng> Futbolcular2021Eng { get; set; }
        public virtual ICollection<Futbolcular2021Ita> Futbolcular2021Ita { get; set; }
        public virtual ICollection<Futbolcular2021Tr> Futbolcular2021Tr { get; set; }
        public virtual ICollection<Futbolcular2122Eng> Futbolcular2122Eng { get; set; }
        public virtual ICollection<Futbolcular2122Ita> Futbolcular2122Ita { get; set; }
        public virtual ICollection<Futbolcular2122Tr> Futbolcular2122Tr { get; set; }
    }
}
