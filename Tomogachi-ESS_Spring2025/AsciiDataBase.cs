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

        //Animals plan!
        //Should be a rabbit/bunny, fish, duck (?), cat, dog, hamster, 
        // maybe another fun animal like a baby tiger as a percentage by picking the cat and thne youll have to release the tiger after 5 minutes
        // like a wolf with the dog, a baby shark with the fish, a baby hare with the bunny and maybe with the hamster its a squirel. 
        // The duck can be a goose...

        static string TestBunnyArt_Neutral = @"

                             ████                                   
                            ██  ██                                  
                           ██    ██                                 
       ████                ██    ██                                 
      ██  ███              ██    ██                                 
      ██    ██             █     ██ ██████████          
       ██     ██           █  █  ██           ███                  
        ██  █   █  ███████ █ ██                 ██  ███████       
          █  ██  █                               ███      ███      
          ██                                      ██       ███     
            █                                       ██      ██      
           ██                                       ██    ███       
           ██                                       ████████        
            ██                                     ███              
            ██       ███     ███                  ██                
        ████████                                 ██                 
                ███                            ███                  
            ████████████         █████      ███                    
                      ███      ███   █████████                      
                        ███████                                     
                                                                    
                                                                    
";

        static string TestBunnyArt_Happy = @"

                             ████                                   
                            ██  ██                                  
                           ██    ██                                 
       ████                ██    ██                                 
      ██  ███              ██    ██                                 
      ██    ██             █     ██ ██████████          
       ██     ██           █  █  ██           ███                  
        ██  █   █  ███████ █ ██                ██  ███████       
          █  ██  █                               ███      ███      
          ██                                      ██       ███     
            █                                       ██      ██      
           ██                                       ██    ███       
           ██                                       ████████        
            ██       █       █                     ███              
            ██       ███     ███                  ██                
        ████████  ####         ####               ██                 
                ███                            ███                  
            ████████████         █████      ███                    
                      ███      ███   █████████                      
                        ███████                                     
                                                                    
                                                                    
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

static string HappyArt = @"
                                                                                                                                                                  
                             ███                                                    
                            ████                                                    
                          ███  ███                    █████                         
                        █████      █████████████  ████   ██                         
                       ███                      ████     ██                         
                    ███                                  ██                         
                   ███      ██              ██           ██                         
                  ███       ██              ██           ██                         
                 ███        ██              ██           ██                         
                 ██                                      ██                         
                 ██                                      ██       ████              
                 ██                                     ███       ██ ██              
                 ██                        ███          ███      ██   ██              
          ████████             ███     ████            ██      ██   ██              
                 █████            ███████              ███  ████  ███               
               ███████                                 ███████████                 
                     ███                             ████                           
                       ████                             ███                         
                        █████████████████              ███                         
                       ██████████████    █████       ███                          
                        ████████              █████████                            
                                                                     
                                                                                                                                                                
";
    }
}