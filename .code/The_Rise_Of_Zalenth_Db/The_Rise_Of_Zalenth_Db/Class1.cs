using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZALENTH
{
    class Lists
    {
        public static bool first_player1;
        public static bool first_player2;
        public static bool P1_is_false_P2_is_true;
        public static int p1_moves = 5;
        public static int p2_moves = 5;
        public static int ArenaLevelInt = 0;
        public static List<string> Downloaded_DLC = new List<string>();
        public static List<string> ArenaLevels = new List<string>()
        {
            "WARRIOR",
            "GLADIATOR",
            "CURSADER",
            "CHAMPION",
            "KNIGHT"    
        };
        public static void p1_moves_reset()
        {
            p1_moves = 5;
        }
        public static void p2_moves_reset()
        {
            p2_moves = 5;
        }
        public static string ArenaLevel
        {
            get
            {
                return ArenaLevelInt.ToString();
            }
            set
            {
                Convert.ToInt32(ArenaLevelInt);
                switch(ArenaLevelInt)
                {
                    case 0:
                        ArenaLevel = "Warrior";
                        break;
                    case 1:
                        ArenaLevel = "Gladiator";
                        break;
                    case 2:
                        ArenaLevel = "Cursader";
                        break;
                    case 3:
                        ArenaLevel = "Champion";
                        break;
                    case 4:
                        ArenaLevel = "Knight";
                        break;
                }
            }
        }
    }
}
