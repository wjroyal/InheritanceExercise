using System;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {





            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird myBird = new Bird();

            myBird.WingColor = "blue";

            myBird.BeakLength = 5;

            myBird.CanFly = true;

            myBird.DoMigrate = true;


            var myReptile = new Reptile();
            myReptile.CanRegenTail = true;
            myReptile.Habitat = "Desert";
            myReptile.IsColdBlooded = true;
            myReptile.IsScaly = true;

            

            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old.");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"It has {animal.LegCount} legs.");

                Console.WriteLine($"Can Regenerate Tail: {myReptile.CanRegenTail}");
                Console.WriteLine($" Habitat: {myReptile.Habitat}");
                Console.WriteLine($"Is it cold blooded: {myReptile.IsColdBlooded}");
                Console.WriteLine($"It's scaly: {true}");

                Console.WriteLine($"Wing Color: {myBird.WingColor}");
                Console.WriteLine($"Beak Length: {myBird.BeakLength}");
                Console.WriteLine($"Can Fly: {myBird.CanFly}");
                Console.WriteLine($"It migrates: {myBird.DoMigrate}");


;

            }










            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
           
}
}
