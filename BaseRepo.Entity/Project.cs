using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepo.Entity
{
    public class Project:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int WorkingPersonCount { get; set; }

    }
}
