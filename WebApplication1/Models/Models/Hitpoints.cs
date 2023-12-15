using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Hitpoints
    {
        public int Id { get; set; }
        public int Current { get; set; }
        public int Maximum { get; set; }
        public int Temporary { get; set; }
    }
}
