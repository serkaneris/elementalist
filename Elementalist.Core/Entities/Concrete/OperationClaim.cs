using Elementalist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elementalist.Core.Entities.Concrete
{
    public class OperationClaim:IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
