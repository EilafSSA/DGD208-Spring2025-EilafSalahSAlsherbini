using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//As of now, this is unused, but ill be making whole art just for the ASCII, so this is what ill be doing for today.
namespace Tomogachi_ESS_Spring2025
{
    public class AsciiDataBase
    {
    public int Hunger { get; set; }
    public int Fun { get; set; }
    public int Sleep { get; set; }

    public string GetAsciiArt()
    {
        if (Hunger > 80)
            return HungryArt;
        else if (Sleep > 70)
            return SadArt;
        else
            return NeutralArt;
    }



    private string SadArt = @"
    (T_T)
   (     )
    /   \
   Sad Pet!
";

    private string HungryArt = @"
    (o_o)
   (     )   <hungry>
    /   \
   Feed me!
";

    private string NeutralArt = @"
    (-_-)
   (     )
    /   \
   Just chillin'.
";
    }
}