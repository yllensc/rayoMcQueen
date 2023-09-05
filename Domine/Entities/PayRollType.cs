using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class PayRollType : BaseEntity
    {
        public string NameType {get; set;} 
        public ICollection<Person> People {get; set;}
        public ICollection<Player> Players{get; set;}
    }
}