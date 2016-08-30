using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace ZALENTH
{
    class Arena
    {
        #region STATIC VARIABLES
        //STATIC VARIABLES
        static int stage = 1;
        static string check;
        public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string totl_appdata_path = folder + @"The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile";
        public static string product_code = "TC34-HT78-7UN4-ZY5R";
        public static bool if_addon = false;
        static bool in_dungon = false;
        static int ycdl;
        static int maxycdl = 10;
        static int umaxycdl = 0;
        //---ALL---
        static int BMV = 80;
        static int ATV = 100;
        static int MVV = 100;
        static int MIINVV = 100;
        static int INVOPV = 100;
        static string path = curetna + @"\SAVEGAME\SaveGameArena.CommandLineStudiosFile";
        //static string product_key = curenta + @"\SAVEGAME\ProductKey.CommandLineStudiosFile";
        static string Folder = curetna + @"\MUSIC";
        static string FolderToGoTo = curetna + @"\MUSIC\BACKMUSIC";
        //
        static Stopwatch sw = new Stopwatch();
        static string curetna = Environment.CurrentDirectory;
        static string movem = curetna + @"\MUSIC\MOVING.mp3";
        static int he;
        static WMPLib.WindowsMediaPlayer b = new WMPLib.WindowsMediaPlayer();
        static WMPLib.WindowsMediaPlayer MusicPlayer = new WMPLib.WindowsMediaPlayer();
        static WMPLib.WindowsMediaPlayer c = new WMPLib.WindowsMediaPlayer();
        static WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        static int cracked_staff_att = 10;
        static int rusty_dagger_att = 9;
        static int golden_dagger_att = 10;
        static int broken_bow_att = 11;
        static int chipped_short_sword_att = 12;
        //
        static int helth_pts;
        static int att_pts;
        static int def_pts;
        static int speed_pts;
        //
        public static List<string> SeCo = new List<string>();
        public static List<string> PrIm = new List<string>();
        // 
        public static string seco = Program.seco;
        public static string prim = Program.prim;
        //
        public static string h;
        //
        static double TimeElapsed;
        public static int skill_points;
        public static int bow_staff_att = 8;
        public static int long_bow_att = 30;
        public static int med_long_bow_att = 15;
        public static int sti_long_bow_att = 8;
        public static int reg_dagger_att = 5;
        public static int tin_hat_def;
        public static int long_sword_att = 30;
        public static int med_long_sword_att = 15;
        public static int short_dagger_att = 15;
        public static int short_staff_att = 15;
        public static int sil_dagger_att = 30;
        public static int mage_staff_att = 30;
        public static int short_sword_att = 9;
        public static int posion_dagger_att = 8;
        public static int regular_mage_staff_att = 10;
        public static int item_def;
        //
        public static int chance_for_drop;
        //----------VERSION alzh0.0.0.7.1db----------//
        public static DateTime last_save;
        public static int price;
        public static int mcc;
        public static int scc;
        public static int gcc;
        public static int t = 0;
        public static int dek = 0;
        public static int item_level;
        public static int xp_gained;
        public static int sq = number;
        public static int temp_def;
        public static string wourld = "arena";
        public static int first = 1;
        //static string progressBarElement = health.ToString();
        public static int scorea = 0;
        public static int s;
        public static int ml;
        //----------SELF----------
        static int max_health = Program.max_health;
        static int classDef = Program.classDef;
        public static int classAtt = Program.classAtt;
        public static int copperc = 20;
        public static int silverc = 0;
        public static int goldx = 0;
        public static Random rnd = new Random();
        public static int HealthPotions = Program.HealthPotions;
        public static string version = "alzhA0.0.0.1.3db";
        public static string ynl;
        public static int okxp;
        public static int ok;
        public static string NameOfMob;
        public static int xpt = Program.xpt;
        public static int xp = Program.xp;
        public static int level = Program.level;
        public static int health = Program.health;
        public static string wdtbl;
        public static int xc;
        public static int yc;
        public static string a;
        public static int curenta = 1;
        public static int attp = Program.attp;
        public static int atts = Program.atts;
        public static int def = Program.def;
        public static int speed = Program.speed;
        public static int stam;
        public static int range;
        public static string name = Program.name;
        public static string clasl = Program.clasl;
        public static int score = dek + (xp / 2) + level * 2;
        public static List<string> invens = new List<string>();
        public static string chexk;
        public static string Class_Level = Lists.ArenaLevel;
        //----------MOBS----------
        static int MHealth;
        static int MAtt;
        static int Mdef;
        static int spawn;
        static int number;
        //static TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
        #endregion //STATIC VARIABLES
        public static int potion_in_Balle;
        public static void arena()
        {
            Console.Title = "The Rise of Zalenth: Arena";
            string curetn = Environment.CurrentDirectory;
            string end = curetn + @"\MUSIC\BACKMUSIC\ArenaMusic.mp3";
            //WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();
            //.URL = end;
            Program.MusicPlayer.URL = end;
            Program.MusicPlayer.settings.volume = BMV;
            Program.MusicPlayer.controls.play();
            foreach(string item in Program.invens)
            {
                invens.Add(item);
            }
            Console.WriteLine("Version: {0}", version);
            Console.WriteLine("Welcome to the Rise of Zalenth Arena!");
            Console.WriteLine("You will here, fight an infinite ammount of enimies,");
            Console.WriteLine("and will get to go to the shop every other battle.");
            Console.WriteLine("You are allowed to use two potions per. battle.");
            Console.WriteLine("Please press any key.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("During the arena, you will have a whole another character!");
            Console.WriteLine("This game mode will not affect your main character!");
            Console.WriteLine("Press any key to begin.");
            Console.Clear();
            help();
            Console.ReadKey();
            Console.Clear();
            TesatQ();
        }
        public static void class_S()
        {
            Console.WriteLine("YOUR LEVEL: {0}", Lists.ArenaLevelInt);
        }
        public static void begining_()
        {

        }
        public static void choose_addon()
        {

        }
        public static void volumesettings()
        {
            Console.WriteLine("Background music: {0}", BMV);
            Console.WriteLine("Attack sound: {0}", ATV);
            Console.WriteLine("Moving sound: {0}", MVV);
            Console.WriteLine("Inventory sound: {0}", MIINVV);
            Console.WriteLine("Open inventory: {0}", INVOPV);
            Console.WriteLine("Would you like to change settings?");
            while (true)
            {
                string ynb = Console.ReadLine();
                ynb = ynb.ToLower();
                switch (ynb)
                {
                    case "yes":
                    case "y":
                        Console.WriteLine("What would you like to change?");
                        bool in_change = true;
                        while (in_change)
                        {
                            string choudne = Console.ReadLine();
                            choudne = choudne.ToLower();
                            switch (choudne)
                            {
                                case "background music":
                                    Console.WriteLine("Current voulume: {0}", BMV);
                                    try
                                    {
                                        string SBMV = Console.ReadLine();
                                        if (int.TryParse(SBMV, out BMV))
                                        {
                                            if (BMV >= 0 || BMV <= 100)
                                            {
                                                MusicPlayer.settings.volume = BMV;
                                                volumesettings();
                                            }
                                            else
                                            {
                                                Console.WriteLine("It must be between 0 - 100");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is not a valid number!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            volumesettings();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Number has to be between 0 - 100");
                                        Console.WriteLine("Press any key");
                                        Console.ReadKey();
                                        volumesettings();
                                    }
                                    break;
                                case "attack sound":
                                    Console.WriteLine("Current voulume: {0}", ATV);
                                    try
                                    {
                                        string SBMV = Console.ReadLine();
                                        if (int.TryParse(SBMV, out ATV))
                                        {
                                            if (BMV >= 0 || BMV <= 100)
                                            {
                                                MusicPlayer.settings.volume = BMV;
                                                volumesettings();
                                            }
                                            else
                                            {
                                                Console.WriteLine("It must be between 0 - 100");
                                            }
                                            volumesettings();
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is not a valid number!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            volumesettings();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Number has to be between 0 - 100");
                                        Console.WriteLine("Press any key");
                                        Console.ReadKey();
                                        volumesettings();
                                    }
                                    break;
                                case "moving sound":
                                    Console.WriteLine("Current voulume: {0}", MVV);
                                    try
                                    {
                                        string SBMV = Console.ReadLine();
                                        if (int.TryParse(SBMV, out MVV))
                                        {
                                            if (BMV >= 0 || BMV <= 100)
                                            {
                                                WMP.settings.volume = BMV;
                                                volumesettings();
                                            }
                                            else
                                            {
                                                Console.WriteLine("It must be between 0 - 100");
                                            }
                                            volumesettings();
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is not a valid number!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            volumesettings();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Number has to be between 0 - 100");
                                        Console.WriteLine("Press any key");
                                        Console.ReadKey();
                                        volumesettings();
                                    }
                                    break;
                                case "inventory sound":
                                    Console.WriteLine("Current voulume: {0}", MIINVV);
                                    try
                                    {
                                        string SBMV = Console.ReadLine();
                                        if (int.TryParse(SBMV, out MIINVV))
                                        {
                                            if (BMV >= 0 || BMV <= 100)
                                            {
                                                MusicPlayer.settings.volume = BMV;
                                                volumesettings();
                                            }
                                            else
                                            {
                                                Console.WriteLine("It must be between 0 - 100");
                                            }
                                            volumesettings();
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is not a valid number!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            volumesettings();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Number has to be between 0 - 100");
                                        Console.WriteLine("Press any key");
                                        Console.ReadKey();
                                        volumesettings();
                                    }
                                    break;
                                case "open inventory":
                                    Console.WriteLine("Current voulume: {0}", INVOPV);
                                    try
                                    {
                                        string SBMV = Console.ReadLine();
                                        if (int.TryParse(SBMV, out INVOPV))
                                        {
                                            if (BMV >= 0 || BMV <= 100)
                                            {
                                                MusicPlayer.settings.volume = BMV;
                                                volumesettings();
                                            }
                                            else
                                            {
                                                Console.WriteLine("It must be between 0 - 100");
                                            }
                                            volumesettings();
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is not a valid number!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            volumesettings();
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Number has to be between 0 - 100");
                                        Console.WriteLine("Press any key");
                                        Console.ReadKey();
                                        volumesettings();
                                    }
                                    break;
                                default:
                                    Console.WriteLine("That is not a valid option!");
                                    break;
                            }
                        }
                        Console.WriteLine(a);
                        break;

                    case "no":
                    case "n":
                        TesatQ();
                        break;
                    default:
                        Console.WriteLine("'yes' or 'no'");
                        break;

                }
            }
        }
        public static void defk()
        {
            Console.WriteLine("Number of kills: {0}", dek);
            Console.WriteLine("");
        }
        public static void drop_chance()
        {
            int drop_cha = rnd.Next(0, 100);
            if (drop_cha >= 60)
            {
                Console.WriteLine("You found nothing.");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                return;
            }
            else
            {
                int drop_cha_itm = rnd.Next(0, 6);
                switch (drop_cha_itm)
                {
                    case 1:
                        if (!invens.Contains("rusty dagger"))
                        {
                            Console.WriteLine("You have found a rusty dagger! <+ 9 att>");
                            invens.Add("rusty dagger");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You already have a rusty dagger. You put it down!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        if (!invens.Contains("golden dagger"))
                        {
                            Console.WriteLine("You have found a golden dagger! <+ 10 att>");
                            invens.Add("golden dagger");
                            Console.WriteLine("press any key");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You already have a golden dagger. You put it down!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        if (!invens.Contains("broken bow"))
                        {
                            Console.WriteLine("You have found a broken bow! <+ 11 att>");
                            invens.Add("broken bow");
                            Console.WriteLine("press any key");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You already have a broken bow. You put it down!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        if (!invens.Contains("cracked staff"))
                        {
                            Console.WriteLine("You have found a cracked staff! <+ 10 att>");
                            invens.Add("cracked staff");
                            Console.WriteLine("press any key");
                            TesatQ();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You already have a cracked staff. You put it down!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        if (!invens.Contains("chipped short sword"))
                        {
                            Console.WriteLine("You have found a chipped short sword! <+ 12 att>");
                            invens.Add("chipped short sword");
                            Console.WriteLine("press any key");
                            TesatQ();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You already have a chipped short sword. You put it down!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            break;
                        }
                }
            }

        }//
        public static void death()
        {
            File.WriteAllText(curetna + @"\SAVEGAME\SaveGame.txt", String.Empty);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You got to stage {0}! You killed {1} monsters, and had a score of {2}!", stage, dek, scorea);
                Console.WriteLine("Press any key.");
                Console.ReadKey();
                Program.start();
                Program.load_or_new();
            }
        }//
        public static void SuicKil()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to kill your character?");
            bool tell = true;
            while (tell)
            {
                string pTher = Console.ReadLine();
                pTher = pTher.ToLower();
                switch (pTher)
                {
                    case "yes":
                    case "y":
                        death();
                        break;
                    case "no":
                    case "n":
                        TesatQ();
                        break;
                    default:
                        Console.WriteLine("'yes' or 'no'");
                        break;

                }
            }
        }//
        public static void buy_longsword()
        {
            if (chexk == "long sword")
            {
                price = 100;
                if (level >= item_level)
                {
                    if (silverc >= price)
                    {
                        silverc = silverc - price;
                        invens.Add("long sword");
                        Console.WriteLine("You have bought 1 long sword!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        TesatQ();
                    }
                }
            }
            if (chexk == "medium long sword")
            {
                price = 120;
                if (level >= item_level)
                {
                    if (copperc >= price)
                    {
                        copperc = copperc - price;
                        invens.Add("medium long sword");
                        Console.WriteLine("You have bought 1 medium long sword!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
        }//
        public static void buy_longbow()
        {
            if (chexk == "long bow")
            {
                price = 100;
                if (level >= item_level)
                {
                    if (silverc >= price)
                    {
                        silverc = silverc - price;
                        invens.Add("long bow");
                        Console.WriteLine("You have bought 1 long bow!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
            if (chexk == "medium long bow")
            {
                price = 120;
                if (level >= item_level)
                {
                    if (copperc >= price)
                    {
                        copperc = copperc - price;
                        invens.Add("medium long bow");
                        Console.WriteLine("You have bought 1 medium long bow!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
        }//
        public static void buy_silver_dagger()//
        {
            if (chexk == "silver dagger")
            {
                price = 120;
                if (level >= item_level)
                {
                    if (silverc > price)
                    {
                        silverc = silverc - price;
                        invens.Add("silver dagger");
                        Console.WriteLine("You have bought 1 silver dagger!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
            if (chexk == "short dagger")
            {
                price = 120;
                if (level >= item_level)
                {
                    if (copperc >= price)
                    {
                        copperc = copperc - price;
                        invens.Add("short dagger");
                        Console.WriteLine("You have bought 1 short dagger!");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
        }
        public static void buy_mage_staff()
        {
            if (chexk == "mage staff")
            {
                price = 120;
                if (silverc >= price)
                {
                    silverc = silverc - price;
                    invens.Add("Mage Staff");
                    Console.WriteLine("You have bought 1 mage staff");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    Console.Clear();
                    TesatQ();
                }
                else
                {
                    Console.WriteLine("You do not have enough coins for that!");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    store();
                }
            }
            if (chexk == "short staff")
            {
                if (level >= item_level)
                {
                    if (copperc >= price)
                    {
                        copperc = copperc - price;
                        invens.Add("short staff");
                        Console.WriteLine("You have bought 1 short staff!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("You do not have enough coins for that!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        store();
                    }
                }
            }
        }//
        public static void buy_p()
        {
            price = 15;
            if (copperc >= price)
            {
                copperc = copperc - price;
                HealthPotions++;
                Console.WriteLine("You bought 1 potion!");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
                TesatQ();
            }
            else
            {
                Console.WriteLine("You do not have enough coins for that!");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                store();
            }
        }//
        public static void buy_helmet()//
        {
            switch (chexk)
            {
                case "tin hat":
                    price = 50;
                    if (copperc >= price)
                    {
                        copperc = copperc - price;
                        invens.Add("tin hat");
                        item_def = 3;
                        def = 3 + classDef;
                        Console.WriteLine("You have bought 1 tin hat!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        Console.Clear();
                        TesatQ();
                    }
                    break;
            }
        }
        public static void money()
        {
            Console.WriteLine("----------YOUR COINS----------");
            Console.WriteLine("{0}: cc", copperc);
            Console.WriteLine("{0}: sc", silverc);
            Console.WriteLine("{0}: gc", goldx);
        }
        public static void storet()//
        {
            bool InStore = true;
            while (InStore)
            {
                chexk = Console.ReadLine();
                chexk = chexk.ToLower();
                if (level < 3)
                {
                    switch (chexk)
                    {
                        case "potion":
                            Console.WriteLine("");
                            buy_p();
                            break;
                        case "tin hat":
                            Console.WriteLine("");
                            buy_helmet();
                            break;
                        case "exit":
                            Console.WriteLine("GOODBYE!");
                            Console.WriteLine("");
                            InStore = false;
                            return;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Invalid attempt");
                            break;
                    }
                }
                if (level >= 3 /*&& level < 5*/)
                {
                    switch (chexk)
                    {
                        case "potion":
                            buy_p();
                            break;
                        case "exit":
                            Console.WriteLine("GOODBYE!");
                            TesatQ();
                            break;
                        case "medium long bow":
                            item_level = 3;
                            if (clasl == "ranger")
                            {
                                buy_longbow();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You are not in that class!");
                            }
                            break;
                        case "short dagger":
                            item_level = 3;
                            if (clasl == "assassin")
                            {
                                buy_silver_dagger();
                            }
                            if (clasl == "rogue")
                            {
                                buy_silver_dagger();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You are not in that class!");
                            }
                            break;
                        case "short staff":
                            item_level = 3;
                            if (clasl == "mage")
                            {
                                buy_mage_staff();
                            }
                            else
                            {
                                Console.WriteLine("You are not in that class!");
                            }
                            break;
                        case "medium long sword":
                            item_level = 3;
                            if (clasl == "warrior")
                            {
                                buy_longsword();
                            }
                            else
                            {
                                Console.WriteLine("You are not in that class!");
                            }
                            break;
                        case "tin hat":
                            buy_helmet();
                            break;
                        default:
                            Console.WriteLine("Invalid attempt");
                            break;
                    }
                }
                if (level >= 5)
                {
                    switch (chexk)
                    {
                        case "potion":
                            buy_p();
                            break;
                        case "long sword":
                            item_level = 5;
                            if (clasl == "warrior")
                            {
                                buy_longsword();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You are not that class!");
                            }
                            break;
                        case "long bow":
                            item_level = 5;
                            if (clasl == "ranger")
                            {
                                buy_longbow();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You are not that class!");
                            }
                            break;
                        case "silver dagger":
                            if (clasl == "assassin")
                            {
                                buy_silver_dagger();
                            }
                            if (clasl == "rogue")
                            {
                                buy_silver_dagger();
                            }
                            else
                            {
                                Console.WriteLine("You are not in that class!");
                            }
                            break;
                        case "exit":
                            Console.WriteLine("GOODBYE!");
                            TesatQ();
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Invalid attempt");
                            break;
                    }
                }

            }
        }
        public static void store()//
        {
            if ((wourld == "zalenth" && xc == 0) || (wourld == "estens" && xc == 5 || xc == -5 || xc == 0))
            {
                if ((wourld == "zalenth" && yc == 0) || (wourld == "estens" && yc == 5 || yc == -5 || yc == 0))
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Welcome to the store!");
                    Console.WriteLine("type in 'exit' to exit the store");
                    if (level >= 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You have {0}cc, {1}sc, {2}gc", copperc, silverc, goldx);
                        Console.WriteLine("");
                        Console.WriteLine("----------LEVEL 1----------");
                        Console.WriteLine("Potion:                      15 copper <all>");
                        Console.WriteLine("Tin hat <+ 3 def>            50 copper <all>");
                        Console.WriteLine("");
                        Console.WriteLine("----------LEVEL 3----------");
                        Console.WriteLine("Medium long bow <+ 15 att>   120 copper <ranger>");
                        Console.WriteLine("Medium long sword <+ 15 att> 120 copper <warrior>");
                        Console.WriteLine("Short dagger <+ 15 att>      120 copper <assassin> <rogue>");
                        Console.WriteLine("Short staff <+15 att>        120 copper <mage>");
                        Console.WriteLine("Potion:                      15 copper");
                        Console.WriteLine("Greater potion:              30 copper");
                        Console.WriteLine("");
                        Console.WriteLine("----------LEVEL 5----------");
                        Console.WriteLine("Long Sword <+ 30 att>        100 silver <warrior>");
                        Console.WriteLine("Long bow <+ 30 att>          100 silver <ranger>");
                        Console.WriteLine("Silver dagger <+30 att>      120 silver <assassin> <rogue>");
                        Console.WriteLine("Mage Saff <+ 30 att>         120 silver <mage>");
                        storet();
                    }
                }
                else
                {
                    if (wourld == "zalenth")
                    {
                        Console.WriteLine("You have to be at 0 , 0 to access the store!");
                    }
                    if (wourld == "estens")
                    {
                        Console.WriteLine("You have to be a (0 , 0), (5 , 5), (-5 , -5) to access the store!");
                    }
                }
            }
            else
            {
                if (wourld == "zalenth")
                {
                    Console.WriteLine("You have to be at 0 , 0 to access the store!");
                }
                if (wourld == "estens")
                {
                    Console.WriteLine("You have to be a (0 , 0), (5 , 5), (-5 , -5) to access the store!");
                }
            }
        }
        public static void potion()//
        {
            bool PotionI = true;
            if (HealthPotions > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You have: {0} potions. Do you want to use one of them?", HealthPotions);
                while (PotionI)
                {
                    string po = Console.ReadLine();
                    po = po.ToLower();
                    switch (po)
                    {
                        case "yes":
                            Console.WriteLine("");
                            Console.WriteLine("Using...");
                            int pohel = rnd.Next(10, max_health);
                            if (health + pohel <= max_health)
                            {
                                health = health + pohel;
                                HealthPotions--;
                                Console.WriteLine("Your health: {0}", health);
                                return;
                            }
                            else
                            {
                                health = max_health;
                                HealthPotions--;
                                Console.WriteLine("You are at full health!");
                                return;
                            }
                        case "no":
                            return;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("'yes' or 'no'");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You do not have any potions!");
            }
        }
        public static void Music()
        {
            string curetn = Environment.CurrentDirectory;
            string end = curetn + @"\MUSIC\BACKMUSIC\BackGroundMusic.mp3";
            //WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();
            //.URL = end;
            MusicPlayer.URL = end;
            MusicPlayer.settings.volume = BMV;
            MusicPlayer.controls.play();
        }
        public static void pots()//
        {
            while (true)
            {
                Console.WriteLine("You have {0} skill points avalible.", skill_points);
                Console.WriteLine("");
                Console.WriteLine("Would you like to use them?");
                Console.WriteLine("");
                while (true)
                {
                    string gasdf = Console.ReadLine();
                    gasdf = gasdf.ToLower();
                    switch (gasdf)
                    {
                        case "yes":
                        case "y":
                            int hpn = helth_pts + 2;
                            int apn = att_pts + 2;
                            int dpn = def_pts + 2;
                            int spn = speed_pts + 2;
                            Console.WriteLine("{0} SKILL POINTS AVAILBLE", skill_points);
                            Console.WriteLine("");
                            Console.WriteLine("HEALTH    {0} NEED: {1}", helth_pts, hpn);
                            Console.WriteLine("ATTACK    {0} NEED: {1}", att_pts, apn);
                            Console.WriteLine("DEFENCE   {0} NEED: {1}", def_pts, dpn);
                            Console.WriteLine("SPEED     {0} NEED: {1}", speed_pts, spn);
                            Console.WriteLine("");
                            while (true)
                            {
                                string ThJe = Console.ReadLine();
                                ThJe = ThJe.ToLower();
                                switch (ThJe)
                                {
                                    case "health":
                                        if (skill_points >= hpn)
                                        {
                                            he = ((5 * helth_pts) + 1);
                                            Console.WriteLine("Are you sure? <+ {0} max health>", he);
                                            while (true)
                                            {
                                                string asdf = Console.ReadLine();
                                                asdf = asdf.ToLower();
                                                switch (asdf)
                                                {
                                                    case "yes":
                                                    case "y":
                                                        int hps = hpn;
                                                        skill_points = skill_points - hps;
                                                        helth_pts++;
                                                        max_health = max_health + he;
                                                        health = max_health;
                                                        Console.Title = (health.ToString());
                                                        Console.ReadKey();
                                                        pots();
                                                        break;
                                                    case "no":
                                                    case "n":
                                                        pots();
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have enough points!");
                                            Console.WriteLine("Press any key");
                                            Console.ReadKey();
                                            pots();
                                        }
                                        break;
                                    case "speed":
                                        if (skill_points >= speed_pts)
                                        {
                                            he = ((5 * speed_pts) + 1);
                                            Console.WriteLine("Are you sure? <+ {0} speed>", he);
                                            while (true)
                                            {
                                                string asdf = Console.ReadLine();
                                                asdf = asdf.ToLower();
                                                switch (asdf)
                                                {
                                                    case "yes":
                                                    case "y":
                                                        int hps = spn;
                                                        skill_points = skill_points - hps;
                                                        speed_pts++;
                                                        speed = speed + he;
                                                        Console.Title = (health.ToString());
                                                        Console.ReadKey();
                                                        pots();
                                                        break;
                                                    case "no":
                                                    case "n":
                                                        pots();
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have enough points!");
                                            pots();
                                        }
                                        break;
                                    case "defence":
                                        if (skill_points >= def_pts)
                                        {
                                            he = (def_pts + 1);
                                            Console.WriteLine("Are you sure? <+ 1 defence>");
                                            while (true)
                                            {
                                                string asdf = Console.ReadLine();
                                                asdf = asdf.ToLower();
                                                switch (asdf)
                                                {
                                                    case "yes":
                                                    case "y":
                                                        int hps = dpn;
                                                        skill_points = skill_points - hps;
                                                        def_pts++;
                                                        classDef = classDef + 1;
                                                        if (invens.Contains("tin hat"))
                                                        {
                                                            def = classDef + tin_hat_def;
                                                            Console.Title = (health.ToString());
                                                            Console.ReadKey();
                                                            pots();
                                                        }
                                                        else
                                                        {
                                                            def = classDef;
                                                            Console.Title = (health.ToString());
                                                            Console.ReadKey();
                                                            pots();
                                                        }
                                                        Console.Title = (health.ToString());
                                                        Console.ReadKey();
                                                        pots();
                                                        break;
                                                    case "no":
                                                    case "n":
                                                        pots();
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have enough points!");
                                            pots();
                                        }
                                        break;
                                    case "attack":
                                        if (skill_points >= att_pts)
                                        {
                                            he = (helth_pts + 1);
                                            Console.WriteLine("Are you sure? <+ 1 attack>");
                                            while (true)
                                            {
                                                string asdf = Console.ReadLine();
                                                asdf = asdf.ToLower();
                                                switch (asdf)
                                                {
                                                    case "yes":
                                                    case "y":
                                                        Console.WriteLine("Training complete! (you had to un-equip your weapons)");
                                                        PrIm.Clear();
                                                        SeCo.Clear();
                                                        File.WriteAllText(curetna + @"\SAVEGAME\Prim.txt", String.Empty);
                                                        File.WriteAllText(curetna + @"\SAVEgAME\Prim.txt", String.Empty);
                                                        prim = String.Empty;
                                                        seco = String.Empty;
                                                        int hps = apn;
                                                        skill_points = skill_points - hps;
                                                        att_pts++;
                                                        classAtt = classAtt + 1;
                                                        attp = classAtt;
                                                        atts = classAtt;
                                                        Console.Title = (health.ToString());
                                                        Console.ReadKey();
                                                        pots();
                                                        break;
                                                    case "no":
                                                    case "n":
                                                        pots();
                                                        break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have enough points!");
                                            pots();
                                        }
                                        break;
                                    case "exit":
                                        TesatQ();
                                        Console.Clear();
                                        break;
                                    default:
                                        Console.WriteLine("That is not a valid option!");
                                        break;
                                }
                            }
                        case "n":
                        case "no":
                            TesatQ();
                            break;
                        default:
                            Console.WriteLine("'yes' or 'no'");
                            break;
                    }
                }
            }
        }
        public static void xpps()//
        {
            first = 0;
            if (xp < xpt)
            {
                Console.WriteLine("Your xp: {0}", xp);
                Console.WriteLine("You need {0}xp to become level {1} ({2}/{3})", (xpt - xp), (level + 1), xp, xpt);
                Console.WriteLine("Press any key");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                while (xp > xpt)
                {
                    Console.WriteLine("");
                    level++;
                    int skpe = level + 3;
                    Console.WriteLine("You leveled up to {0}! You need {1}xp to become leved {2}", level, (-(xpt - xp)), (level + 1));
                    Console.WriteLine("You have earned {0} skill points!", skpe);
                    skill_points = skill_points + skpe;
                    xpt = xpt * 2;
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public static void help()//////
        {
            Console.WriteLine("");
            Console.WriteLine("----------MAJOR----------");
            Console.WriteLine("'potion'              USE POTION");
            Console.WriteLine("'store'               OPENS STORE");
            Console.WriteLine("'next battle          STARTS NEXT BATTLE");
            Console.WriteLine("");
            Console.WriteLine("----------BATTLE----------");
            Console.WriteLine("'attack_p'            ATTACKS DURING BATTLE (PRIMARY)");
            Console.WriteLine("'attack_s'            ATTACKS DURING BATTLE (SECENDARY)");
            Console.WriteLine("'defend'              DEFENDS DURING BATTLE <*2 DEF>");
            Console.WriteLine("'flee'                ATTEMPS TO FLEE");
            Console.WriteLine("");
            Console.WriteLine("----------COMMANDS----------");
            Console.WriteLine("'cls'                 CLEARS THE SCREEN");
            Console.WriteLine("'stat'                DISPLAYS STATS");
            Console.WriteLine("'inventory'           DISPLAYES INVENTORY");
            Console.WriteLine("'xp'                  DISPLAYS XP");
            Console.WriteLine("'money'               DISPLAYS COINS");
            Console.WriteLine("'kills'               DISPLAYES KILLS");
            Console.WriteLine("'exit'               LOGS OUT CHARACTER TO HOMELAND");
            Console.WriteLine("'suicide'             KILLS CHARACTER");
            Console.WriteLine("'skill'               USE SKILL POINTS");
            Console.WriteLine("----------SETTINGS----------");
            Console.WriteLine("'sound'               SOUND OPTIONS");
            Console.WriteLine("'song'                CHOOSE SONG");
            Console.WriteLine("");
        }
        public static void song()
        {
            Console.Clear();
            string MusicFile = curetna + @"\MUSIC\BACKMUSIC";
            foreach (var files in Directory.GetFiles(MusicFile))
            {
                FileInfo info = new FileInfo(files);
                var fileName = Path.GetFileName(info.FullName);
                Console.WriteLine("----------MUSIC----------");
                Console.WriteLine(fileName + "");
                Console.WriteLine("----------");
            }
            Console.WriteLine("What would you like to play? (don't use .mp3)");
            Console.WriteLine("Type in 'Add music' to open up the music folder");
            Console.WriteLine("Do not upload a song named 'Add music'!");
            string musictoPlay = Console.ReadLine();
            if (musictoPlay != "Add music")
            {
                if (File.Exists(curetna + @"\MUSIC\BACKMUSIC\" + musictoPlay + ".mp3"))
                {
                    try
                    {
                        MusicPlayer.URL = curetna + @"\MUSIC\BACKMUSIC\" + musictoPlay + ".mp3";
                        MusicPlayer.settings.volume = BMV;
                        MusicPlayer.controls.play();
                    }
                    catch
                    {
                        Console.WriteLine("Failed to load song. Please try again!");

                    }
                }
                else
                {
                    Console.WriteLine("There is no song named {0}.mp3 in the directory {1}", musictoPlay, curetna + @"\MUSIC\BACKMUSIC\" + musictoPlay + ".mp3");
                }
            }
            else
            {
                string CurentFolder = Environment.CurrentDirectory;
                string filePath = @"\MUSIC";
                string argument = @"\select, " + filePath;
                string Folder = CurentFolder + @"\MUSIC\BACKMUSIC";
                Process.Start("explorer.exe", Folder);
                song();
            }
        }
        public static void Massassin()
        {
            NameOfMob = "ASSASSIN";
            ml = 1;
            MHealth = 50;
            MAtt = 8;
            Mdef = 3;
            while (ml < level)
            {
                ml = ml + 1;
                MHealth = MHealth + 5;
                MAtt = MAtt + 2;
                Mdef = Mdef + 2;
            }
            battle();
        }
        public static void ogre()
        {
            NameOfMob = "OGRE";
            ml = 1;
            MHealth = 20;
            MAtt = 8;
            Mdef = 0;
            while (ml < stage)
            {
                ml = ml + 1;
                MHealth = MHealth + 5;
                MAtt = MAtt + 1;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void elf()
        {
            NameOfMob = "ELF";
            ml = 1;
            MHealth = 20;
            MAtt = 8;
            Mdef = 1;
            while (ml < stage)
            {
                ml++;
                MHealth = MHealth + 5;
                MAtt = MAtt + 1;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void goblin()
        {
            NameOfMob = "GOBLIN";
            ml = 1;
            MHealth = 20;
            MAtt = 9;
            Mdef = 0;
            while (ml < stage)
            {
                ml++;
                MHealth = MHealth + 7;
                MAtt = MAtt + 2;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void giant()
        {
            NameOfMob = "GIANT";
            ml = 1;
            MHealth = 30;
            MAtt = 10;
            Mdef = 0;
            while (ml < stage)
            {
                ml++;
                MHealth = MHealth + 5;
                MAtt = MAtt + 2;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void rogue()
        {
            NameOfMob = "ROGUE";
            if (level < 5)
                ml = 1;
            MHealth = 25;
            MAtt = 9;
            Mdef = 1;
            while (ml < stage)
            {
                ml++;
                MHealth = MHealth + 5;
                MAtt = MAtt + 1;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void inven()
        {
            b.URL = curetna + @"\MUSIC\OPENINV.mp3";
            b.settings.volume = INVOPV;
            b.controls.play();
            invens.ForEach(Console.WriteLine);
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("equip");
            Console.WriteLine("remove");
            Console.WriteLine("exit");
            while (true)
            {
                string y = Console.ReadLine();
                y = y.ToLower();
                //if (y.Contains("exit"))
                //{
                //    TesatQ();
                //}
                #region INV regular mage staff
                if (y.Contains("equip") && y.Contains("regular mage staff") && y.Contains("primary"))
                {
                    if (clasl == "mage")
                    {
                        PrIm.Clear();
                        prim = "regular mage staff";
                        PrIm.Add("rusty dagger");
                        attp = mage_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not a mage!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("equip") && y.Contains("regular mage staff") && y.Contains("secondary"))
                {
                    if (clasl == "mage")
                    {
                        SeCo.Clear();
                        SeCo.Add("regular mage staff");
                        seco = "regular mage staff";
                        atts = mage_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not a mage!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("regular mage staff"))
                {
                    invens.Remove("regular mage staff");
                    if (PrIm.Contains("regular mage staff") || prim == "regular mage staff")
                    {
                        PrIm.Remove("regular mage staff");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("regular mage staff") || seco == "regular mage staff")
                    {
                        SeCo.Remove("regular mage staff");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //INV regular mage staff ? ////
                ////

                #region rusty dagger
                if (y.Contains("equip") && y.Contains("rusty dagger") && y.Contains("primary"))
                {
                    PrIm.Clear();
                    prim = "rusty dagger";
                    PrIm.Add("rusty dagger");
                    attp = rusty_dagger_att + classAtt;
                    Console.WriteLine("equiped");
                    Console.WriteLine("");
                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                    b.settings.volume = MIINVV;
                    b.controls.play();
                    TesatQ();
                }
                else
                {
                    Console.WriteLine("You do not have that item!");
                }
                if (y.Contains("equip") && y.Contains("rusty dagger") && y.Contains("secondary"))
                {
                    SeCo.Clear();
                    SeCo.Add("rusty dagger");
                    seco = "rusty dagger";
                    atts = rusty_dagger_att + classAtt;
                    Console.WriteLine("equiped");
                    Console.WriteLine("");
                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                    b.settings.volume = MIINVV;
                    b.controls.play();
                    TesatQ();
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("rusty dagger"))
                {
                    invens.Remove("rusty dagger");
                    if (PrIm.Contains("rusty dagger") || prim == "rusty dagger")
                    {
                        PrIm.Remove("rusty dagger");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("rusty dagger") || seco == "rusty dagger")
                    {
                        SeCo.Remove("rusty dagger");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //INV rusty dagger ////
                ////

                #region INV golden dagger
                if (y.Contains("equip") && y.Contains("golden dagger") && y.Contains("primary"))
                {
                    if (clasl == "assassin")
                    {
                        PrIm.Clear();
                        prim = "golden dagger";
                        PrIm.Add("golden dagger");
                        attp = mage_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not an assassin!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("equip") && y.Contains("golden dagger") && y.Contains("secondary"))
                {
                    if (clasl == "assassin")
                    {
                        SeCo.Clear();
                        SeCo.Add("golden dagger");
                        seco = "golden dagger";
                        atts = mage_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("golden dagger"))
                {
                    invens.Remove("golden dagger");
                    if (PrIm.Contains("golden dagger") || prim == "golden dagger")
                    {
                        PrIm.Remove("golden dagger");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("golden dagger") || seco == "golden dagger")
                    {
                        SeCo.Remove("golden dagger");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //INV rusty dagger
                ////

                #region broken bow
                if (y.Contains("equip") && y.Contains("broken bow") && y.Contains("primary"))
                {
                    if (clasl == "ranger")
                    {
                        PrIm.Clear();
                        prim = "broken bow";
                        PrIm.Add("broken bow");
                        attp = broken_bow_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not a ranger!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("equip") && y.Contains("broken bow") && y.Contains("secondary"))
                {
                    if (clasl == "ranger")
                    {
                        SeCo.Clear();
                        SeCo.Add("broken bow");
                        seco = "broken bow";
                        atts = broken_bow_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("broken bow"))
                {
                    invens.Remove("broken bow");
                    if (PrIm.Contains("broken bow") || prim == "broken bow")
                    {
                        PrIm.Remove("broken bow");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("broken bow") || seco == "broken bow")
                    {
                        SeCo.Remove("broken bow");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //INV broken bow
                ////

                #region chipped short sword
                if (y.Contains("equip") && y.Contains("chipped short sword") && y.Contains("primary"))
                {
                    if (clasl == "warrior")
                    {
                        PrIm.Clear();
                        prim = "chipped short sword";
                        PrIm.Add("chipped short sword");
                        attp = chipped_short_sword_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("equip") && y.Contains("chipped short sword") && y.Contains("secondary"))
                {
                    if (clasl == "ranger")
                    {
                        SeCo.Clear();
                        SeCo.Add("chipped short sword");
                        seco = "chipped short sword";
                        atts = chipped_short_sword_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("chipped short sword"))
                {
                    invens.Remove("chipped short sword");
                    if (PrIm.Contains("chipped short sword") || prim == "chipped short sword")
                    {
                        PrIm.Remove("chipped short sword");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("chipped short sword") || seco == "chipped short sword")
                    {
                        SeCo.Remove("chipped short sword");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //Chipped short sword
                ////

                #region cracked staff
                if (y.Contains("equip") && y.Contains("cracked staff") && y.Contains("primary"))
                {
                    if (clasl == "assassin" || clasl == "mage")
                    {
                        PrIm.Clear();
                        prim = "cracked staff";
                        PrIm.Add("cracked staff");
                        attp = cracked_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                if (y.Contains("equip") && y.Contains("cracked staff") && y.Contains("secondary"))
                {
                    if (clasl == "assassin" || clasl == "mage")
                    {
                        SeCo.Clear();
                        SeCo.Add("cracked staff");
                        seco = "cracked staff";
                        atts = cracked_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not an assassin or a mage!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("cracked staff"))
                {
                    invens.Remove("cracked staff");
                    if (PrIm.Contains("cracked staff") || prim == "cracked staff")
                    {
                        PrIm.Remove("cracked staff");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("cracked staff") || seco == "cracked staff")
                    {
                        SeCo.Remove("cracked staff");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //cracked staff
                ////

                #region stick bow
                if (y.Contains("equip") && y.Contains("stick bow") && y.Contains("primary"))
                {
                    if (clasl == "ranger")
                    {
                        PrIm.Clear();
                        prim = "stick bow";
                        PrIm.Add("stick bow");
                        attp = sti_long_bow_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                if (y.Contains("equip") && y.Contains("stick bow") && y.Contains("secondary"))
                {
                    if (clasl == "ranger")
                    {
                        SeCo.Clear();
                        SeCo.Add("stick bow");
                        seco = "stick bow";
                        atts = cracked_staff_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not a ranger!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("stick bow"))
                {
                    invens.Remove("stick bow");
                    if (PrIm.Contains("stick bow") || prim == "stick bow")
                    {
                        PrIm.Remove("stick bowf");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("stick bow") || seco == "stick bow")
                    {
                        SeCo.Remove("stick bow");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //stick bow
                ////

                #region short sword
                if (y.Contains("equip") && y.Contains("short sword") && y.Contains("primary"))
                {
                    if (clasl == "warrior")
                    {
                        PrIm.Clear();
                        prim = "short sword";
                        PrIm.Add("short sword");
                        attp = short_sword_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                if (y.Contains("equip") && y.Contains("short sword") && y.Contains("secondary"))
                {
                    if (clasl == "warrior")
                    {
                        SeCo.Clear();
                        SeCo.Add("warrior");
                        seco = "warrior";
                        atts = short_sword_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not a warrior");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("short sword"))
                {
                    invens.Remove("short sword");
                    if (PrIm.Contains("short sword") || prim == "short sword")
                    {
                        PrIm.Remove("short sword");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("short sword") || seco == "short sword")
                    {
                        SeCo.Remove("short sword");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion //cracked staff
                ////

                #region poison dagger
                if (y.Contains("equip") && y.Contains("equip") && y.Contains("primary"))
                {
                    if (clasl == "assassin")
                    {
                        PrIm.Clear();
                        prim = "poison dagger";
                        PrIm.Add("poison dagger");
                        attp = posion_dagger_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                if (y.Contains("equip") && y.Contains("poison dagger") && y.Contains("secondary"))
                {
                    if (clasl == "assassin")
                    {
                        SeCo.Clear();
                        SeCo.Add("poison dagger");
                        seco = "poison dagger";
                        atts = posion_dagger_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not an assassin!");
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                if (y.Contains("remove") && y.Contains("poison dagger"))
                {
                    invens.Remove("poison dagger");
                    if (PrIm.Contains("poison dagger") || prim == "poison dagger")
                    {
                        PrIm.Remove("poison dagger");
                        prim = "";
                        attp = 0;
                        File.WriteAllText("Prim.txt", String.Empty);
                    }
                    if (SeCo.Contains("poison dagger") || seco == "poison dagger")
                    {
                        SeCo.Remove("poison dagger");
                        seco = "";
                        atts = 0;
                        File.WriteAllText("Seco.txt", String.Empty);
                    }
                }
                //else
                //{
                //    Console.WriteLine("You do not have that item!");
                //}
                #endregion
                ////

                #region regular dagger
                if (y.Contains("equip") && y.Contains("regular dagger") && y.Contains("primary"))
                {
                    if (clasl != String.Empty)
                    {
                        PrIm.Clear();
                        prim = "regular dagger";
                        PrIm.Add("regular dagger");
                        attp = reg_dagger_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                }
                if (y.Contains("equip") && y.Contains("regular dagger") && y.Contains("secondary"))
                {
                    if (clasl != "")
                    {
                        SeCo.Clear();
                        SeCo.Add("poison dagger");
                        seco = "poison dagger";
                        atts = posion_dagger_att + classAtt;
                        Console.WriteLine("equiped");
                        Console.WriteLine("");
                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                        b.settings.volume = MIINVV;
                        b.controls.play();
                        TesatQ();
                    }
                    else
                    {
                        Console.WriteLine("You are not an assassin!");
                    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("remove") && y.Contains("regular dagger"))
                    {
                        invens.Remove("regular dagger");
                        if (PrIm.Contains("regular dagger") || prim == "regular dagger")
                        {
                            PrIm.Remove("regular dagger");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("regular dagger") || seco == "regular dagger")
                        {
                            SeCo.Remove("regular dagger");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                #endregion
                    ////

                    #region meduim long bow
                    if (y.Contains("equip") && y.Contains("meduim long bow") && y.Contains("primary"))
                    {
                        if (clasl == "ranger")
                        {
                            PrIm.Clear();
                            prim = "meduim long bow";
                            PrIm.Add("meduim long bow");
                            attp = med_long_bow_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("meduim long bow") && y.Contains("secondary"))
                    {
                        if (clasl != "ranger")
                        {
                            SeCo.Clear();
                            SeCo.Add("meduim long bow");
                            seco = "meduim long bow";
                            atts = med_long_bow_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a ranger!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("remove") && y.Contains("meduim long bow"))
                    {
                        invens.Remove("meduim long bow");
                        if (PrIm.Contains("meduim long bow") || prim == "meduim long bow")
                        {
                            PrIm.Remove("meduim long bow");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("meduim long bow") || seco == "meduim long bow")
                        {
                            SeCo.Remove("meduim long bow");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region meduim long sword
                    if (y.Contains("equip") && y.Contains("medium long sword") && y.Contains("primary"))
                    {
                        if (clasl == "warrior")
                        {
                            PrIm.Clear();
                            prim = "medium long sword";
                            PrIm.Add("medium long sword");
                            attp = med_long_sword_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }

                    if (y.Contains("equip") && y.Contains("medium long sword") && y.Contains("secondary"))
                    {
                        if (clasl == "warrior")
                        {
                            SeCo.Clear();
                            SeCo.Add("medium long sword");
                            seco = "medium long sword";
                            atts = med_long_sword_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a warrior!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("remove") && y.Contains("medium long sword"))
                    {
                        invens.Remove("medium long sword");
                        if (PrIm.Contains("medium long sword") || prim == "medium long sword")
                        {
                            PrIm.Remove("medium long sword");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("medium long sword") || seco == "medium long sword")
                        {
                            SeCo.Remove("medium long sword");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region short dagger
                    if (y.Contains("equip") && y.Contains("short dagger") && y.Contains("primary"))
                    {
                        if (clasl == "rogue")
                        {
                            PrIm.Clear();
                            prim = "short dagger";
                            PrIm.Add("short dagger");
                            attp = short_dagger_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("short dagger") && y.Contains("secondary"))
                    {
                        if (clasl == "rogue")
                        {
                            SeCo.Clear();
                            SeCo.Add("short dagger");
                            seco = "short dagger";
                            atts = short_dagger_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a rogue!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("remove") && y.Contains("short dagger"))
                    {
                        invens.Remove("short dagger");
                        if (PrIm.Contains("short dagger") || prim == "short dagger")
                        {
                            PrIm.Remove("short dagger");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("short dagger") || seco == "short dagger")
                        {
                            SeCo.Remove("short dagger");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region short staff
                    if (y.Contains("equip") && y.Contains("short staff") && y.Contains("primary"))
                    {
                        if (clasl == "assassin")
                        {
                            PrIm.Clear();
                            prim = "short staff";
                            PrIm.Add("short staff");
                            attp = short_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("short staff") && y.Contains("secondary"))
                    {
                        if (clasl == "assassin")
                        {
                            SeCo.Clear();
                            SeCo.Add("short staff");
                            seco = "short staff";
                            atts = short_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a warrior!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("short staff") && y.Contains("short staff"))
                    {
                        invens.Remove("short staff");
                        if (PrIm.Contains("short staff") || prim == "short staff")
                        {
                            PrIm.Remove("short staff");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("short staff") || seco == "short staff")
                        {
                            SeCo.Remove("short staff");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region long sword
                    if (y.Contains("equip") && y.Contains("long sword") && y.Contains("primary"))
                    {
                        if (clasl == "warrior")
                        {
                            PrIm.Clear();
                            prim = "long sword";
                            PrIm.Add("long sword");
                            attp = long_sword_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("long sword") && y.Contains("secondary"))
                    {
                        if (clasl == "warrior")
                        {
                            SeCo.Clear();
                            SeCo.Add("long sword");
                            seco = "long sword";
                            atts = long_sword_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a warrior!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("long sword") && y.Contains("long sword"))
                    {
                        invens.Remove("long sword");
                        if (PrIm.Contains("long sword") || prim == "long sword")
                        {
                            PrIm.Remove("long sword");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("long sword") || seco == "long sword")
                        {
                            SeCo.Remove("long sword");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region long bow
                    if (y.Contains("equip") && y.Contains("long bow") && y.Contains("primary"))
                    {
                        if (clasl == "ranger")
                        {
                            PrIm.Clear();
                            prim = "long bow";
                            PrIm.Add("long bow");
                            attp = long_bow_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("long bow") && y.Contains("secondary"))
                    {
                        if (clasl == "ranger")
                        {
                            SeCo.Clear();
                            SeCo.Add("long bow");
                            seco = "long bow";
                            atts = long_bow_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a ranger!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("long bow") && y.Contains("long bow"))
                    {
                        invens.Remove("long bow");
                        if (PrIm.Contains("long bow") || prim == "long bow")
                        {
                            PrIm.Remove("long bow");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("long bow") || seco == "long bow")
                        {
                            SeCo.Remove("long bow");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region silver dagger
                    if (y.Contains("equip") && y.Contains("silver dagger") && y.Contains("primary"))
                    {
                        if (clasl == "rogue")
                        {
                            PrIm.Clear();
                            prim = "silver dagger";
                            PrIm.Add("silver dagger");
                            attp = sil_dagger_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("silver dagger") && y.Contains("secondary"))
                    {
                        if (clasl == "rogue")
                        {
                            SeCo.Clear();
                            SeCo.Add("silver dagger");
                            seco = "silver dagger";
                            atts = sil_dagger_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a rogue!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("silver dagger") && y.Contains("remove"))
                    {
                        invens.Remove("silver dagger");
                        if (PrIm.Contains("silver dagger") || prim == "silver dagger")
                        {
                            PrIm.Remove("silver dagger");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("silver dagger") || seco == "silver dagger")
                        {
                            SeCo.Remove("silver dagger");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region  mage staff
                    if (y.Contains("equip") && y.Contains("mage staff") && y.Contains("primary"))
                    {
                        if (clasl == "mage")
                        {
                            PrIm.Clear();
                            prim = "mage staff";
                            PrIm.Add("mage staff");
                            attp = mage_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("mage staff") && y.Contains("secondary"))
                    {
                        if (clasl == "mage")
                        {
                            SeCo.Clear();
                            SeCo.Add("mage staff");
                            seco = "mage staff";
                            atts = mage_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a mage!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have that item!");
                    }
                    if (y.Contains("mage staff") && y.Contains("remove"))
                    {
                        invens.Remove("mage staff");
                        if (PrIm.Contains("mage staff") || prim == "mage staff")
                        {
                            PrIm.Remove("mage staff");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("mage staff") || seco == "mage staff")
                        {
                            SeCo.Remove("mage staff");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region bow staff
                    if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("primary"))
                    {
                        if (clasl == "assasin")
                        {
                            PrIm.Clear();
                            prim = "bow staff";
                            PrIm.Add("bow staff");
                            attp = bow_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                    }
                    if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("secondary"))
                    {
                        if (clasl == "assassin")
                        {
                            SeCo.Clear();
                            SeCo.Add("bow staff");
                            seco = "bow staff";
                            atts = bow_staff_att + classAtt;
                            Console.WriteLine("equiped");
                            Console.WriteLine("");
                            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                            b.settings.volume = MIINVV;
                            b.controls.play();
                            TesatQ();
                        }
                        else
                        {
                            Console.WriteLine("You are not a assassin!");
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    if (y.Contains("bow staff") && y.Contains("remove"))
                    {
                        invens.Remove("bow staff");
                        if (PrIm.Contains("bow staff") || prim == "bow staff")
                        {
                            PrIm.Remove("bow staff");
                            prim = "";
                            attp = 0;
                            File.WriteAllText("Prim.txt", String.Empty);
                        }
                        if (SeCo.Contains("bow staff") || seco == "bow staff")
                        {
                            SeCo.Remove("bow staff");
                            seco = "";
                            atts = 0;
                            File.WriteAllText("Seco.txt", String.Empty);
                        }
                    }
                    //else
                    //{
                    //    Console.WriteLine("You do not have that item!");
                    //}
                    #endregion
                    ////

                    #region tin hat
                    #endregion


                }
            }
        }////
        public static void TesatQ()//
        {
            scorea = ((dek * 2) + xp * 2) + dek;
            bool tell = true;
            while (tell)
            {
                if (first == 1)
                {
                    sw.Start();
                    xpps();
                }
                else
                {
                    if (in_dungon == false)
                    {
                        if (health >= 0)
                        {
                            Console.Title = (health.ToString());
                            Console.WriteLine("LAND: {0} HP: {1}, Kills: {2} Stage: {3} LEVEL: {4} SCORE: {5}", wourld, health, dek, stage, level, scorea);
                            Console.WriteLine("");
                            a = Console.ReadLine();
                            a = a.ToLower();
                            sw.Start();
                            switch (a)
                            {
                                case "exit":
                                    Console.WriteLine();
                                    Console.WriteLine("Are you sure you want to exit the arena, and go to the homeland?");
                                    while (true)
                                    {
                                        string yn = Console.ReadLine();
                                        yn = yn.ToLower();
                                        switch(yn)
                                        {
                                            case "yes":
                                            case "y":
                                                Program.load_or_new();
                                                break;
                                            case "no":
                                            case "n":
                                                Console.WriteLine();
                                                break;
                                        }
                                    }
                                    break;
                                case "next battle":
                                    StartBattle();
                                    break;
                                case "help":
                                    Console.WriteLine("");
                                    help();
                                    break;
                                case "inventory":
                                    Console.WriteLine("");
                                    inven();
                                    break;
                                case "stat":
                                    Console.WriteLine("");
                                    Stat();
                                    break;
                                case "cls":
                                    Console.Clear();
                                    break;
                                case "xp":
                                    Console.WriteLine("");
                                    xpps();
                                    break;
                                case "potion":
                                    Console.WriteLine("");
                                    potion();
                                    break;
                                case "store":
                                    Console.WriteLine("");
                                    store();
                                    break;
                                case "money":
                                    Console.WriteLine("");
                                    money();
                                    break;
                                case "kills":
                                    Console.WriteLine("");
                                    defk();
                                    break;
                                case "suicide":
                                    SuicKil();
                                    break;
                                case "skill":
                                    pots();
                                    break;
                                case "sound":
                                    volumesettings();
                                    break;
                                case "song":
                                    song();
                                    break;
                                default:
                                    Console.WriteLine("That is not a valid option! <type 'help' to see the list of avalible actions'>");
                                    Console.WriteLine("");
                                    break;
                            }
                        }

                        else
                        {
                            Console.Clear();
                            death();
                        }
                    }
                }
            }
        }
        public static void Stat()
        {
            Console.Clear();
            Console.WriteLine("Time: {0}", ((float)sw.Elapsed.TotalSeconds / (float)60).ToString("N1") + " min");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Class: {0}", clasl);
            Console.WriteLine("Primary attack: {0}", attp);
            Console.WriteLine("Secendary attack: {0}", atts.ToString());
            Console.WriteLine("Base attack: {0}", classAtt.ToString());
            Console.WriteLine("Defence: {0}", def.ToString());
            Console.WriteLine("Base defence: {0}", classDef.ToString());
            Console.WriteLine("Speed: {0}", speed.ToString());
            Console.WriteLine("Stamina {0}", stam.ToString());
            Console.WriteLine("Range: {0}", range.ToString());
            Console.WriteLine("Health: {0}", health.ToString());
        }
        public static void MobSpawn()
        {
            int kk = rnd.Next(0, 100);
            if (kk >= 80)
            {
                StartBattle();
            }
            else
            {
                Console.WriteLine("Nothing has spawned");
            }
        }
        public static void StartBattle()
        {
            potion_in_Balle = 2;
            spawn = rnd.Next(1, 6);
            number = rnd.Next(1, 3);
            sq = number;
            if (in_dungon == false)
            {
                if (wourld == "arena")
                {
                    switch (spawn)
                    {
                        case 1:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} ogre(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                ogre();
                            }
                            break;
                        case 2:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} elf(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                elf();
                            }
                            break;
                        case 3:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} goblin(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.WriteLine("");
                                Console.Clear();
                                goblin();
                            }
                            break;
                        case 5:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} giant(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                giant();
                            }
                            break;
                        case 4:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} rogue(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                rogue();
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (wourld == "estens")
                {
                    spawn = rnd.Next(1, 7);
                    switch (spawn)
                    {
                        case 1:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} ogre(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                ogre();
                            }
                            break;
                        case 2:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} elf(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                elf();
                            }
                            break;
                        case 3:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} goblin(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.WriteLine("");
                                Console.Clear();
                                goblin();
                            }
                            break;
                        case 5:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} giant(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                giant();
                            }
                            break;
                        case 4:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} rogue(s) has spawned!", sq);
                                Console.WriteLine("Press any key");
                                Console.Clear();
                                rogue();
                            }
                            break;
                        case 6:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} assassin(s) has spawned!", sq);
                            }
                            break;
                    }
                }
            }

            //}
        }
        public static void sqa()
        {
            sq = number;
            battle();
        }
        public static void battle()
        {
            Console.Title = (health.ToString());
            temp_def = def;
            Console.WriteLine("There are {0} {1}", sq, NameOfMob);
            Console.WriteLine("Your current health: {0}", health);
            while (sq > 0)
            {
                Console.WriteLine("Mob(s) current health: {0}", MHealth);
                Console.WriteLine("Mob number: {0}", sq);
                Console.WriteLine("----------BATTLE----------");
                Console.WriteLine("<type 'help' to see the list of avalible commands>");
                while (MHealth > 0)
                {
                    while (health > 0)
                    {
                        if (health > 0)
                        {
                            string wtdb = Console.ReadLine();
                            wdtbl = wtdb.ToLower();
                            switch (wdtbl)
                            {
                                case "attack_p":
                                    int att_m_c = rnd.Next(0, 3);
                                    if (att_m_c == 1)
                                    {
                                        c.URL = curetna + @"\MUSIC\ATTACK.mp3";
                                        c.settings.volume = ATV;
                                        c.controls.play();
                                    }
                                    else
                                    {
                                        c.URL = curetna + @"\MUSIC\ATTACK2.mp3";
                                        c.settings.volume = ATV;
                                        c.controls.play();
                                    }
                                    TextReader tr = new StreamReader(curetna + @"\SAVEGAME\Prim.CommandLineStudiosFile");
                                    string readtoendp = tr.ReadLine();
                                    tr.Close();
                                    //string readtoendp;
                                    //string testp = prim.R;
                                    if (prim != "")
                                    {
                                        //c.URL = curetna + @"\MUSIC\ATTACK2.mp3";
                                        //c.URL = curetna + @"\MUSIC\ATTACK.mp3";
                                        //c.settings.volume = ATV;
                                        //c.controls.play();
                                        Console.WriteLine("----------ATTACKING----------");
                                        int dp = rnd.Next(0, attp);
                                        int dpt = dp - Mdef;
                                        if (dpt > 0)
                                        {
                                            MHealth = MHealth - dpt;
                                            Console.WriteLine("Your attack: {0}", dp);
                                            Console.WriteLine("Dammage delt: {0}", dpt);
                                            Console.WriteLine("{0}'s health: {1}", NameOfMob, MHealth);
                                            MBattle();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your attack: {0}", dp);
                                            Console.WriteLine("Dammage delt: {0}", dpt);
                                            Console.WriteLine("{0}'s health: {1}", NameOfMob, MHealth);
                                            MBattle();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have nothing equipted!");
                                        Console.ReadKey();
                                        break;
                                    }
                                case "attack_s":
                                    if (seco != "")
                                    {
                                        //tr = new StreamReader(curetna + @"\SAVEGAME\Seco.txt");
                                        c.URL = curetna + @"\MUSIC\ATTACK2.mp3";
                                        c.settings.volume = ATV;
                                        c.controls.play();
                                        Console.WriteLine("----------ATTACKING----------");
                                        int ds = rnd.Next(0, atts);
                                        int dpat = ds - Mdef;
                                        if (dpat > 0)
                                        {
                                            MHealth = MHealth - ds;
                                            Console.WriteLine("Your attack: {0}", ds);
                                            Console.WriteLine("Dammage delt: {0}", dpat);
                                            Console.WriteLine("{0}'s health: {1}", NameOfMob, MHealth);
                                            MBattle();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your attack: {0}", ds);
                                            Console.WriteLine("Dammage delt: {0}", dpat);
                                            Console.WriteLine("{0}'s health: {1}", NameOfMob, MHealth);
                                            MBattle();
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You have nothing equipted!");
                                        break;
                                    }
                                case "defend":
                                    temp_def = def * 2;
                                    MBattle();
                                    break;
                                case "potion":
                                    if (potion_in_Balle > 0 && HealthPotions > 0)
                                    {
                                        potion();
                                    }
                                    break;
                                case "flee":
                                    int flee_if = rnd.Next(speed, 100);
                                    if (flee_if > 60)
                                    {
                                        Console.WriteLine("You flee!");
                                        TesatQ();
                                        return;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The enemy blockes the way! You stumble and loose your defence!");
                                        temp_def = 0;
                                        MBattle();
                                    }
                                    break;
                                case "help":
                                    help();
                                    break;
                                default:
                                    Console.WriteLine("Invalid command! <type 'help' to see help>");
                                    break;
                            }
                        }
                        else
                        {
                            death();
                        }
                    }
                    death();
                }
                int x = rnd.Next(1, (number * ((spawn + spawn) * 2)));
                if (t == 0)
                {
                    while (t == 0)
                    {
                        if (spawn != 5)
                        {
                            mcc = rnd.Next(0, (number * spawn) * 2 * spawn);
                            copperc = copperc + mcc;
                            int scr = rnd.Next(0, 10);
                            if (scr == 10)
                            {
                                int scc = rnd.Next(0, (number + spawn) * 2);
                                silverc = silverc + scc;
                            }
                        }
                        else
                        {
                            mcc = rnd.Next(0, (number * spawn) * 5);
                            copperc = copperc + mcc;
                            scc = rnd.Next(0, (number * spawn) * 5);
                            silverc = silverc + scc;
                            gcc = rnd.Next(0, (number * spawn));
                            if (gcc >= 5)
                            {
                                gcc = rnd.Next(0, (number + spawn));
                                goldx = goldx + gcc;
                            }
                        }
                        t = 1;
                    }
                }
                else
                {
                    if (MHealth < 0)
                    {
                        ok = -MHealth;
                        xp_gained = x + ok;
                        Console.WriteLine("You have killed the {0} for {1}xp <+ {2} for overkill>", NameOfMob, x, ok);
                        Console.WriteLine("You have found: {0}cc, {1}sc, {2}gc!", mcc, scc, gcc);
                        Console.WriteLine("Xp gained: {0}", xp_gained);
                        dek++;
                        t = 0;
                        xp = xp + xp_gained;
                        drop_chance();
                        xpps();
                        number = number - 1;
                        sq = number;
                        if (sq == 0)
                        {
                            skill_points++;
                            stage++;
                            TesatQ();
                        }
                        else
                        {
                            if (wourld == "zalenth")
                            {
                                switch (NameOfMob)
                                {
                                    case "GIANT":
                                        giant();
                                        break;
                                    case "ELF":
                                        elf();
                                        break;
                                    case "OGRE":
                                        ogre();
                                        break;
                                    case "ROGUE":
                                        rogue();
                                        break;
                                    case "GOBLIN":
                                        goblin();
                                        break;
                                }
                            }
                            if (wourld == "estens")
                            {
                                if (wourld == "zalenth")
                                {
                                    switch (NameOfMob)
                                    {
                                        case "GIANT":
                                            giant();
                                            break;
                                        case "ELF":
                                            elf();
                                            break;
                                        case "OGRE":
                                            ogre();
                                            break;
                                        case "ROGUE":
                                            rogue();
                                            break;
                                        case "GOBLIN":
                                            goblin();
                                            break;
                                        case "ASSASSIN":
                                            Massassin();
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have killed the {0} for {1}xp", NameOfMob, x);
                        Console.WriteLine("You have found {0}cc, {1}sc, {2}gc!", mcc, scc, gcc);
                        Console.WriteLine("Xp gained: {0}", xp_gained);
                        dek++;
                        t = 0;
                        xp = xp + xp_gained;
                        number = number - 1;
                        sq = number;
                        drop_chance();
                        xpps();
                        if (sq == 0)
                        {
                            skill_points++;
                            stage++;
                            TesatQ();
                        }
                        else
                        {
                            switch (NameOfMob)
                            {
                                case "GIANT":
                                    giant();
                                    break;
                                case "ELF":
                                    elf();
                                    break;
                                case "OGRE":
                                    ogre();
                                    break;
                                case "ROGUE":
                                    rogue();
                                    break;
                                case "GOBLIN":
                                    goblin();
                                    break;
                            }
                        }
                    }
                }
            }
        }
        public static void attm()
        {
            string curetn = Environment.CurrentDirectory;
            string attm = curetn + @"\MUSIC\ATTACK.mp3";
            string attm2 = curetn + @"\MUSIC\ATTACK2.mp3";
            WMPLib.WindowsMediaPlayer c = new WMPLib.WindowsMediaPlayer();
            c.controls.play();
            int baletmusi = rnd.Next(0, 3);
            if (baletmusi == 1)
            {
                c.URL = attm2;
                c.controls.play();
                c.close();
            }
            else
            {
                try
                {
                    c.URL = attm;
                    c.controls.play();
                    c.close();
                }
                catch
                {
                    c.URL = attm2;
                    c.controls.play();
                    c.close();
                }
            }
        }
        public static void MBattle()
        {
            bool inbat = true;
            while (inbat)
            {
                int atc = rnd.Next(0, 100);
                if (atc != 9990)
                {
                    int Mdr = rnd.Next(1, MAtt);
                    //Mdr = Mdr * 2;
                    int Md = (Mdr - temp_def);
                    if (Md > 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------MOB ATTACKING---------");
                        Console.WriteLine("{0}'s attack: {1}", NameOfMob, Md);
                        Console.WriteLine("Dammage taken: {0}", Md);
                        health = health - (Md);
                        battle();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("----------MOB ATTACKING----------");
                        Console.WriteLine("{0}'s attack: {1}", NameOfMob, 0);
                        Console.WriteLine("Dammage taken: {0}", 0);
                        battle();
                    }
                }
                else
                {
                    Console.WriteLine("The {0} misses!", NameOfMob);
                    battle();
                }
            }
        }
    }
}
