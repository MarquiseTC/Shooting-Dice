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
           
          
            
            int otherRoll = other.Roll();
            Console.WriteLine($"{Name} rolls a {otherRoll + 1}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($"{Name} Wins!");
                
                     
           
   } }
}
