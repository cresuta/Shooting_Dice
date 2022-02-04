using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter a number for a roll: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}