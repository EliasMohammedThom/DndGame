using Core;
using System.Reflection.Metadata.Ecma335;
namespace Application
{
    public class Rolls
    {
        public Dices Dices { get; set; } = new();
        public int Dice { get; set; } = new();
        public Random Random { get; set; } = new();

        public int RollforStats()
        {
            List<int?>? sum = new List<int?>();

            for (int i = 0; i <= 4; i++)
                sum.Add(RollD6(null));

            sum.Remove(sum.Min());

            
            return (int)sum.Sum();
        }

        Rolls() { }

        int? RollD20(int? modifier, bool? advantage) //implement this later
        {
            int? roll = Random.Next(1, 20) + modifier;
            return roll;
        }

        int? RollD12(int? modifier)
        {
            int? roll = Random.Next(1, 12) + modifier;
            return roll;
        }

        int? RollD10(int? modifier)
        {
            int? roll = Random.Next(1, 10) + modifier;
            return roll;
        }

        int? RollD8(int? modifier)
        {
            int? roll = Random.Next(1, 20) + modifier;
            return roll;
        }
        int? RollD6(int? modifier)
        {
            int? roll = Random.Next(1, 6) + modifier;
            return roll;
        }
        int? RollD4(int? modifier)
        {
            int? roll = Random.Next(1, 4) + modifier;
            return roll;
        }
        int? RollD3(int? modifier)
        {
            int? roll = Random.Next(1, 3) + modifier;
            return roll;
        }


    }
}
