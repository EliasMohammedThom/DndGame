using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
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
        this.Skills = new Skills();
        this.Stats = new Stats();
        this.Inventory = new Inventory();
        this.Hitpoints = new Hitpoints();
        this.Level = new Level();
        }


    }
}
