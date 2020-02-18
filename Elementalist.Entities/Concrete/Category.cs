using Elementalist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Entities.Concrete
{
    public class Category:IEntity
    {
        public Int32 Id { get; set; }
        public String CategoryName { get; set; }
    }
}
