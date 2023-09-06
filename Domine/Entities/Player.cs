using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities;
    public class Player : BaseEntity
    {
        public int FKIdPerson { get; set; }
        public Person Person{ get; set; }
        public int Dorsal { get; set; }
        public ICollection<PlayerPosition> PlayerPositions{ get; set; }
    
    }
    
