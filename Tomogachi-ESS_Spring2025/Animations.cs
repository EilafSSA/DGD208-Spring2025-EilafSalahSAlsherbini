using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Animations
    {
                public void PetStatusSprite()
        {

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