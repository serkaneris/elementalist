using Elementalist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Entities.Concrete
{
    public class Product:IEntity
    {
        public Int32 Id { get; set; }
        public String ProductName { get; set; }
        public Int32 CategoryId { get; set; }
        public String QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int32 UnitsInStock { get; set; }
    }
}
