using System;
using System.Collections.Generic;

namespace siCoreDBF3.DAL.Model
{
    public partial class BasketbolTakimlar
    {
        public BasketbolTakimlar()
        {
            Basketbolcular1920Euro = new HashSet<Basketbolcular1920Euro>();
            Basketbolcular1920NbaEast = new HashSet<Basketbolcular1920NbaEast>();
            Basketbolcular1920NbaWest = new HashSet<Basketbolcular1920NbaWest>();
            Basketbolcular1920Tr = new HashSet<Basketbolcular1920Tr>();
            Basketbolcular2021Euro = new HashSet<Basketbolcular2021Euro>();
            Basketbolcular2021NbaEast = new HashSet<Basketbolcular2021NbaEast>();
            Basketbolcular2021NbaWest = new HashSet<Basketbolcular2021NbaWest>();
            Basketbolcular2021Tr = new HashSet<Basketbolcular2021Tr>();
            Basketbolcular2122Euro = new HashSet<Basketbolcular2122Euro>();
            Basketbolcular2122NbaEast = new HashSet<Basketbolcular2122NbaEast>();
            Basketbolcular2122NbaWest = new HashSet<Basketbolcular2122NbaWest>();
            Basketbolcular2122Tr = new HashSet<Basketbolcular2122Tr>();
        }

        public int TakimId { get; set; }
        public string TakimAdi { get; set; }

        public virtual Basketbol1920SezonEuro Basketbol1920SezonEuro { get; set; }
        public virtual Basketbol1920SezonNbaEast Basketbol1920SezonNbaEast { get; set; }
        public virtual Basketbol1920SezonNbaWest Basketbol1920SezonNbaWest { get; set; }
        public virtual Basketbol1920SezonTr Basketbol1920SezonTr { get; set; }
        public virtual Basketbol2021SezonEuro Basketbol2021SezonEuro { get; set; }
        public virtual Basketbol2021SezonNbaEast Basketbol2021SezonNbaEast { get; set; }
        public virtual Basketbol2021SezonNbaWest Basketbol2021SezonNbaWest { get; set; }
        public virtual Basketbol2021SezonTr Basketbol2021SezonTr { get; set; }
        public virtual Basketbol2122SezonEuro Basketbol2122SezonEuro { get; set; }
        public virtual Basketbol2122SezonNbaEast Basketbol2122SezonNbaEast { get; set; }
        public virtual Basketbol2122SezonNbaWest Basketbol2122SezonNbaWest { get; set; }
        public virtual Basketbol2122SezonTr Basketbol2122SezonTr { get; set; }
        public virtual ICollection<Basketbolcular1920Euro> Basketbolcular1920Euro { get; set; }
        public virtual ICollection<Basketbolcular1920NbaEast> Basketbolcular1920NbaEast { get; set; }
        public virtual ICollection<Basketbolcular1920NbaWest> Basketbolcular1920NbaWest { get; set; }
        public virtual ICollection<Basketbolcular1920Tr> Basketbolcular1920Tr { get; set; }
        public virtual ICollection<Basketbolcular2021Euro> Basketbolcular2021Euro { get; set; }
        public virtual ICollection<Basketbolcular2021NbaEast> Basketbolcular2021NbaEast { get; set; }
        public virtual ICollection<Basketbolcular2021NbaWest> Basketbolcular2021NbaWest { get; set; }
        public virtual ICollection<Basketbolcular2021Tr> Basketbolcular2021Tr { get; set; }
        public virtual ICollection<Basketbolcular2122Euro> Basketbolcular2122Euro { get; set; }
        public virtual ICollection<Basketbolcular2122NbaEast> Basketbolcular2122NbaEast { get; set; }
        public virtual ICollection<Basketbolcular2122NbaWest> Basketbolcular2122NbaWest { get; set; }
        public virtual ICollection<Basketbolcular2122Tr> Basketbolcular2122Tr { get; set; }
    }
}
