using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        else if (Fun > 70)
            return HappyArt;
        else
            return NeutralArt;
    }

    private string HappyArt = @"
    (^_^)
   (     )
    /   \
   Happy Pet!
";

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