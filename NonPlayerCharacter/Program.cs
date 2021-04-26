using System;

namespace NonPlayerCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            NonPlayerCharacter[] characterList = new NonPlayerCharacter[4];
            characterList[0] = new SilverDragon("Canth", 2000);
            characterList[1] = new Human("Mark", 150);
            characterList[2] = new Kobold("Ruffus", 80);
            characterList[3] = new Horse("Buddy", 250);


            for(int x = 0; x<4; x++)
            {

                Console.WriteLine("Move: " + characterList[x].move() + "\tSound: " + characterList[x].makeSound());
            }




        }
    }
}
