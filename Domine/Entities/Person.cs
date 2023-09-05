using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities
{
    public class Person : BaseEntity
    {
        public string FirstNamePerson { get; set;}
        public string LastNamePerson { get; set;}
        public DateTime AgePerson { get; set;}
        public int FKIdPayRollType { get; set;}
        public PayRollType PayRollType { get; set;}
        public int FKIdTeam { get; set;}
        public Team Team { get; set;}
        public ICollection<Player> Players { get; set; } 
        public ICollection<PlayerPosition> PlayerPositions{ get; set;}
    }
}