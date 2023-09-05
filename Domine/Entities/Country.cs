using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class Country : BaseEntity
    {
        public string NameCountry { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}