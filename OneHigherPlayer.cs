using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer: Player
    {
        
        public int Higher {get;}
       
    public override void Play(Player other)
    {
           
          
            int myRoll = other.Roll() + 1;
            int otherRoll = other.Roll();
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{Name} Wins!");
                
                     
           
   } }
}
