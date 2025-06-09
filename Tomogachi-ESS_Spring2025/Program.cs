using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tomogachi_ESS_Spring2025
{
    public class Program
    {
        public static async Task Main()
        {
            var game = new Game();
            await game.GameLoop();
            
        }
    }
    
}