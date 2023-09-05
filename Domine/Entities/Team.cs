using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class Team : BaseEntity
    {
        public string NameTeam { get; set; }
        public int FKIdCountry { get; set; }
        public Country Country{ get; set; }
        public ICollection<Person> People{ get; set; }
    }
}