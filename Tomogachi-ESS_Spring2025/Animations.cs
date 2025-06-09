using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Animations
    {
        public async Task ParrotFeedingAnim()
        {
            AsciiDataBase asciiArt = new AsciiDataBase();
            string ParrotFrame1 = asciiArt.GetAsciiArt(PetType.Parrot, "Inbetween");
            string ParrotFrame2 = asciiArt.GetAsciiArt(PetType.Parrot, "FoodAnim1");
            string ParrotFrame3 = asciiArt.GetAsciiArt(PetType.Parrot, "FoodAnim2");

            Console.Clear();
            Console.WriteLine(ParrotFrame1);
            Thread.Sleep(350);
            Console.Clear();
            Console.WriteLine(ParrotFrame2);
            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine(ParrotFrame3);
            Thread.Sleep(600);
            Console.Clear();
        }
        public async Task DogFeedingAnim()
        {
            AsciiDataBase asciiArt = new AsciiDataBase();
            string dogFrame1 = asciiArt.GetAsciiArt(PetType.Dog, "Inbetween");
            string dogFrame2 = asciiArt.GetAsciiArt(PetType.Dog, "FoodAnim1");
            string dogFrame3 = asciiArt.GetAsciiArt(PetType.Dog, "FoodAnim2");

            Console.Clear();
            Console.WriteLine(dogFrame1);
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine(dogFrame2);
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine(dogFrame3);
            Thread.Sleep(300);
            Console.Clear();
        }

        public async Task CatFeedingAnim()
        {
            AsciiDataBase asciiArt = new AsciiDataBase();
            string CatFrame1 = asciiArt.GetAsciiArt(PetType.Cat, "Inbetween");
            string CatFrame2 = asciiArt.GetAsciiArt(PetType.Cat, "FoodAnim1");
            string CatFrame3 = asciiArt.GetAsciiArt(PetType.Cat, "FoodAnim2");

            Console.Clear();
            Console.WriteLine(CatFrame1);
            Thread.Sleep(350);
            Console.Clear();
            Console.WriteLine(CatFrame2);
            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine(CatFrame3);
            Thread.Sleep(600);
            Console.Clear();
        }

        public async Task FishFeedingAnim()
        {
            AsciiDataBase asciiArt = new AsciiDataBase();
            string FishFrame1 = asciiArt.GetAsciiArt(PetType.Fish, "Inbetween");
            string FishFrame2 = asciiArt.GetAsciiArt(PetType.Fish, "FoodAnim1");
            string FishFrame3 = asciiArt.GetAsciiArt(PetType.Fish, "FoodAnim2");

            Console.Clear();
            Console.WriteLine(FishFrame1);
            Thread.Sleep(350);
            Console.Clear();
            Console.WriteLine(FishFrame2);
            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine(FishFrame3);
            Thread.Sleep(600);
            Console.Clear();
        }
    }
}