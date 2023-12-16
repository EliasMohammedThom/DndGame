using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Character
    {
        [Key] public int Id { get; set; }
        public Level Level { get; set; }
        public Skills Skills { get; set; }
        public Stats Stats { get; set; }
        public Inventory Inventory { get; set; }
        public Hitpoints Hitpoints { get; set; }
        public Character()
        {
            Skills = new Skills();
            Stats = new Stats();
            Inventory = new Inventory();
            Hitpoints = new Hitpoints();
            Level = new Level();
        }



    }
}
