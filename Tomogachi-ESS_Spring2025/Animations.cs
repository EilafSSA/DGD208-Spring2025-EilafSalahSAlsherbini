using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Animations
    {
        AsciiDataBase asciiArt = new AsciiDataBase();


#region ---(Sleeping Sprites)---
        public async Task ParrotSleep()
        { string ParrotSleep = asciiArt.GetAsciiArt(PetType.Parrot, "Sleeping");
            Console.WriteLine(ParrotSleep);}
        public async Task FishSleep()
        { string FishSleep = asciiArt.GetAsciiArt(PetType.Fish, "Sleeping");
            Console.WriteLine(FishSleep);}
        public async Task CatSleep()
        { string CatSleep = asciiArt.GetAsciiArt(PetType.Cat, "Sleeping");
            Console.WriteLine(CatSleep);}
        public async Task DogSleep()
        { string DogSleep = asciiArt.GetAsciiArt(PetType.Dog, "Sleeping");
            Console.WriteLine(DogSleep); }

        #endregion

#region ---(Playing Sprites)---
        public async Task ParrotPlay()
        { string ParrotPlay = asciiArt.GetAsciiArt(PetType.Parrot, "Playing");
            Console.WriteLine(ParrotPlay);}
        public async Task FishPlay()
        { string FishPlay = asciiArt.GetAsciiArt(PetType.Fish, "Playing");
            Console.WriteLine(FishPlay);}
        public async Task CatPlay()
        { string CatPlay = asciiArt.GetAsciiArt(PetType.Cat, "Playing");
            Console.WriteLine(CatPlay);}
        public async Task DogPlay()
        { string DogPlay = asciiArt.GetAsciiArt(PetType.Dog, "Playing");
            Console.WriteLine(DogPlay);}

        #endregion

        #region ---(Feeding Animation)---

//Eilaf Note:
//I really Should of made it nicer, but its a mess now. I wish I made it more automated but it really boggled my head on how to do it
//and not crash at the same time, apologies for the messiness.

        public async Task ParrotFeedingAnim()
        {
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
        }
        public async Task DogFeedingAnim()
        {
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
        }

        public async Task CatFeedingAnim()
        {
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
        }

        public async Task FishFeedingAnim()
        {
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
        }
        #endregion
    }
}