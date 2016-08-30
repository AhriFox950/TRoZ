#region ALL
#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Media;
#endregion //USING
//using Class1;
#region NAMESPACE
namespace ZALENTH
{
    #region CLASS
    class Program
    {
        #region STATIC VARIABLES
        //STATIC VARIABLES
        public static bool inconsole = false;
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
        static string path = curetna + @"\SAVEGAME\SaveGame.CommandLineStudiosFile";

        //static string product_key = curenta + @"\SAVEGAME\ProductKey.CommandLineStudiosFile";

        static string Folder = curetna + @"\MUSIC";
        static string FolderToGoTo = curetna + @"\MUSIC\BACKMUSIC";
        //
        static Stopwatch sw = new Stopwatch();
        static string curetna = Environment.CurrentDirectory;
        static string movem = curetna + @"\MUSIC\MOVING.mp3";
        static int he;
        static WMPLib.WindowsMediaPlayer b = new WMPLib.WindowsMediaPlayer();
        public static WMPLib.WindowsMediaPlayer MusicPlayer = new WMPLib.WindowsMediaPlayer();
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
        public static string seco = String.Empty;
        public static string prim = String.Empty;
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
        public static string wourld;
        public static int first = 1;
        //static string progressBarElement = health.ToString();
        public static int scorea = 0;
        public static int s;
        public static int ml;
        //----------SELF----------
        public static int max_health;
        public static int classDef;
        public static int classAtt;
        public static int copperc = 20;
        public static int silverc = 0;
        public static int goldx = 0;
        public static Random rnd = new Random();
        public static int HealthPotions = 0;
        public static string version = "alzh0.0.1.3.4db";
        public static string ynl;
        public static int okxp;
        public static int ok;
        public static string NameOfMob;
        public static int xpt = 100;
        public static int xp = 0;
        public static int level = 1;
        public static int health;
        public static string wdtbl;
        public static int max_xc = 3;
        public static int max_yc = 3;
        public static int umax_xc = -3;
        public static int umax_yc = -3;
        public static int xc;
        public static int yc;
        public static string a;
        public static int curenta = 1;
        public static int attp;
        public static int atts;
        public static int def;
        public static int speed;
        public static int stam;
        public static int range;
        public static string name;
        public static string clasl;
        public static int score = dek + (xp / 2) + level * 2;
        public static List<string> invens = new List<string>();
        public static string chexk;

        static string checka = "FPYOvrTPASwGD=WZedoevz%M(kcgWmvvf&peGSD;lfkja;lkit&*(f82379sDLKFJA;LKTJLksjdlKFJS8A9SD8FP*&%tGy^%/>jdpity[-+9DE]YOvrTPASwGD=WZedoevz%M(kcgWmvvf&peG";
        //----------MOBS----------
        static int MHealth;
        static int MAtt;
        static int Mdef;
        static int spawn;
        static int number;

        static TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
        #endregion //STATIC VARIABLES
        #region VOIDS
        //STATIC VOIDS
        public static void Main(string[] args)
        {
            Lists.first_player1 = true;
            Lists.first_player2 = true;
            start();
        }
        public static void start()
        {
            Console.Title = "The Rise of Zalenth";
            //title = progressBarElement;121`   
            Music();
            Console.Clear();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("The rise of ZALENTH");
            Console.WriteLine("Version: {0}", version);
            Console.WriteLine("DISCLAMER: I do not own any background music. ALL credit goes to the artists!");
            Console.WriteLine("Press any key to begin your adventure");
            Console.ReadKey();
            Console.Clear();
            //classS();
            load_or_new();
        }
        public static void Load_Add_On()
        {

            //string product_key = curetna + @"\ADDON\DLC.CommandLineStudiosFile";
            //if (!File.Exists(product_key))
            //{
            //    Console.WriteLine("You do not have the arena DLC!");
            //    TextWriter tw = new StreamWriter(product_key);
            //    tw.WriteLine();
            //    tw.Close();
            //}
            //else
            //{
            //    string specificFolder = Path.Combine(folder, "The_Rise_Of_Zalenth");
            //    string spef = Path.Combine(specificFolder, "Product");
            //    if (!Directory.Exists(specificFolder))
            //    {
            //        Directory.CreateDirectory(specificFolder);
            //        Directory.CreateDirectory(spef);
            //    }
            //    if (!File.Exists(folder + @"The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile"))
            //    {
            //        StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
            //        tw.Close();
            //    }
            //    else
            //    {
            //        StreamReader tr = new StreamReader(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
            //        check = tr.ReadLine();
            //        tr.Close();
            //    }
            //    if (check == product_code)
            //    {
            //        Console.WriteLine("Thank you!");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.Write("Product code: ");
            //        string pc = Console.ReadLine();
            //        if (pc == product_code)
            //        {
            //            File.WriteAllText(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile", String.Empty);
            //            StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
            //            tw.WriteLine(product_code);
            //            tw.Close();
            //            Console.WriteLine("Thank you for download the Rise of Zalenth's first addon, Rise of Zalenth Arena!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorect product code!");
            //        }
            //    }                
            //}
            string product_key = curetna + @"\ADDON\ArenaDLC.CommandLineStudiosFile";
            string product_key_Mul = curetna + @"\ADDON\MulitplayerDLC.CommandLineStudiosFile";
            if (!File.Exists(product_key))
            {
                Console.WriteLine("You do not have the arena DLC!");
            }
            if (File.Exists(product_key))
            {
                Lists.Downloaded_DLC.Add("The Rise Of Zalenth: Arena");
            }
            if (!File.Exists(product_key_Mul))
            {
                Console.WriteLine("You do not have the multiplayer DLC");
            }
            if (File.Exists(product_key_Mul))
            {
                Lists.Downloaded_DLC.Add("The Rise Of Zalenth: Multiplayer");
            }
            if (File.Exists(product_key))
            {
                Console.WriteLine("---------------ADDONS---------------");
                foreach (string s in Lists.Downloaded_DLC)
                {
                    Console.WriteLine(s);
                }
                while (true)
                {
                    Console.Write("Load: ");
                    string loadingADDON = Console.ReadLine();
                    loadingADDON = loadingADDON.ToLower();
                    if (loadingADDON == "the rise of zalenth: arena" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Arena"))
                    {
                        Arena.arena();
                    }
                    if (loadingADDON == "the rise of zalenth: multiplayer" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Multiplayer"))
                    {
                        Lists.p1_moves = 5;
                        Lists.p2_moves = 5;
                        TwoPlayer_P1.start();
                    }
                }
                Console.WriteLine("Do you want to load the addon, The Rise of Zalenth Arena?");
                while (true)
                {
                    string yn = Console.ReadLine();
                    yn = yn.ToLower();
                    switch (yn)
                    {
                        case "yes":
                        case "y":
                            Console.Clear();
                            Arena.arena();
                            break;
                        case "no":
                        case "n":
                            break;
                    }
                }
            }
            else
            {
                TextReader tr = new StreamReader(product_key);
                string checking = tr.ReadLine();
                tr.Close();
                if (checking == checka)
                {
                    string specificFolder = Path.Combine(folder, "The_Rise_Of_Zalenth");
                    string spef = Path.Combine(specificFolder, "Product");
                    if (!Directory.Exists(specificFolder))
                    {
                        Directory.CreateDirectory(specificFolder);
                        Directory.CreateDirectory(spef);
                    }
                    if (!File.Exists(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile"))
                    {
                        StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                        tw.Close();
                    }
                    else
                    {
                        StreamReader tra = new StreamReader(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                        check = tra.ReadLine();
                        tra.Close();
                    }
                    if (check == product_code)
                    {
                        Console.WriteLine("---------------ADDONS---------------");
                        foreach (string s in Lists.Downloaded_DLC)
                        {
                            Console.WriteLine(s);
                        }
                        while (true)
                        {
                            Console.Write("Load: ");
                            string loadingADDON = Console.ReadLine();
                            loadingADDON = loadingADDON.ToLower();
                            if (loadingADDON == "the rise of zalenth: arena" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Arena"))
                            {
                                Arena.arena();
                            }
                            if (loadingADDON == "the rise of zalenth: multiplayer" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Multiplayer"))
                            {
                                TwoPlayer_P1.start();
                            }
                        }
                        Console.WriteLine("Do you want to load the addon, The Rise of Zalenth Arena?");
                        while (true)
                        {
                            string yn = Console.ReadLine();
                            yn = yn.ToLower();
                            switch (yn)
                            {
                                case "yes":
                                case "y":
                                    Console.Clear();
                                    Arena.arena();
                                    break;
                                case "no":
                                case "n":
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Product code: ");
                        string pc = Console.ReadLine();
                        if (pc == product_code)
                        {
                            File.WriteAllText(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile", String.Empty);
                            StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                            tw.WriteLine(product_code);
                            tw.Close();
                            Console.WriteLine("Thank you for download the Rise of Zalenth's first addon, Rise of Zalenth Arena!");
                        }
                        else
                        {
                            Console.WriteLine("Incorect product code!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You do not have the arena DLC!");
                }
                Console.WriteLine("---------------ADDONS---------------");
                Console.WriteLine("---------------ADDONS---------------");
                foreach (string s in Lists.Downloaded_DLC)
                {
                    Console.WriteLine(s);
                }
                while (true)
                {
                    Console.Write("Load: ");
                    string loadingADDON = Console.ReadLine();
                    loadingADDON = loadingADDON.ToLower();
                    if (loadingADDON == "the rise of zalenth: arena" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Arena"))
                    {
                        Arena.arena();
                    }
                    if (loadingADDON == "the rise of zalenth: multiplayer" && Lists.Downloaded_DLC.Contains("The Rise Of Zalenth: Multiplayer"))
                    {
                        TwoPlayer_P1.start();
                    }
                }
                Console.WriteLine("Do you want to load the addon, The Rise of Zalenth Arena?");
                while (true)
                {
                    string yn = Console.ReadLine();
                    yn = yn.ToLower();
                    switch (yn)
                    {
                        case "yes":
                        case "y":
                            Console.Clear();
                            Arena.arena();
                            break;
                        case "no":
                        case "n":
                            break;
                    }
                }
            }

        }
        public static void addon()
        {
            string product_key = curetna + @"\ADDON\DLC.CommandLineStudiosFile";
            if (!File.Exists(product_key))
            {
                Console.WriteLine("You do not have the arena DLC!");
                TextWriter tw = new StreamWriter(product_key);
                tw.WriteLine();
                tw.Close();
            }
            else
            {
                string specificFolder = Path.Combine(folder, "The_Rise_Of_Zalenth");
                string spef = Path.Combine(specificFolder, "Product");
                if (!Directory.Exists(specificFolder))
                {
                    Directory.CreateDirectory(specificFolder);
                    Directory.CreateDirectory(spef);
                }
                if (!File.Exists(folder + @"The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile"))
                {
                    StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                    tw.Close();
                }
                else
                {
                    StreamReader tr = new StreamReader(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                    check = tr.ReadLine();
                    tr.Close();
                }
                if (check == product_code)
                {
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.Clear();
                    Console.Write("Product code: ");
                    string pc = Console.ReadLine();
                    if (pc == product_code)
                    {
                        File.WriteAllText(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile", String.Empty);
                        StreamWriter tw = new StreamWriter(folder + @"\The_Rise_Of_Zalenth\Product\ProductCode.CommandLineStudiosFile");
                        tw.WriteLine(product_code);
                        tw.Close();
                        Console.WriteLine("Thank you for download the Rise of Zalenth's first addon, Rise of Zalenth Arena!");
                    }
                    else
                    {
                        Console.WriteLine("Incorect product code!");
                    }
                }
            }
        }
        public static void choose_addon()
        {

        }
        public static void Dungon_1_1()
        {
            in_dungon = true;
            TesatQ();
        }
        public static void CheckForDungon()
        {
            if ((wourld == "zalenth") && (xc == 3 && yc == 3))
            {
                Console.WriteLine("Would you like to enter the dungon?");
                while (true)
                {
                    string DunOrNOt = Console.ReadLine();
                    switch (DunOrNOt)
                    {
                        case "yes":
                        case "y":
                            Dungon_1_1();
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
        }
        public static void tutOrNot()
        {
            Console.WriteLine("Would you like to do the tutorial?");
            while (true)
            {
                string asdf = Console.ReadLine();
                asdf = asdf.ToLower();
                switch (asdf)
                {
                    case "yes":
                    case "y":
                        tutorial();
                        break;
                    case "no":
                    case "n":
                        TesatQ();
                        break;
                    default:
                        Console.WriteLine("Yes or no");
                        break;
                }
            }
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
        public static void load_or_new()
        {
            Console.WriteLine("Would you like to load a file? Or make a new character? ('load' or 'new')");
            Console.WriteLine("");
            while (true)
            {
                string load_or_n = Console.ReadLine();
                load_or_n = load_or_n.ToLower();
                switch (load_or_n)
                {
                    case "load":
                        TextReader tr = new StreamReader(curetna + path);
                        try
                        {
                            string savedfd = tr.ReadLine();
                            if (savedfd == "saved")
                            {
                                string tIf_addon = tr.ReadLine();
                                string tTimeElapsed = tr.ReadLine();
                                string thelth_pts = tr.ReadLine();
                                string tatt_pts = tr.ReadLine();
                                string tdef_pts = tr.ReadLine();
                                string tsepped_pts = tr.ReadLine();
                                string tskill_points = tr.ReadLine();
                                string tlastsave = tr.ReadLine();//
                                //string tprice = tr.ReadLine();  //
                                string tmcc = tr.ReadLine();    //
                                string tscc = tr.ReadLine();    //
                                string tgcc = tr.ReadLine();    //
                                string tt = tr.ReadLine();      //
                                string tdek = tr.ReadLine();    //
                                string titem_level = tr.ReadLine();//
                                string txp_gained = tr.ReadLine();//
                                string tsq = tr.ReadLine();     //
                                string ttemp_def = tr.ReadLine();//
                                string twourld = tr.ReadLine(); //
                                string tfirst = tr.ReadLine();  //
                                string tscorea = tr.ReadLine(); //
                                string ts = tr.ReadLine();      //
                                string tml = tr.ReadLine();     //
                                string tmax_health = tr.ReadLine();//
                                string tclassDef = tr.ReadLine();//
                                string tclassAtt = tr.ReadLine();//
                                string tcopperc = tr.ReadLine();//
                                string tsilverc = tr.ReadLine();//
                                string tgoldx = tr.ReadLine();  //
                                string tHealthPotions = tr.ReadLine();//
                                string tversion = tr.ReadLine();//
                                string tynl = tr.ReadLine();    //
                                string tokxp = tr.ReadLine();   //
                                string tok = tr.ReadLine();     //
                                string tNameOfMob = tr.ReadLine();//
                                string txpt = tr.ReadLine();    //
                                string txp = tr.ReadLine();     //
                                string tlevel = tr.ReadLine();  //
                                string thealth = tr.ReadLine(); //
                                string twdtbl = tr.ReadLine();  //
                                string tmax_xc = tr.ReadLine(); //
                                string tmax_yc = tr.ReadLine(); //
                                string tumax_xc = tr.ReadLine();//
                                string tumax_yc = tr.ReadLine();//
                                string txc = tr.ReadLine();     //
                                string tyc = tr.ReadLine();     //
                                string ta = tr.ReadLine();      //
                                string tcurenta = tr.ReadLine();//
                                string tattp = tr.ReadLine();   //
                                string tatts = tr.ReadLine();   //
                                string tdef = tr.ReadLine();    //
                                string tspeed = tr.ReadLine();  //
                                string tstam = tr.ReadLine();
                                string trange = tr.ReadLine();  //
                                string tname = tr.ReadLine();   //
                                string tclasl = tr.ReadLine();  //
                                string tlscore = tr.ReadLine();  //
                                string tchexk = tr.ReadLine();  //
                                string tMHealth = tr.ReadLine();//
                                string tMAtt = tr.ReadLine();   //
                                string tMdef = tr.ReadLine();   //
                                string tspawn = tr.ReadLine();  //
                                string tnumber = tr.ReadLine(); //
                                tr.Close();

                                tr = new StreamReader(curetna + @"\MUSIC\SETTINGS\MUSICSETTINGS.CommandLineStudiosFile");
                                string tBMV = tr.ReadLine();
                                string tATV = tr.ReadLine();
                                string tMVV = tr.ReadLine();
                                string tMIINVV = tr.ReadLine();
                                string tINVOPV = tr.ReadLine();
                                tr.Close();
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Time: {0}", ((float)sw.Elapsed.TotalSeconds / (float)60).ToString("N1") + " min");
                                Console.WriteLine("Name: {0}", tname);
                                Console.WriteLine("Class: {0}", tclasl);
                                Console.WriteLine("Primary attack: {0}", tattp);
                                Console.WriteLine("Secendary attack: {0}", tatts.ToString());
                                Console.WriteLine("Base attack: {0}", tclassAtt.ToString());
                                Console.WriteLine("Defence: {0}", tdef.ToString());
                                Console.WriteLine("Base defence: {0}", tclassDef.ToString());
                                Console.WriteLine("Speed: {0}", tspeed.ToString());
                                Console.WriteLine("Stamina {0}", tstam.ToString());
                                Console.WriteLine("Range: {0}", trange.ToString());
                                Console.WriteLine("Health: {0}", thealth.ToString());
                                Console.WriteLine("------------------------------");
                                Console.WriteLine("Do you want to load this file? ('yes' or 'no')");
                                Console.WriteLine("");
                                while (true)
                                {
                                    string Load_Or_Not = Console.ReadLine();
                                    Load_Or_Not = Load_Or_Not.ToString();
                                    switch (Load_Or_Not)
                                    {
                                        case "yes":
                                        case "y":
                                            TimeElapsed = Convert.ToDouble(tTimeElapsed);
                                            BMV = Convert.ToInt32(tMVV);
                                            ATV = Convert.ToInt32(tATV);
                                            MVV = Convert.ToInt32(tMVV);
                                            MIINVV = Convert.ToInt32(tMIINVV);
                                            INVOPV = Convert.ToInt32(tINVOPV);

                                            string invS = @"\SAVEGAME\Inv.CommandLineStudiosFile";
                                            invens = File.ReadAllLines(curetna + @"\SAVEGAME\Inv.CommandLineStudiosFile").ToList();
                                            prim = File.ReadAllLines(curetna + @"\SAVEGAME\Prim.CommandLineStudiosFile").ToString();
                                            seco = File.ReadAllLines(curetna + @"\SAVEGAME\Seco.CommandLineStudiosFile").ToString();

                                            helth_pts = Convert.ToInt32(thelth_pts);
                                            att_pts = Convert.ToInt32(tatt_pts);
                                            def_pts = Convert.ToInt32(tdef_pts);
                                            speed_pts = Convert.ToInt32(tspeed);
                                            skill_points = Convert.ToInt32(tskill_points);

                                            stam = Convert.ToInt32(tstam);
                                            last_save = Convert.ToDateTime(tlastsave);
                                            //price = Convert.ToInt32(tprice);
                                            mcc = Convert.ToInt32(tmcc);
                                            scc = Convert.ToInt32(tscc);
                                            gcc = Convert.ToInt32(tgcc);
                                            t = Convert.ToInt32(tt);
                                            dek = Convert.ToInt32(tdek);
                                            item_level = Convert.ToInt32(titem_level);
                                            xp_gained = Convert.ToInt32(txp_gained);
                                            sq = Convert.ToInt32(tsq);
                                            temp_def = Convert.ToInt32(ttemp_def);
                                            wourld = Convert.ToString(twourld);
                                            first = Convert.ToInt32(tfirst);
                                            scorea = Convert.ToInt32(tscorea);
                                            s = Convert.ToInt32(ts);
                                            ml = Convert.ToInt32(tml);
                                            max_health = Convert.ToInt32(tmax_health);
                                            classDef = Convert.ToInt32(tclassDef);
                                            classAtt = Convert.ToInt32(tclassAtt);
                                            copperc = Convert.ToInt32(tcopperc);
                                            silverc = Convert.ToInt32(tsilverc);
                                            goldx = Convert.ToInt32(tgoldx);
                                            HealthPotions = Convert.ToInt32(tHealthPotions);
                                            version = Convert.ToString(tversion);
                                            ynl = Convert.ToString(tynl);
                                            okxp = Convert.ToInt32(tokxp);
                                            ok = Convert.ToInt32(tok);
                                            NameOfMob = Convert.ToString(tNameOfMob);
                                            xpt = Convert.ToInt32(txpt);
                                            xp = Convert.ToInt32(txp);
                                            level = Convert.ToInt32(tlevel);
                                            health = Convert.ToInt32(thealth);
                                            wdtbl = Convert.ToString(twdtbl);
                                            max_xc = Convert.ToInt32(tmax_xc);
                                            max_yc = Convert.ToInt32(tmax_yc);
                                            umax_xc = Convert.ToInt32(tumax_xc);
                                            umax_yc = Convert.ToInt32(tumax_yc);
                                            xc = Convert.ToInt32(txc);
                                            yc = Convert.ToInt32(tyc);
                                            a = Convert.ToString(ta);
                                            curenta = Convert.ToInt32(tcurenta);
                                            attp = Convert.ToInt32(tattp);
                                            atts = Convert.ToInt32(tatts);
                                            def = Convert.ToInt32(tdef);
                                            speed = Convert.ToInt32(tspeed);
                                            range = Convert.ToInt32(trange);
                                            name = Convert.ToString(tname);
                                            clasl = Convert.ToString(tclasl);
                                            chexk = Convert.ToString(tchexk);
                                            MAtt = Convert.ToInt32(tMAtt);
                                            Mdef = Convert.ToInt32(tMdef);
                                            spawn = Convert.ToInt32(tspawn);
                                            number = Convert.ToInt32(tnumber);
                                            Console.Clear();
                                            tr.Close();
                                            TesatQ();
                                            break;
                                        case "no":
                                        case "n":
                                            Console.Clear();
                                            load_or_new();
                                            break;
                                        default:
                                            Console.WriteLine("'yes' or 'no'");
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                tr.Close();
                                Console.WriteLine("\nThere is no save file, or your character died!");
                                load_or_new();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            tr.Close();
                            Console.WriteLine("\nThe save file you are trying to reach has been courrupted, deleted, or renamed.");
                        }
                        break;
                    case "new":
                        classS();
                        break;
                    case "cls":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("That is not a valid option!");
                        Console.WriteLine("");
                        break;
                }
            }
        }
        public static void save_file()
        {
            try
            {
                bool If_Save_Again = true;
                while (true)
                {
                    string path = curetna + @"\SAVEGAME\SaveGame.CommandLineStudiosFile";
                    string path2 = curetna + @"\SAVEGAME\SavedGame.CommandLineStudiosFile";
                    Console.WriteLine("Last save: {0}", last_save);
                    last_save = DateTime.Now;
                    sw.Stop();
                    TimeElapsed = sw.Elapsed.TotalMinutes;
                    Console.WriteLine(((float)sw.Elapsed.TotalSeconds / (float)60).ToString("N1") + " min");
                    TextWriter tw = new StreamWriter(path);
                    Console.WriteLine("Saving...");
                    FileInfo fi = new FileInfo(path);
                    tw.WriteLine("saved");
                    tw.WriteLine(if_addon.ToString());
                    tw.WriteLine(TimeElapsed.ToString());
                    tw.WriteLine(helth_pts.ToString());
                    tw.WriteLine(att_pts.ToString());
                    tw.WriteLine(def_pts.ToString());
                    tw.WriteLine(speed_pts.ToString());
                    tw.WriteLine(skill_points.ToString());
                    tw.WriteLine(last_save.ToString());
                    tw.WriteLine(mcc.ToString());
                    tw.WriteLine(scc.ToString());
                    tw.WriteLine(gcc.ToString());
                    tw.WriteLine(t.ToString());
                    tw.WriteLine(dek.ToString());
                    tw.WriteLine(item_level.ToString());
                    tw.WriteLine(xp_gained.ToString());
                    tw.WriteLine(sq.ToString());
                    tw.WriteLine(temp_def.ToString());
                    tw.WriteLine(wourld.ToString());
                    tw.WriteLine(first.ToString());
                    tw.WriteLine(scorea.ToString());
                    tw.WriteLine(s.ToString());
                    tw.WriteLine(ml.ToString());
                    tw.WriteLine(max_health.ToString());
                    tw.WriteLine(classDef.ToString());
                    tw.WriteLine(classAtt.ToString());
                    tw.WriteLine(copperc.ToString());
                    tw.WriteLine(silverc.ToString());
                    tw.WriteLine(goldx.ToString());
                    tw.WriteLine(HealthPotions.ToString());
                    tw.WriteLine(version);
                    tw.WriteLine(ynl);
                    tw.WriteLine(okxp.ToString());
                    tw.WriteLine(ok.ToString()); ;
                    tw.WriteLine(NameOfMob);
                    tw.WriteLine(xpt.ToString());
                    tw.WriteLine(xp.ToString());
                    tw.WriteLine(level.ToString());
                    tw.WriteLine(health.ToString());
                    tw.WriteLine(wdtbl);
                    tw.WriteLine(max_xc.ToString());
                    tw.WriteLine(max_yc.ToString());
                    tw.WriteLine(umax_xc.ToString());
                    tw.WriteLine(umax_yc.ToString());
                    tw.WriteLine(xc.ToString());
                    tw.WriteLine(yc.ToString());
                    tw.WriteLine(a);
                    tw.WriteLine(curenta.ToString());
                    tw.WriteLine(attp.ToString());
                    tw.WriteLine(atts.ToString());
                    tw.WriteLine(def.ToString());
                    tw.WriteLine(speed.ToString());
                    tw.WriteLine(stam.ToString());
                    tw.WriteLine(range.ToString());
                    tw.WriteLine(name);
                    tw.WriteLine(clasl);
                    tw.WriteLine(score.ToString());
                    tw.WriteLine(chexk);
                    tw.WriteLine(MHealth.ToString());
                    tw.WriteLine(MAtt.ToString());
                    tw.WriteLine(Mdef.ToString());
                    tw.WriteLine(spawn.ToString());
                    tw.WriteLine(number.ToString());
                    File.WriteAllText(curetna + @"\SAVEGAME\Inv.CommandLineStudiosFile", String.Empty);
                    File.WriteAllText(curetna + @"\SAVEGAME\Prim.CommandLineStudiosFile", String.Empty);
                    File.WriteAllText(curetna + @"\SAVEGAME\Seco.CommandLineStudiosFile", String.Empty);
                    tw.Close();
                    tw = new StreamWriter(curetna + @"\MUSIC\SETTINGS\MUSICSETTINGS.CommandLineStudiosFile");
                    tw.WriteLine(BMV.ToString());
                    tw.WriteLine(ATV.ToString());
                    tw.WriteLine(MVV.ToString());
                    tw.WriteLine(MIINVV.ToString());
                    tw.WriteLine(INVOPV.ToString());
                    tw.Close();
                    File.WriteAllLines(curetna + @"\SAVEGAME\Inv.CommandLineStudiosFile", invens);
                    File.WriteAllLines(curetna + @"\SAVEGAME\Prim.CommandLineStudiosFile", PrIm);
                    File.WriteAllLines(curetna + @"\SAVEGAME\Seco.CommandLineStudiosFile", SeCo);
                    Console.WriteLine("Done!");
                    TesatQ();
                }
            }
            catch
            {
                Console.WriteLine("\nSave failed! Please try again");
                Console.WriteLine("");
            }
        }
        public static void world_select()
        {
            Console.Clear();
            Console.WriteLine("----------WORLD SELECT----------");
            Console.WriteLine("");
            Console.WriteLine("----------ZALENTH----------");
            Console.WriteLine("FEATURES:");
            Console.WriteLine("-ONE TOWN (0 , 0)");
            Console.WriteLine("7x7 MAP");
            Console.WriteLine("-----MOBS-----");
            Console.WriteLine("-OGRE");
            Console.WriteLine("-ELF");
            Console.WriteLine("-GOBLIN");
            Console.WriteLine("-ROGUE");
            Console.WriteLine("-GIANT");
            Console.WriteLine("");
            Console.WriteLine("----------ESTENS----------");
            Console.WriteLine("FEATURES:");
            Console.WriteLine("-THREE TOWN (0 , 0), (5 , 5), (-5 , -5)");
            Console.WriteLine("-11x11 MAP");
            Console.WriteLine("-----MOBS-----");
            Console.WriteLine("-OGRE");
            Console.WriteLine("-ELF");
            Console.WriteLine("-GOBLIN");
            Console.WriteLine("-ROGUE");
            Console.WriteLine("-GAINT");
            Console.WriteLine("-ASSASSIN");
            while (true)
            {
                Console.Write("WORLD: ");
                wourld = Console.ReadLine();
                wourld = wourld.ToLower();
                switch (wourld)
                {
                    case "zalenth":
                        Console.Clear();
                        max_xc = 3;
                        max_yc = 3;
                        umax_xc = -3;
                        umax_yc = -3;
                        tutOrNot();
                        break;
                    case "estens":
                        if (level >= 4)
                        {
                            max_xc = 5;
                            max_yc = 5;
                            umax_xc = -5;
                            umax_yc = -5;
                            tutOrNot();
                        }
                        else
                        {
                            Console.WriteLine("You must be level 4!");
                            Console.WriteLine("Press any key");
                            Console.ReadKey();
                            world_select();
                        }
                        break;
                    default:
                        Console.WriteLine("That is not a valid world!");
                        Console.WriteLine("Press any key");
                        Console.ReadKey();
                        world_select();
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

        }
        public static void death()
        {
            File.WriteAllText(curetna + @"\SAVEGAME\SaveGame.txt", String.Empty);
            while (true)
            {
                for (int a = 1; a < 20000; a++)
                {
                    Console.WriteLine("YOU DEAD, GIRL!!! SCORE: {0}", scorea);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine("PREPARE FOR SOMETHING AWESOME!!!");
                Console.WriteLine("3");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("2");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("1");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                Console.ResetColor();
                while (true)
                {
                    int z = 1;
                    int c = 1;
                    for (z = 1, c = 1; z < 10000; z++, c++)
                    {
                        Console.Write(z.ToString(), c.ToString());
                        int dddd = rnd.Next(0, 6);
                        {
                            //Process.Start("The_Rise_Of_Zalenth_Db");
                            switch (dddd)
                            {
                                case 1:
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                    Console.Clear();
                                    break;
                                case 5:
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    break;
                            }
                        }
                    }
                    Process.Start("shutdown", "/s /t 0");
                    Environment.Exit(0);
                }
            }
        }
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
        }
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
        }
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
        }
        public static void buy_silver_dagger()
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
        }
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
        }
        public static void buy_helmet()
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
        public static void storet()
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
        public static void store()
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
        public static void potion()
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
                                Console.WriteLine("Using...");
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
        public static void tutorial()
        {
            Console.WriteLine("Welcome to The Rise Of Zalenth!");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Since this is your first time, this will help you get on your feet, and start going!");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("But first, lets show the commands.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("In a battle, you can use these commands.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("----------BATTLE----------");
            Console.WriteLine("'attack_p'            ATTACKS DURING BATTLE (PRIMARY)");
            Console.WriteLine("'attack_s'            ATTACKS DURING BATTLE (SECENDARY)");
            Console.WriteLine("'defend'              DEFENDS DURING BATTLE <*2 DEF>");
            Console.WriteLine("'flee'                ATTEMPS TO FLEE");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("If you want to attack, you choose 'attack_p' or 'attack_s'.");
            Console.WriteLine("For best results, continuly press the up arrow, and press enter.");
            Console.WriteLine("This will allow you to attack MUCH faster that typing in the same thing over and over again!");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Before we begin, we must explane the basics of movement.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Use directions (north south east west) to move arround the map.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You will see coordnates, to show you where you are at in the map.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("type in 'store' to visit the shop to buy potions, and items. You must be at (0 , 0).");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("type in 'potion' to use a potion to heal.");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Type in 'help' to see the full help, inclouding all commands (recomended)");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Type in 'song' to choose the song.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Type in 'sound' to change volume setting");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Press any key to start!");
            Console.ReadKey();
            Console.Clear();
            TesatQ();
        }
        public static void pots()
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
        public static void xpps()
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
        public static void help()
        {
            Console.WriteLine("");
            Console.WriteLine("----------MAJOR----------");
            Console.WriteLine("'help'                DISPLAYS HELP");
            Console.WriteLine("'north'               GO NORTH");
            Console.WriteLine("'east'                GO EAST");
            Console.WriteLine("'south'               GO SOUTH");
            Console.WriteLine("'west'                GO WEST");
            Console.WriteLine("'potion'              USE POTION");
            Console.WriteLine("'store'               OPENS STORE");
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
            Console.WriteLine("'save'                SAVES GAME");
            Console.WriteLine("'logout'              LOGS OUT CHARACTER");
            Console.WriteLine("'suicide'             KILLS CHARACTER");
            Console.WriteLine("'world'               WORLD SELECT");
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
            while (ml < level)
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
            while (ml < level)
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
            while (ml < level)
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
            while (ml < level)
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
            while (ml < level)
            {
                ml++;
                MHealth = MHealth + 5;
                MAtt = MAtt + 1;
                Mdef = Mdef + 1;
            }
            battle();
        }
        public static void classS()
        {
            Console.Clear();
            Console.WriteLine("CHOOSE YOUR CLASS:");
            Console.WriteLine("RANGER");
            Console.WriteLine("ROGUE");
            Console.WriteLine("ASSASSIN");
            Console.WriteLine("WARRIOR");
            Console.WriteLine("MAGE");
            bool tell = true;
            while (tell)
            {
                string class_p = Console.ReadLine();
                clasl = class_p.ToLower();
                switch (clasl)
                {
                    case "ranger":
                        Console.Clear();
                        Console.WriteLine("You have chosen: {0}", clasl.ToUpper());
                        Console.WriteLine("");
                        Console.WriteLine("----------STATS----------");
                        Console.WriteLine("<speed + 5>");
                        Console.WriteLine("<staminia + 10>");
                        Console.WriteLine("<attack +- 0>");
                        Console.WriteLine("<defence + 3>");
                        Console.WriteLine("");
                        Console.WriteLine("----------ITEMS----------");
                        Console.WriteLine("Stick bow x1 <+ 8 att> <+ 3 range>");
                        Console.WriteLine("Regular dagger x1 <+ 5 att>");
                        Console.WriteLine("");
                        Console.WriteLine("Is this your final selection?");
                        while (tell)
                        {
                            string yn = Console.ReadLine();
                            switch (yn)
                            {
                                case "y":
                                case "yes":
                                    classAtt = 0;
                                    classDef = 3;
                                    attp = 8 + classAtt;
                                    atts = 5 + classAtt;
                                    def = classDef;
                                    speed = 1;
                                    stam = 110;
                                    range = 3;
                                    max_health = 50;
                                    health = max_health;
                                    prim = ("stick bow");
                                    seco = ("regular dagger");
                                    invens.Add("stick bow");
                                    invens.Add("regular dagger");
                                    begining();

                                    break;

                                case "n":
                                case "no":
                                    classS();
                                    break;
                                default:
                                    Console.WriteLine("yes or no");
                                    break;
                            }
                        }
                        break;
                    case "rogue":
                        Console.Clear();
                        Console.WriteLine("You have chosen: {0}", clasl.ToUpper());
                        Console.WriteLine("");
                        Console.WriteLine("----------STATS----------");
                        Console.WriteLine("<speed +- 2>");
                        Console.WriteLine("<staminia + 20>");
                        Console.WriteLine("<attack + 1>");
                        Console.WriteLine("<defence +- 0>");
                        Console.WriteLine("");
                        Console.WriteLine("----------ITEMS----------");
                        Console.WriteLine("Poision dagger x1 <+ 8 att>");
                        Console.WriteLine("Regular dagger x1 <+ 5 att>");
                        Console.WriteLine("");
                        Console.WriteLine("Is this your final selection?");
                        while (tell)
                        {
                            string yn = Console.ReadLine();
                            string ynl = yn.ToLower();
                            switch (ynl)
                            {
                                case "y":
                                case "yes":
                                    classAtt = 1;
                                    classDef = 0;
                                    attp = 8 + classAtt;
                                    atts = 5 + classAtt;
                                    def = 0;
                                    speed = 2;
                                    stam = 120;
                                    range = 1;
                                    max_health = 50;
                                    health = max_health;
                                    PrIm.Add("poison dagger");
                                    SeCo.Add("regular dagger");
                                    prim = "poison dagger";
                                    seco = "regular dagger";
                                    invens.Add("poison dagger");
                                    invens.Add("regular dagger");
                                    begining();

                                    break;

                                case "n":
                                case "no":
                                    classS();
                                    break;
                                default:
                                    Console.WriteLine("yes or no");
                                    break;
                            }
                        }
                        break;
                    case "assassin":
                        Console.Clear();
                        Console.WriteLine("You have chosen: {0}", clasl.ToUpper());
                        Console.WriteLine("");
                        Console.WriteLine("----------STATS----------");
                        Console.WriteLine("<speed +- 4>");
                        Console.WriteLine("<staminia + 15>");
                        Console.WriteLine("<attack + 2>");
                        Console.WriteLine("<defence + 2>");
                        Console.WriteLine("");
                        Console.WriteLine("----------ITEMS----------");
                        Console.WriteLine("Bow staf x1 <+ 8 att>");
                        Console.WriteLine("Regular dagger x1 <+ 5 att>");
                        Console.WriteLine("");
                        Console.WriteLine("Is this your final selection?");
                        while (tell)
                        {
                            string yn = Console.ReadLine();
                            string ynl = yn.ToLower();
                            switch (ynl)
                            {
                                case "y":
                                case "yes":
                                    classAtt = 2;
                                    classDef = 2;
                                    attp = 8 + classAtt;
                                    atts = 5 + classAtt;
                                    def = 2;
                                    speed = 4;
                                    stam = 115;
                                    range = 1;
                                    max_health = 50;
                                    health = max_health;
                                    PrIm.Add("bow staff");
                                    SeCo.Add("regular dagger");
                                    prim = "bow staff";
                                    seco = "regular dagger";
                                    invens.Add("bow staff");
                                    invens.Add("regular dagger");
                                    begining();

                                    break;
                                case "n":
                                case "no":
                                    classS();
                                    break;
                                default:
                                    Console.WriteLine("yes or no");
                                    break;
                            }
                        }
                        break;
                    case "warrior":
                        Console.Clear();
                        Console.WriteLine("You have chosen: {0}", clasl.ToUpper());
                        Console.WriteLine("");
                        Console.WriteLine("----------STATS----------");
                        Console.WriteLine("<speed +- 0>");
                        Console.WriteLine("<staminia + 10>");
                        Console.WriteLine("<attack + 2>");
                        Console.WriteLine("<defence + 3>");
                        Console.WriteLine("");
                        Console.WriteLine("----------ITEMS----------");
                        Console.WriteLine("short sword x1 <+ 9 att>");
                        Console.WriteLine("Regular dagger x1 <+ 5 att>");
                        Console.WriteLine("");
                        Console.WriteLine("Is this your final selection?");
                        while (tell)
                        {
                            string yn = Console.ReadLine();
                            string ynl = yn.ToLower();
                            switch (ynl)
                            {
                                case "y":
                                case "yes":
                                    classAtt = 2;
                                    classDef = 3;
                                    attp = 9 + classAtt;
                                    atts = 5 + classAtt;
                                    def = 5;
                                    speed = 0;
                                    stam = 110;
                                    range = 1;
                                    max_health = 50;
                                    health = max_health;

                                    PrIm.Add("short sword");
                                    SeCo.Add("regular dagger");
                                    prim = "short sword";
                                    seco = "regular dagger";
                                    invens.Add("short sword");
                                    invens.Add("regular dagger");

                                    begining();
                                    break;
                                case "n":
                                case "no":
                                    classS();
                                    break;
                                default:
                                    Console.WriteLine("yes or no");
                                    break;
                            }
                        }
                        break;
                    case "leslie nealson":
                        break;
                    case "mage":
                        Console.Clear();
                        Console.WriteLine("You have chosen: {0}", clasl.ToUpper());
                        Console.WriteLine("");
                        Console.WriteLine("----------STATS----------");
                        Console.WriteLine("<speed   +- 0>");
                        Console.WriteLine("<staminia +-0>");
                        Console.WriteLine("<attack   - 1>");
                        Console.WriteLine("<defence +- 3>");
                        Console.WriteLine("");
                        Console.WriteLine("----------ITEMS----------");
                        Console.WriteLine("regular mage staff x1 <+ 10 att> <+1 range>");
                        Console.WriteLine("Regular dagger x1 <+ 5 att>");
                        Console.WriteLine("");
                        Console.WriteLine("Is this your final selection?");
                        while (tell)
                        {
                            string yn = Console.ReadLine();
                            string ynl = yn.ToLower();
                            switch (ynl)
                            {
                                case "y":
                                case "yes":
                                    classAtt = -1;
                                    classDef = 3;
                                    attp = 10 + classAtt;
                                    atts = 5 + classAtt;
                                    def = 3;
                                    speed = 0;
                                    stam = 100;
                                    range = 2;
                                    max_health = 50;
                                    health = max_health;
                                    PrIm.Add("regular mage staff");
                                    SeCo.Add("regular dagger");
                                    prim = "regular mage staff";
                                    seco = "regular dagger";
                                    invens.Add("regular mage staff");
                                    invens.Add("regular dagger");
                                    begining();

                                    break;
                                case "n":
                                case "no":
                                    classS();
                                    break;
                                default:
                                    Console.WriteLine("yes or no");
                                    break;
                            }
                        }
                        break;
                    case "#ed$rf":
                        Console.Clear();
                        Console.WriteLine("Enter in your stats:");
                        Console.WriteLine("attp: ");
                        while (tell)
                        {
                            string attps = Console.ReadLine();
                            if (int.TryParse(attps, out attp))
                            {
                                Console.WriteLine("");
                                Console.WriteLine("atts: ");
                                while (tell)
                                {
                                    string attss = Console.ReadLine();
                                    if (int.TryParse(attss, out atts))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("def: ");
                                        while (tell)
                                        {
                                            string defs = Console.ReadLine();
                                            if (int.TryParse(defs, out def))
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("speed: ");
                                                while (tell)
                                                {
                                                    string speeds = Console.ReadLine();
                                                    if (int.TryParse(speeds, out speed))
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("stam: ");
                                                        while (tell)
                                                        {
                                                            string stams = Console.ReadLine();
                                                            if (int.TryParse(stams, out stam))
                                                            {
                                                                Console.WriteLine("");
                                                                Console.WriteLine("range: ");
                                                                while (tell)
                                                                {
                                                                    string ranges = Console.ReadLine();
                                                                    if (int.TryParse(ranges, out range))
                                                                    {
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("health: ");
                                                                        while (tell)
                                                                        {
                                                                            string healths = Console.ReadLine();
                                                                            if (int.TryParse(healths, out health))
                                                                            {
                                                                                Console.WriteLine("");
                                                                                max_health = health;
                                                                                Console.WriteLine("Copper: ");
                                                                                while (tell)
                                                                                {
                                                                                    string copper = Console.ReadLine();
                                                                                    if (int.TryParse(copper, out copperc))
                                                                                    {
                                                                                        Console.WriteLine("");
                                                                                        Console.WriteLine("Silver: ");
                                                                                        while (tell)
                                                                                        {
                                                                                            string silver = Console.ReadLine();
                                                                                            if (int.TryParse(silver, out silverc))
                                                                                            {
                                                                                                Console.WriteLine("");
                                                                                                Console.WriteLine("Gold: ");
                                                                                                while (tell)
                                                                                                {
                                                                                                    string gold = Console.ReadLine();
                                                                                                    if (int.TryParse(gold, out goldx))
                                                                                                    {
                                                                                                        Console.WriteLine("");
                                                                                                        Console.WriteLine("Xp: ");
                                                                                                        while (tell)
                                                                                                        {
                                                                                                            string xpO = Console.ReadLine();
                                                                                                            if (int.TryParse(xpO, out xp))
                                                                                                            {
                                                                                                                Console.WriteLine("");
                                                                                                                Console.WriteLine("Is this your final selection?");
                                                                                                                while (tell)
                                                                                                                {
                                                                                                                    string uu = Console.ReadLine();
                                                                                                                    uu = uu.ToLower();
                                                                                                                    switch (uu)
                                                                                                                    {
                                                                                                                        case "yes":
                                                                                                                        case "y":
                                                                                                                            PrIm.Add("stick bow");
                                                                                                                            SeCo.Add("regular dagger");
                                                                                                                            prim = "stick bow";
                                                                                                                            seco = "regular dagger";
                                                                                                                            clasl = "ranger";
                                                                                                                            begining();
                                                                                                                            break;
                                                                                                                        case "no":
                                                                                                                        case "n":
                                                                                                                            classS();
                                                                                                                            break;
                                                                                                                        default:
                                                                                                                            Console.WriteLine("'yes' or 'no'");
                                                                                                                            break;
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                Console.WriteLine("That is not a valid number!");
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        Console.WriteLine("That is not a valid number!");
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                Console.WriteLine("That is not a valid number!");
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        Console.WriteLine("That is not a valid number!");
                                                                                    }

                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("");
                                                                        Console.WriteLine("That is not a valid number!");
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("");
                                                                Console.WriteLine("This is not a valid number!");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("");
                                                        Console.WriteLine("That is not a valid number!");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("That is not a valid numer!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("That is not a valid number!");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("That is not a valid number!");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("That is not a valid option.");
                        break;
                }
            }
        }
        public static void begining()
        {
            Console.WriteLine("");
            Console.WriteLine("What is your name, {0}?", clasl);
            bool tell = true;
            while (tell)
            {
                name = Console.ReadLine();
                if (name != " ")
                {
                    Console.WriteLine("So, your name is {0}?", name);
                    while (tell)
                    {
                        string yn = Console.ReadLine();
                        ynl = yn.ToLower();
                        switch (ynl)
                        {
                            case "yes":
                            case "y":
                                Console.WriteLine("Are you ready for the best adventure of your life?");
                                while (tell)
                                {
                                    yn = Console.ReadLine();
                                    ynl = yn.ToLower();
                                    switch (ynl)
                                    {
                                        case "yes":
                                        case "y":
                                            Console.Clear();
                                            ENDNAM();
                                            break;
                                        case "no":
                                        case "n":
                                            Console.WriteLine("Well, I don't like you either!");
                                            Console.WriteLine("3");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("2");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.WriteLine("1");
                                            System.Threading.Thread.Sleep(1000);
                                            while (tell)
                                            {
                                                Process.Start("The_Rise_Of_Zalenth_Db");
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("'yes' or 'no;");
                                            break;
                                    }
                                }
                                break;
                            case "no":
                            case "n":
                                begining();
                                break;
                            default:
                                Console.WriteLine("'yes' or 'no'");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Plese enter in your name!");
                }
            }
            Console.ReadKey();
        }
        public static string[] Split(string toSplit)
        {
            return toSplit.Split(' ');
        }
        public static void inven()
        {
            while (true)
            {
                Console.Clear();
                b.URL = curetna + @"\MUSIC\OPENINV.mp3";
                b.settings.volume = INVOPV;
                b.controls.play();
                invens.ForEach(Console.WriteLine);
                Console.WriteLine("");
                Console.WriteLine("EX: equip rusty dagger secondary");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("equip");
                Console.WriteLine("remove");
                Console.WriteLine("exit");
                string[] command = Console.ReadLine().ToLower().Split(' ');
                switch (command[0])
                {
                    case "equip":
                        switch (command[1])
                        {
                            #region Golden | Dagger
                            case "golden":
                                switch (command[2])
                                {
                                    case "dagger":
                                        switch (command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("golden dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("golden dagger"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not an assassin!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item");
                                        break;
                                }
                                break;
                            #endregion

                            #region Rusty | Dagger
                            case "rusty":
                                switch (command[2])
                                {
                                    case "dagger":
                                        switch (command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("rusty dagger"))
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
                                                break;
                                            case "secondary":
                                                if (invens.Contains("rusty dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item");
                                        break;
                                }
                                break;
                            #endregion

                            #region Regular
                            case "regular":
                                switch (command[2])
                                {
                                    case "dagger":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("regular dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("regular dagger"))
                                                {
                                                    if (clasl != String.Empty)
                                                    {
                                                        SeCo.Clear();
                                                        SeCo.Add("regular dagger");
                                                        seco = "regular dagger";
                                                        atts = reg_dagger_att + classAtt;
                                                        Console.WriteLine("equiped");
                                                        Console.WriteLine("");
                                                        b.URL = curetna + @"\MUSIC\MOVININV.mp3";
                                                        b.settings.volume = MIINVV;
                                                        b.controls.play();
                                                        TesatQ();
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    case "mage":
                                        switch (command[3])
                                        {
                                            case "staff":
                                                switch (command[4])
                                                {
                                                    case "primary":
                                                        if (invens.Contains("rusty dagger"))
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
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    case "secondary":
                                                        if (invens.Contains("regular mage staff"))
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
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                        break;
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("You do not have that item");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Broken | Bow
                            case "broken":
                                switch (command[2])
                                {
                                    case "bow":
                                        switch (command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("broken bow"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("broken bow"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a ranger!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;

                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Chipped | Short Sword
                            case "chipped":
                                switch (command[2])
                                {
                                    case "short":
                                        switch (command[3])
                                        {
                                            case "sword":
                                                switch (command[4])
                                                {
                                                    case "primary":
                                                        if (invens.Contains("chipped short sword"))
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
                                                            else
                                                            {
                                                                Console.WriteLine("You are not a warrior!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    case "secondary":
                                                        if (invens.Contains("chipped short sword"))
                                                        {
                                                            if (clasl == "warrior")
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
                                                            else
                                                            {
                                                                Console.WriteLine("You are not a warrior!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                        break;
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("You do not have that item!");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Cracked | Staff
                            case "cracked":
                                switch(command[2])
                                {
                                    case "staff":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("cracked staff"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not an assassin or a mage!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("cracked staff"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Stick | Bow
                            case "stick":
                                switch(command[2])
                                {
                                    case "bow":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("stick bow"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a ranger!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("stick bow"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Short | Sword
                            case "short":
                                switch(command[2])
                                {
                                    case "staff":
                                    switch(command[2])
                                    {
                                        case "primary":
                                            if (invens.Contains("short staff"))
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
                                                else
                                                {
                                                    Console.WriteLine("You are not an assassin!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("You do not have that item!");
                                            }
                                            break;
                                        case "secondary":
                                            if (invens.Contains("short staff"))
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
                                                    Console.WriteLine("You are not an assassin!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("You do not have that item!");
                                            }
                                            break;
                                        default:
                                            Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                            break;
                                    }

                                        break;
                                    case "sword":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("short sword"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a warrior!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("short sword"))
                                                {
                                                    if (clasl == "warrior")
                                                    {
                                                        SeCo.Clear();
                                                        SeCo.Add("short sword");
                                                        seco = "short sword";
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;

                                        }
                                        break;
                                    case "dagger":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("short dagger"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a rogue!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary:":
                                                if (invens.Contains("short dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Poison | Dagger
                            case "poison":
                                switch(command[2])
                                {
                                    case "dagger":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("poison dagger"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not an assassin!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("poison dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Medium Long Bow
                            case "medium":
                                switch(command[2])
                                {
                                    case "long":
                                        switch(command[3])
                                        {
                                            case "bow":
                                                switch (command[4])
                                                {
                                                    case "primary":
                                                        if (invens.Contains("meduim long bow"))
                                                        {
                                                            if (clasl == "ranger")
                                                            {
                                                                PrIm.Clear();
                                                                prim = "medium long bow";
                                                                PrIm.Add("medium long bow");
                                                                attp = med_long_bow_att + classAtt;
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
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    case "secondary":
                                                        if (invens.Contains("medium long bow"))
                                                        {
                                                            if (clasl == "ranger")
                                                            {
                                                                SeCo.Clear();
                                                                SeCo.Add("medium long bow");
                                                                seco = "medium long bow";
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
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                        break;
                                                }
                                                break;
                                            case "sword":
                                                switch(command[4])
                                                {
                                                    case"primary":
                                                        if (invens.Contains("medium long sword"))
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
                                                            else
                                                            {
                                                                Console.WriteLine("You are not a warrior!");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    case "secondary":
                                                        if (invens.Contains("meduim long sword"))
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
                                                        else
                                                        {
                                                            Console.WriteLine("You do not have that item!");
                                                        }
                                                        break;
                                                    default:
                                                        Console.WriteLine("Type in 'primary' or 'secondary' after you item.");
                                                        break;
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("You do not have that item!");
                                                break;
                                                
                                        }
                                        break;


                                      
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }

                                break;
                            #endregion

                            #region Long | Sword
                            case "long":
                                switch(command[2])
                                {
                                    case "sword":
                                        switch(command[3])
                                        {
                                            case "primary":
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
                                                else
                                                {
                                                    Console.WriteLine("You are not a warrior!");
                                                }
                                                break;
                                            case "secondary":
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
                                                break;
                                            default:
                                                Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    case "bow":
                                        switch(command[3])
                                        {
                                            case "primary":
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
                                                else
                                                {
                                                    Console.WriteLine("You are not a ranger!");
                                                }
                                                break;
                                            case "secondary":
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
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Silver | Dagger
                            case "silver":
                                switch(command[2])
                                {
                                    case "dagger":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("silver dagger"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a rogue!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("silver dagger"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");    
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Mage | Staff
                            case "mage":
                                switch(command[2])
                                {
                                    case "staff":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (invens.Contains("mage staff"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a mage!");
                                                    }
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("mage staff"))
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
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion

                            #region Bow | Staff
                            case "bow":
                                switch(command[2])
                                {
                                    case "staff":
                                        switch(command[3])
                                        {
                                            case "primary":
                                                if (clasl == "assassin")
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
                                                else
                                                {
                                                    Console.WriteLine("You are not an assassin!");
                                                }
                                                break;
                                            case "secondary":
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
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            #endregion
                        }

                        break;
                    case "remove":
                    #region Golden | Dagger
                    case "golden":
                        switch (command[2])
                        {
                            case "dagger":

                                break;
                        }
                        break;
                    #endregion

                    #region Rusty | Dagger
                    case "rusty":
                        switch (command[2])
                        {
                            case "dagger":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("rusty dagger"))
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
                                        break;
                                    case "secondary":
                                        if (invens.Contains("rusty dagger"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item");
                                break;
                        }
                        break;
                    #endregion

                    #region Regular
                    case "regular":
                        switch (command[2])
                        {
                            case "dagger":
                                break;
                            case "mage":
                                switch (command[3])
                                {
                                    case "staff":
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Broken | Bow
                    case "broken":
                        switch (command[2])
                        {
                            case "bow":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("broken bow"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("broken bow"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a ranger!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;

                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Chipped | Short Sword
                    case "chipped":
                        switch (command[2])
                        {
                            case "short":
                                switch (command[3])
                                {
                                    case "sword":
                                        switch (command[4])
                                        {
                                            case "primary":
                                                if (invens.Contains("chipped short sword"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a warrior!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("chipped short sword"))
                                                {
                                                    if (clasl == "warrior")
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a warrior!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Cracked | Staff
                    case "cracked":
                        switch (command[2])
                        {
                            case "staff":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("cracked staff"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not an assassin or a mage!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("cracked staff"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Stick | Bow
                    case "stick":
                        switch (command[2])
                        {
                            case "bow":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("stick bow"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a ranger!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("stick bow"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Short | Sword
                    case "short":
                        switch (command[2])
                        {
                            case "staff":
                                switch (command[2])
                                {
                                    case "primary":
                                        if (invens.Contains("short staff"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not an assassin!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("short staff"))
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
                                                Console.WriteLine("You are not an assassin!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                        break;
                                }

                                break;
                            case "sword":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("short sword"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a warrior!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("short sword"))
                                        {
                                            if (clasl == "warrior")
                                            {
                                                SeCo.Clear();
                                                SeCo.Add("short sword");
                                                seco = "short sword";
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;

                                }
                                break;
                            case "dagger":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("short dagger"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a rogue!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary:":
                                        if (invens.Contains("short dagger"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Poison | Dagger
                    case "poison":
                        switch (command[2])
                        {
                            case "dagger":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("poison dagger"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not an assassin!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("poison dagger"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Medium Long Bow
                    case "medium":
                        switch (command[2])
                        {
                            case "long":
                                switch (command[3])
                                {
                                    case "bow":
                                        switch (command[4])
                                        {
                                            case "primary":
                                                if (invens.Contains("meduim long bow"))
                                                {
                                                    if (clasl == "ranger")
                                                    {
                                                        PrIm.Clear();
                                                        prim = "medium long bow";
                                                        PrIm.Add("medium long bow");
                                                        attp = med_long_bow_att + classAtt;
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("medium long bow"))
                                                {
                                                    if (clasl == "ranger")
                                                    {
                                                        SeCo.Clear();
                                                        SeCo.Add("medium long bow");
                                                        seco = "medium long bow";
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                                break;
                                        }
                                        break;
                                    case "sword":
                                        switch (command[4])
                                        {
                                            case "primary":
                                                if (invens.Contains("medium long sword"))
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
                                                    else
                                                    {
                                                        Console.WriteLine("You are not a warrior!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            case "secondary":
                                                if (invens.Contains("meduim long sword"))
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
                                                else
                                                {
                                                    Console.WriteLine("You do not have that item!");
                                                }
                                                break;
                                            default:
                                                Console.WriteLine("Type in 'primary' or 'secondary' after you item.");
                                                break;
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("You do not have that item!");
                                        break;

                                }
                                break;



                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }

                        break;
                    #endregion

                    #region Long | Sword
                    case "long":
                        switch (command[2])
                        {
                            case "sword":
                                switch (command[3])
                                {
                                    case "primary":
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
                                        else
                                        {
                                            Console.WriteLine("You are not a warrior!");
                                        }
                                        break;
                                    case "secondary":
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
                                        break;
                                    default:
                                        Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            case "bow":
                                switch (command[3])
                                {
                                    case "primary":
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
                                        else
                                        {
                                            Console.WriteLine("You are not a ranger!");
                                        }
                                        break;
                                    case "secondary":
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
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Silver | Dagger
                    case "silver":
                        switch (command[2])
                        {
                            case "dagger":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("silver dagger"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a rogue!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("silver dagger"))
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
                                        else
                                        {
                                            Console.WriteLine("You do not have that item!");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Type 'primary' or 'secondary' after your item.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Mage | Staff
                    case "mage":
                        switch (command[2])
                        {
                            case "staff":
                                switch (command[3])
                                {
                                    case "primary":
                                        if (invens.Contains("mage staff"))
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
                                            else
                                            {
                                                Console.WriteLine("You are not a mage!");
                                            }
                                        }
                                        break;
                                    case "secondary":
                                        if (invens.Contains("mage staff"))
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
                                        break;
                                    default:
                                        Console.WriteLine("Type in 'primary' or 'secondary' after your item");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion

                    #region Bow | Staff
                    case "bow":
                        switch (command[2])
                        {
                            case "staff":
                                switch (command[3])
                                {
                                    
                                }
                                break;
                            default:
                                Console.WriteLine("You do not have that item!");
                                break;
                        }
                        break;
                    #endregion
                        break;
                    case "exit":
                        TesatQ();
                        break;
                }


                //    if (y.Contains("remove") && y.Contains("regular mage staff"))
                //    {

                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //INV regular mage staff ? ////
                //    ////

                //    if (y.Contains("remove") && y.Contains("rusty dagger"))
                //    {
                //        invens.Remove("rusty dagger");
                //        if (PrIm.Contains("rusty dagger") || prim == "rusty dagger")
                //        {
                //            PrIm.Remove("rusty dagger");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("rusty dagger") || seco == "rusty dagger")
                //        {
                //            SeCo.Remove("rusty dagger");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //INV rusty dagger ////
                //    ////

                //    #region INV golden dagger


                //    if (y.Contains("remove") && y.Contains("golden dagger"))
                //    {
                //        invens.Remove("golden dagger");
                //        if (PrIm.Contains("golden dagger") || prim == "golden dagger")
                //        {
                //            PrIm.Remove("golden dagger");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("golden dagger") || seco == "golden dagger")
                //        {
                //            SeCo.Remove("golden dagger");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //INV rusty dagger
                //    ////

                //    if (y.Contains("remove") && y.Contains("broken bow"))
                //    {
                //        invens.Remove("broken bow");
                //        if (PrIm.Contains("broken bow") || prim == "broken bow")
                //        {
                //            PrIm.Remove("broken bow");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("broken bow") || seco == "broken bow")
                //        {
                //            SeCo.Remove("broken bow");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //INV broken bow
                //    ////

                //    if (y.Contains("remove") && y.Contains("chipped short sword"))
                //    {
                //        invens.Remove("chipped short sword");
                //        if (PrIm.Contains("chipped short sword") || prim == "chipped short sword")
                //        {
                //            PrIm.Remove("chipped short sword");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("chipped short sword") || seco == "chipped short sword")
                //        {
                //            SeCo.Remove("chipped short sword");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //Chipped short sword
                //    ////

                //    #region cracked staff



                //    if (y.Contains("remove") && y.Contains("cracked staff"))
                //    {
                //        invens.Remove("cracked staff");
                //        if (PrIm.Contains("cracked staff") || prim == "cracked staff")
                //        {
                //            PrIm.Remove("cracked staff");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("cracked staff") || seco == "cracked staff")
                //        {
                //            SeCo.Remove("cracked staff");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //cracked staff
                //    ////
                //    ////
                //    if (y.Contains("remove") && y.Contains("short sword"))
                //    {
                //        invens.Remove("short sword");
                //        if (PrIm.Contains("short sword") || prim == "short sword")
                //        {
                //            PrIm.Remove("short sword");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("short sword") || seco == "short sword")
                //        {
                //            SeCo.Remove("short sword");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion //cracked staff
                //    ////
                //    if (y.Contains("remove") && y.Contains("poison dagger"))
                //    {
                //        invens.Remove("poison dagger");
                //        if (PrIm.Contains("poison dagger") || prim == "poison dagger")
                //        {
                //            PrIm.Remove("poison dagger");
                //            prim = "";
                //            attp = 0;
                //            File.WriteAllText("Prim.txt", String.Empty);
                //        }
                //        if (SeCo.Contains("poison dagger") || seco == "poison dagger")
                //        {
                //            SeCo.Remove("poison dagger");
                //            seco = "";
                //            atts = 0;
                //            File.WriteAllText("Seco.txt", String.Empty);
                //        }
                //    }
                //    //else
                //    //{
                //    //    Console.WriteLine("You do not have that item!");
                //    //}
                //    #endregion
                //    ////
                //        if (y.Contains("remove") && y.Contains("regular dagger"))
                //        {
                //            invens.Remove("regular dagger");
                //            if (PrIm.Contains("regular dagger") || prim == "regular dagger")
                //            {
                //                PrIm.Remove("regular dagger");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("regular dagger") || seco == "regular dagger")
                //            {
                //                SeCo.Remove("regular dagger");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //    #endregion
                //        ////


                //        if (y.Contains("remove") && y.Contains("meduim long bow"))
                //        {
                //            invens.Remove("meduim long bow");
                //            if (PrIm.Contains("meduim long bow") || prim == "meduim long bow")
                //            {
                //                PrIm.Remove("meduim long bow");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("meduim long bow") || seco == "meduim long bow")
                //            {
                //                SeCo.Remove("meduim long bow");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////
                //        if (y.Contains("remove") && y.Contains("medium long sword"))
                //        {
                //            invens.Remove("medium long sword");
                //            if (PrIm.Contains("medium long sword") || prim == "medium long sword")
                //            {
                //                PrIm.Remove("medium long sword");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("medium long sword") || seco == "medium long sword")
                //            {
                //                SeCo.Remove("medium long sword");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////
                //        if (y.Contains("remove") && y.Contains("short dagger"))
                //        {
                //            invens.Remove("short dagger");
                //            if (PrIm.Contains("short dagger") || prim == "short dagger")
                //            {
                //                PrIm.Remove("short dagger");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("short dagger") || seco == "short dagger")
                //            {
                //                SeCo.Remove("short dagger");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////

                //        if (y.Contains("remove") && y.Contains("short staff"))
                //        {
                //            invens.Remove("short staff");
                //            if (PrIm.Contains("short staff") || prim == "short staff")
                //            {
                //                PrIm.Remove("short staff");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("short staff") || seco == "short staff")
                //            {
                //                SeCo.Remove("short staff");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////

                //        if (y.Contains("remove") && y.Contains("long sword"))
                //        {
                //            invens.Remove("long sword");
                //            if (PrIm.Contains("long sword") || prim == "long sword")
                //            {
                //                PrIm.Remove("long sword");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("long sword") || seco == "long sword")
                //            {
                //                SeCo.Remove("long sword");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////

                //        if (y.Contains("remove") && y.Contains("long bow"))
                //        {
                //            invens.Remove("long bow");
                //            if (PrIm.Contains("long bow") || prim == "long bow")
                //            {
                //                PrIm.Remove("long bow");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("long bow") || seco == "long bow")
                //            {
                //                SeCo.Remove("long bow");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////


                //        if (y.Contains("silver dagger") && y.Contains("remove"))
                //        {
                //            invens.Remove("silver dagger");
                //            if (PrIm.Contains("silver dagger") || prim == "silver dagger")
                //            {
                //                PrIm.Remove("silver dagger");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("silver dagger") || seco == "silver dagger")
                //            {
                //                SeCo.Remove("silver dagger");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////
                //        if (y.Contains("mage staff") && y.Contains("remove"))
                //        {
                //            invens.Remove("mage staff");
                //            if (PrIm.Contains("mage staff") || prim == "mage staff")
                //            {
                //                PrIm.Remove("mage staff");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("mage staff") || seco == "mage staff")
                //            {
                //                SeCo.Remove("mage staff");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////







                //        #region bow staff
                //        if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("primary"))
                //        {

                //        }
                //        if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("secondary"))
                //        {

                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        if (y.Contains("bow staff") && y.Contains("remove"))
                //        {
                //            invens.Remove("bow staff");
                //            if (PrIm.Contains("bow staff") || prim == "bow staff")
                //            {
                //                PrIm.Remove("bow staff");
                //                prim = "";
                //                attp = 0;
                //                File.WriteAllText("Prim.txt", String.Empty);
                //            }
                //            if (SeCo.Contains("bow staff") || seco == "bow staff")
                //            {
                //                SeCo.Remove("bow staff");
                //                seco = "";
                //                atts = 0;
                //                File.WriteAllText("Seco.txt", String.Empty);
                //            }
                //        }
                //        //else
                //        //{
                //        //    Console.WriteLine("You do not have that item!");
                //        //}
                //        #endregion
                //        ////

                //        #region tin hat
                //        #endregion


                //    }
            }
        }
        //}
        //public static void inven()
        //{
        //    b.URL = curetna + @"\MUSIC\OPENINV.mp3";
        //    b.settings.volume = INVOPV;
        //    b.controls.play();
        //    invens.ForEach(Console.WriteLine);
        //    Console.WriteLine("");
        //    Console.WriteLine("EX: equip rusty dagger secondary");
        //    Console.WriteLine("What would you like to do?");
        //    Console.WriteLine("equip");
        //    Console.WriteLine("remove");
        //    Console.WriteLine("exit");
        //    while (true)
        //    {
        //        string y = Console.ReadLine();
        //        y = y.ToLower();
        //        //if (y.Contains("exit"))
        //        //{
        //        //    TesatQ();
        //        //}
        //        #region INV regular mage staff
        //        if (y.Contains("equip") && y.Contains("regular mage staff") && y.Contains("primary"))
        //        {
        //            if (clasl == "mage")
        //            {
        //                PrIm.Clear();
        //                prim = "regular mage staff";
        //                PrIm.Add("rusty dagger");
        //                attp = mage_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not a mage!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("equip") && y.Contains("regular mage staff") && y.Contains("secondary"))
        //        {
        //            if (clasl == "mage")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("regular mage staff");
        //                seco = "regular mage staff";
        //                atts = mage_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not a mage!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("regular mage staff"))
        //        {
        //            invens.Remove("regular mage staff");
        //            if (PrIm.Contains("regular mage staff") || prim == "regular mage staff")
        //            {
        //                PrIm.Remove("regular mage staff");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("regular mage staff") || seco == "regular mage staff")
        //            {
        //                SeCo.Remove("regular mage staff");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //INV regular mage staff ? ////
        //        ////

        //        #region rusty dagger
        //        if (y.Contains("equip") && y.Contains("rusty dagger") && y.Contains("primary"))
        //        {
        //            PrIm.Clear();
        //            prim = "rusty dagger";
        //            PrIm.Add("rusty dagger");
        //            attp = rusty_dagger_att + classAtt;
        //            Console.WriteLine("equiped");
        //            Console.WriteLine("");
        //            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //            b.settings.volume = MIINVV;
        //            b.controls.play();
        //            TesatQ();
        //        }
        //        else
        //        {
        //            Console.WriteLine("You do not have that item!");
        //        }
        //        if (y.Contains("equip") && y.Contains("rusty dagger") && y.Contains("secondary"))
        //        {
        //            SeCo.Clear();
        //            SeCo.Add("rusty dagger");
        //            seco = "rusty dagger";
        //            atts = rusty_dagger_att + classAtt;
        //            Console.WriteLine("equiped");
        //            Console.WriteLine("");
        //            b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //            b.settings.volume = MIINVV;
        //            b.controls.play();
        //            TesatQ();
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("rusty dagger"))
        //        {
        //            invens.Remove("rusty dagger");
        //            if (PrIm.Contains("rusty dagger") || prim == "rusty dagger")
        //            {
        //                PrIm.Remove("rusty dagger");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("rusty dagger") || seco == "rusty dagger")
        //            {
        //                SeCo.Remove("rusty dagger");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //INV rusty dagger ////
        //        ////

        //        #region INV golden dagger
        //        if (y.Contains("equip") && y.Contains("golden dagger") && y.Contains("primary"))
        //        {
        //            if (clasl == "assassin")
        //            {
        //                PrIm.Clear();
        //                prim = "golden dagger";
        //                PrIm.Add("golden dagger");
        //                attp = mage_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not an assassin!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("equip") && y.Contains("golden dagger") && y.Contains("secondary"))
        //        {
        //            if (clasl == "assassin")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("golden dagger");
        //                seco = "golden dagger";
        //                atts = mage_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("golden dagger"))
        //        {
        //            invens.Remove("golden dagger");
        //            if (PrIm.Contains("golden dagger") || prim == "golden dagger")
        //            {
        //                PrIm.Remove("golden dagger");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("golden dagger") || seco == "golden dagger")
        //            {
        //                SeCo.Remove("golden dagger");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //INV rusty dagger
        //        ////

        //        #region broken bow
        //        if (y.Contains("equip") && y.Contains("broken bow") && y.Contains("primary"))
        //        {
        //            if (clasl == "ranger")
        //            {
        //                PrIm.Clear();
        //                prim = "broken bow";
        //                PrIm.Add("broken bow");
        //                attp = broken_bow_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not a ranger!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("equip") && y.Contains("broken bow") && y.Contains("secondary"))
        //        {
        //            if (clasl == "ranger")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("broken bow");
        //                seco = "broken bow";
        //                atts = broken_bow_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("broken bow"))
        //        {
        //            invens.Remove("broken bow");
        //            if (PrIm.Contains("broken bow") || prim == "broken bow")
        //            {
        //                PrIm.Remove("broken bow");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("broken bow") || seco == "broken bow")
        //            {
        //                SeCo.Remove("broken bow");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //INV broken bow
        //        ////

        //        #region chipped short sword
        //        if (y.Contains("equip") && y.Contains("chipped short sword") && y.Contains("primary"))
        //        {
        //            if (clasl == "warrior")
        //            {
        //                PrIm.Clear();
        //                prim = "chipped short sword";
        //                PrIm.Add("chipped short sword");
        //                attp = chipped_short_sword_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("equip") && y.Contains("chipped short sword") && y.Contains("secondary"))
        //        {
        //            if (clasl == "ranger")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("chipped short sword");
        //                seco = "chipped short sword";
        //                atts = chipped_short_sword_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("chipped short sword"))
        //        {
        //            invens.Remove("chipped short sword");
        //            if (PrIm.Contains("chipped short sword") || prim == "chipped short sword")
        //            {
        //                PrIm.Remove("chipped short sword");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("chipped short sword") || seco == "chipped short sword")
        //            {
        //                SeCo.Remove("chipped short sword");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //Chipped short sword
        //        ////

        //        #region cracked staff
        //        if (y.Contains("equip") && y.Contains("cracked staff") && y.Contains("primary"))
        //        {
        //            if (clasl == "assassin" || clasl == "mage")
        //            {
        //                PrIm.Clear();
        //                prim = "cracked staff";
        //                PrIm.Add("cracked staff");
        //                attp = cracked_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        if (y.Contains("equip") && y.Contains("cracked staff") && y.Contains("secondary"))
        //        {
        //            if (clasl == "assassin" || clasl == "mage")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("cracked staff");
        //                seco = "cracked staff";
        //                atts = cracked_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not an assassin or a mage!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("cracked staff"))
        //        {
        //            invens.Remove("cracked staff");
        //            if (PrIm.Contains("cracked staff") || prim == "cracked staff")
        //            {
        //                PrIm.Remove("cracked staff");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("cracked staff") || seco == "cracked staff")
        //            {
        //                SeCo.Remove("cracked staff");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //cracked staff
        //        ////

        //        #region stick bow
        //        if (y.Contains("equip") && y.Contains("stick bow") && y.Contains("primary"))
        //        {
        //            if (clasl == "ranger")
        //            {
        //                PrIm.Clear();
        //                prim = "stick bow";
        //                PrIm.Add("stick bow");
        //                attp = sti_long_bow_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        if (y.Contains("equip") && y.Contains("stick bow") && y.Contains("secondary"))
        //        {
        //            if (clasl == "ranger")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("stick bow");
        //                seco = "stick bow";
        //                atts = cracked_staff_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not a ranger!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("stick bow"))
        //        {
        //            invens.Remove("stick bow");
        //            if (PrIm.Contains("stick bow") || prim == "stick bow")
        //            {
        //                PrIm.Remove("stick bowf");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("stick bow") || seco == "stick bow")
        //            {
        //                SeCo.Remove("stick bow");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //stick bow
        //        ////

        //        #region short sword
        //        if (y.Contains("equip") && y.Contains("short sword") && y.Contains("primary"))
        //        {
        //            if (clasl == "warrior")
        //            {
        //                PrIm.Clear();
        //                prim = "short sword";
        //                PrIm.Add("short sword");
        //                attp = short_sword_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        if (y.Contains("equip") && y.Contains("short sword") && y.Contains("secondary"))
        //        {
        //            if (clasl == "warrior")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("warrior");
        //                seco = "warrior";
        //                atts = short_sword_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not a warrior");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("short sword"))
        //        {
        //            invens.Remove("short sword");
        //            if (PrIm.Contains("short sword") || prim == "short sword")
        //            {
        //                PrIm.Remove("short sword");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("short sword") || seco == "short sword")
        //            {
        //                SeCo.Remove("short sword");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion //cracked staff
        //        ////

        //        #region poison dagger
        //        if (y.Contains("equip") && y.Contains("equip") && y.Contains("primary"))
        //        {
        //            if (clasl == "assassin")
        //            {
        //                PrIm.Clear();
        //                prim = "poison dagger";
        //                PrIm.Add("poison dagger");
        //                attp = posion_dagger_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        if (y.Contains("equip") && y.Contains("poison dagger") && y.Contains("secondary"))
        //        {
        //            if (clasl == "assassin")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("poison dagger");
        //                seco = "poison dagger";
        //                atts = posion_dagger_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not an assassin!");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        if (y.Contains("remove") && y.Contains("poison dagger"))
        //        {
        //            invens.Remove("poison dagger");
        //            if (PrIm.Contains("poison dagger") || prim == "poison dagger")
        //            {
        //                PrIm.Remove("poison dagger");
        //                prim = "";
        //                attp = 0;
        //                File.WriteAllText("Prim.txt", String.Empty);
        //            }
        //            if (SeCo.Contains("poison dagger") || seco == "poison dagger")
        //            {
        //                SeCo.Remove("poison dagger");
        //                seco = "";
        //                atts = 0;
        //                File.WriteAllText("Seco.txt", String.Empty);
        //            }
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine("You do not have that item!");
        //        //}
        //        #endregion
        //        ////

        //        #region regular dagger
        //        if (y.Contains("equip") && y.Contains("regular dagger") && y.Contains("primary"))
        //        {
        //            if (clasl != String.Empty)
        //            {
        //                PrIm.Clear();
        //                prim = "regular dagger";
        //                PrIm.Add("regular dagger");
        //                attp = reg_dagger_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //        }
        //        if (y.Contains("equip") && y.Contains("regular dagger") && y.Contains("secondary"))
        //        {
        //            if (clasl != "")
        //            {
        //                SeCo.Clear();
        //                SeCo.Add("poison dagger");
        //                seco = "poison dagger";
        //                atts = posion_dagger_att + classAtt;
        //                Console.WriteLine("equiped");
        //                Console.WriteLine("");
        //                b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                b.settings.volume = MIINVV;
        //                b.controls.play();
        //                TesatQ();
        //            }
        //            else
        //            {
        //                Console.WriteLine("You are not an assassin!");
        //            }
        //            //}
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("remove") && y.Contains("regular dagger"))
        //            {
        //                invens.Remove("regular dagger");
        //                if (PrIm.Contains("regular dagger") || prim == "regular dagger")
        //                {
        //                    PrIm.Remove("regular dagger");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("regular dagger") || seco == "regular dagger")
        //                {
        //                    SeCo.Remove("regular dagger");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //        #endregion
        //            ////

        //            #region meduim long bow
        //            if (y.Contains("equip") && y.Contains("meduim long bow") && y.Contains("primary"))
        //            {
        //                if (clasl == "ranger")
        //                {
        //                    PrIm.Clear();
        //                    prim = "meduim long bow";
        //                    PrIm.Add("meduim long bow");
        //                    attp = med_long_bow_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("meduim long bow") && y.Contains("secondary"))
        //            {
        //                if (clasl != "ranger")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("meduim long bow");
        //                    seco = "meduim long bow";
        //                    atts = med_long_bow_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a ranger!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("remove") && y.Contains("meduim long bow"))
        //            {
        //                invens.Remove("meduim long bow");
        //                if (PrIm.Contains("meduim long bow") || prim == "meduim long bow")
        //                {
        //                    PrIm.Remove("meduim long bow");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("meduim long bow") || seco == "meduim long bow")
        //                {
        //                    SeCo.Remove("meduim long bow");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region meduim long sword
        //            if (y.Contains("equip") && y.Contains("medium long sword") && y.Contains("primary"))
        //            {
        //                if (clasl == "warrior")
        //                {
        //                    PrIm.Clear();
        //                    prim = "medium long sword";
        //                    PrIm.Add("medium long sword");
        //                    attp = med_long_sword_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }

        //            if (y.Contains("equip") && y.Contains("medium long sword") && y.Contains("secondary"))
        //            {
        //                if (clasl == "warrior")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("medium long sword");
        //                    seco = "medium long sword";
        //                    atts = med_long_sword_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a warrior!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("remove") && y.Contains("medium long sword"))
        //            {
        //                invens.Remove("medium long sword");
        //                if (PrIm.Contains("medium long sword") || prim == "medium long sword")
        //                {
        //                    PrIm.Remove("medium long sword");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("medium long sword") || seco == "medium long sword")
        //                {
        //                    SeCo.Remove("medium long sword");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region short dagger
        //            if (y.Contains("equip") && y.Contains("short dagger") && y.Contains("primary"))
        //            {
        //                if (clasl == "rogue")
        //                {
        //                    PrIm.Clear();
        //                    prim = "short dagger";
        //                    PrIm.Add("short dagger");
        //                    attp = short_dagger_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("short dagger") && y.Contains("secondary"))
        //            {
        //                if (clasl == "rogue")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("short dagger");
        //                    seco = "short dagger";
        //                    atts = short_dagger_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a rogue!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("remove") && y.Contains("short dagger"))
        //            {
        //                invens.Remove("short dagger");
        //                if (PrIm.Contains("short dagger") || prim == "short dagger")
        //                {
        //                    PrIm.Remove("short dagger");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("short dagger") || seco == "short dagger")
        //                {
        //                    SeCo.Remove("short dagger");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region short staff
        //            if (y.Contains("equip") && y.Contains("short staff") && y.Contains("primary"))
        //            {
        //                if (clasl == "assassin")
        //                {
        //                    PrIm.Clear();
        //                    prim = "short staff";
        //                    PrIm.Add("short staff");
        //                    attp = short_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("short staff") && y.Contains("secondary"))
        //            {
        //                if (clasl == "assassin")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("short staff");
        //                    seco = "short staff";
        //                    atts = short_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a warrior!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("short staff") && y.Contains("short staff"))
        //            {
        //                invens.Remove("short staff");
        //                if (PrIm.Contains("short staff") || prim == "short staff")
        //                {
        //                    PrIm.Remove("short staff");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("short staff") || seco == "short staff")
        //                {
        //                    SeCo.Remove("short staff");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region long sword
        //            if (y.Contains("equip") && y.Contains("long sword") && y.Contains("primary"))
        //            {
        //                if (clasl == "warrior")
        //                {
        //                    PrIm.Clear();
        //                    prim = "long sword";
        //                    PrIm.Add("long sword");
        //                    attp = long_sword_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("long sword") && y.Contains("secondary"))
        //            {
        //                if (clasl == "warrior")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("long sword");
        //                    seco = "long sword";
        //                    atts = long_sword_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a warrior!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("long sword") && y.Contains("long sword"))
        //            {
        //                invens.Remove("long sword");
        //                if (PrIm.Contains("long sword") || prim == "long sword")
        //                {
        //                    PrIm.Remove("long sword");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("long sword") || seco == "long sword")
        //                {
        //                    SeCo.Remove("long sword");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region long bow
        //            if (y.Contains("equip") && y.Contains("long bow") && y.Contains("primary"))
        //            {
        //                if (clasl == "ranger")
        //                {
        //                    PrIm.Clear();
        //                    prim = "long bow";
        //                    PrIm.Add("long bow");
        //                    attp = long_bow_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("long bow") && y.Contains("secondary"))
        //            {
        //                if (clasl == "ranger")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("long bow");
        //                    seco = "long bow";
        //                    atts = long_bow_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a ranger!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("long bow") && y.Contains("long bow"))
        //            {
        //                invens.Remove("long bow");
        //                if (PrIm.Contains("long bow") || prim == "long bow")
        //                {
        //                    PrIm.Remove("long bow");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("long bow") || seco == "long bow")
        //                {
        //                    SeCo.Remove("long bow");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region silver dagger
        //            if (y.Contains("equip") && y.Contains("silver dagger") && y.Contains("primary"))
        //            {
        //                if (clasl == "rogue")
        //                {
        //                    PrIm.Clear();
        //                    prim = "silver dagger";
        //                    PrIm.Add("silver dagger");
        //                    attp = sil_dagger_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("silver dagger") && y.Contains("secondary"))
        //            {
        //                if (clasl == "rogue")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("silver dagger");
        //                    seco = "silver dagger";
        //                    atts = sil_dagger_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a rogue!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("silver dagger") && y.Contains("remove"))
        //            {
        //                invens.Remove("silver dagger");
        //                if (PrIm.Contains("silver dagger") || prim == "silver dagger")
        //                {
        //                    PrIm.Remove("silver dagger");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("silver dagger") || seco == "silver dagger")
        //                {
        //                    SeCo.Remove("silver dagger");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region  mage staff
        //            if (y.Contains("equip") && y.Contains("mage staff") && y.Contains("primary"))
        //            {
        //                if (clasl == "mage")
        //                {
        //                    PrIm.Clear();
        //                    prim = "mage staff";
        //                    PrIm.Add("mage staff");
        //                    attp = mage_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("mage staff") && y.Contains("secondary"))
        //            {
        //                if (clasl == "mage")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("mage staff");
        //                    seco = "mage staff";
        //                    atts = mage_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a mage!");
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("You do not have that item!");
        //            }
        //            if (y.Contains("mage staff") && y.Contains("remove"))
        //            {
        //                invens.Remove("mage staff");
        //                if (PrIm.Contains("mage staff") || prim == "mage staff")
        //                {
        //                    PrIm.Remove("mage staff");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("mage staff") || seco == "mage staff")
        //                {
        //                    SeCo.Remove("mage staff");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region bow staff
        //            if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("primary"))
        //            {
        //                if (clasl == "assasin")
        //                {
        //                    PrIm.Clear();
        //                    prim = "bow staff";
        //                    PrIm.Add("bow staff");
        //                    attp = bow_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //            }
        //            if (y.Contains("equip") && y.Contains("bow staff") && y.Contains("secondary"))
        //            {
        //                if (clasl == "assassin")
        //                {
        //                    SeCo.Clear();
        //                    SeCo.Add("bow staff");
        //                    seco = "bow staff";
        //                    atts = bow_staff_att + classAtt;
        //                    Console.WriteLine("equiped");
        //                    Console.WriteLine("");
        //                    b.URL = curetna + @"\MUSIC\MOVININV.mp3";
        //                    b.settings.volume = MIINVV;
        //                    b.controls.play();
        //                    TesatQ();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You are not a assassin!");
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            if (y.Contains("bow staff") && y.Contains("remove"))
        //            {
        //                invens.Remove("bow staff");
        //                if (PrIm.Contains("bow staff") || prim == "bow staff")
        //                {
        //                    PrIm.Remove("bow staff");
        //                    prim = "";
        //                    attp = 0;
        //                    File.WriteAllText("Prim.txt", String.Empty);
        //                }
        //                if (SeCo.Contains("bow staff") || seco == "bow staff")
        //                {
        //                    SeCo.Remove("bow staff");
        //                    seco = "";
        //                    atts = 0;
        //                    File.WriteAllText("Seco.txt", String.Empty);
        //                }
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine("You do not have that item!");
        //            //}
        //            #endregion
        //            ////

        //            #region tin hat
        //            #endregion


        //            //}
        //            //}
        //        }
        //    }
        //}
        public static void ENDNAM()
        {
            xc = 0;
            yc = 0;
            Console.WriteLine("'Come on, let me go! Let me go!");
            Console.WriteLine("You see a child, being pulled by a giant masked man, accross the doungon floor");
            Console.WriteLine("heading into the room labeled: 'execution room'");
            Console.WriteLine("");
            Console.WriteLine("Welcome, {0}, the {1}, to the land of ZALENTH!", name, clasl.ToUpper());
            Console.WriteLine("");
            Console.WriteLine("There are {0} land(s) in this version. (more to come!)", curenta);
            Console.WriteLine("'help'                DISPLAYS HELP");
            Console.WriteLine("'north'               GO NORTH");
            Console.WriteLine("'east'                GO EAST");
            Console.WriteLine("'south'               GO SOUTH");
            Console.WriteLine("'west'                GO WEST");
            Console.WriteLine("'potion'              USE POTION'");
            Console.WriteLine("'store'               OPENS STORE");
            Console.WriteLine("");
            Console.WriteLine("----------BATTLE----------");
            Console.WriteLine("'attack_p'            ATTACKS DURING BATTLE (PRIMARY)");
            Console.WriteLine("'attack_s'            ATTACKS DURING BATTLE (SECENDARY)");
            Console.WriteLine("'defend'              DEFENDS DURING BATTLE <*2 DEF>");
            Console.WriteLine("");
            Console.WriteLine("----------COMMANDS----------");
            Console.WriteLine("'cls'                 CLEARS THE SCREEN");
            Console.WriteLine("'stat'                DISPLAYS STATS");
            Console.WriteLine("'inventory'           DISPLAYES INVENTORY");
            Console.WriteLine("'xp'                  DISPLAYS XP");
            Console.WriteLine("'money                DISPLAYS COINS'");
            Console.WriteLine("'kills'               DISPLAYES KILLS");
            Console.WriteLine("'save'                SAVES GAME");
            Console.WriteLine("'logout'              LOGS OUT CHARACTER");
            Console.WriteLine("'suicide'             KILLS CHARACTER");
            Console.WriteLine("'world'               WORLD SELECT");
            Console.WriteLine("'skill'               USE SKILL POINTS");
            Console.WriteLine("----------SETTINGS----------");
            Console.WriteLine("'sound'               SOUND OPTIONS");
            Console.WriteLine("'song'                CHOOSE SONG");
            Console.WriteLine("");
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("This is version: {0}", version);
            Console.WriteLine("and has limited features, typos, ect.");
            Console.WriteLine("Please do not think less of the final product, because of the debug version!");
            Console.WriteLine("Enough of the talk, press any key to begin!");
            Console.ReadKey();
            Console.Clear();
            world_select();
        }
        public static void TesatQ()
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
                            Console.WriteLine("LAND: {0} HP: {1}, CRLD: ({2} , {3}) LEVEL: {4} SCORE: {5}", wourld, health, xc, yc, level, scorea);
                            Console.WriteLine("");
                            a = Console.ReadLine();
                            a = a.ToLower();
                            sw.Start();
                            switch (a)
                            {
                                case "load addon":
                                    Console.WriteLine("");
                                    Load_Add_On();
                                    break;
                                case "help":
                                    Console.WriteLine("");
                                    help();
                                    break;
                                case "north":
                                    Console.WriteLine("");
                                    Go_North();
                                    break;
                                case "east":
                                    Console.WriteLine("");
                                    Go_East();
                                    break;
                                case "west":
                                    Console.WriteLine("");
                                    Go_West();
                                    break;
                                case "south":
                                    Console.WriteLine("");
                                    Go_South();
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
                                case "save":
                                    save_file();
                                    break;
                                case "logout":
                                    load_or_new();
                                    break;
                                case "suicide":
                                    SuicKil();
                                    break;
                                case "world":
                                    world_select();
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
                                case "init console":
                                    inconsole = true;
                                    while (inconsole)
                                    {
                                        //string[] myvalue = Console.ReadLine().Split(' ');
                                        List<string> AllS = new List<string>();
                                        string intSpacedString;
                                        char[] spaceSeparator = new char[] { ' ' };
                                        string[] result;
                                        while (inconsole)
                                        {
                                            Console.Write(">>> ");
                                            intSpacedString = Console.ReadLine();
                                            result = intSpacedString.Split(spaceSeparator, StringSplitOptions.None);
                                            foreach (string str in result)
                                            {
                                                AllS.Add(str);
                                            }
                                            TCon.Run(result);
                                        }
                                    }
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
                    else
                    {
                        Console.Title = (health.ToString());
                        Console.WriteLine("LAND: {0} HP: {1}, CRLD: ({2} , {3}) LEVEL: {4} SCORE: {5}", wourld, health, xc, yc, level, scorea);
                        Console.WriteLine("");
                        a = Console.ReadLine();
                        a = a.ToLower();
                        switch (a)
                        {
                            case "help":
                                Console.WriteLine("");
                                help();
                                break;
                            case "north":
                                Console.WriteLine("");
                                Go_North();
                                break;
                            case "east":
                                Console.WriteLine("");
                                Go_East();
                                break;
                            case "west":
                                Console.WriteLine("");
                                Go_West();
                                break;
                            case "south":
                                Console.WriteLine("");
                                Go_South();
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
                            case "save":
                                Console.WriteLine("You can not save in a dungon!");
                                break;
                            case "logout":
                                load_or_new();
                                break;
                            case "suicide":
                                SuicKil();
                                break;
                            case "world":
                                world_select();
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
                }
            }
        }
        public static void Go_North()
        {
            if (in_dungon == false)
            {
                if (yc != max_xc)
                {
                    WMP.URL = movem;
                    WMP.controls.play();
                    yc++;
                    CheckForDungon();
                    Console.WriteLine("CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                    MobSpawn();
                }
                else
                {
                    Console.WriteLine("You have reached the end of the map! CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                }
            }
            else
            {
                if (ycdl != maxycdl)
                {
                    WMP.URL = movem;
                    WMP.controls.play();
                    ycdl++;
                    Console.WriteLine("CorDl {0}, BOSS AT {1}", ycdl, maxycdl);
                    Console.WriteLine("");
                }
                else
                {
                    StartBattle();
                }
            }
        }
        public static void Go_South()
        {
            if (in_dungon == false)
            {
                if (yc != umax_yc)
                {
                    WMP.URL = movem;
                    WMP.controls.play();
                    yc--;
                    CheckForDungon();
                    Console.WriteLine("CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                    MobSpawn();
                }
                else
                {
                    Console.WriteLine("You have reached the end of the map! CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                }
            }
            else
            {
                if (ycdl != umaxycdl)
                {
                    if (ycdl != maxycdl)
                    {
                        WMP.URL = movem;
                        WMP.controls.play();
                        ycdl--;
                        Console.WriteLine("CorDl {0}, BOSS AT {1}", ycdl, maxycdl);
                        Console.WriteLine("");
                        StartBattle();
                    }
                }
                else
                {
                    Console.WriteLine("Do you want to leave? ('yes' or 'no')");
                    while (true)
                    {
                        string ynindn = Console.ReadLine();
                        ynindn = ynindn.ToLower();
                        switch (ynindn)
                        {
                            case "yes":
                            case "y":
                                in_dungon = false;
                                TesatQ();
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
            }
        }
        public static void Go_East()
        {
            if (in_dungon != true)
            {
                if (xc != max_xc)
                {
                    WMP.URL = movem;
                    WMP.controls.play();
                    xc++;
                    CheckForDungon();
                    Console.WriteLine("CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                    MobSpawn();
                }
                else
                {
                    Console.WriteLine("You have reached the end of the map! CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("There is a dungon wall to the east, and the west; you can not pass here!");
            }
        }
        public static void Go_West()
        {
            if (in_dungon != true)
            {
                if (xc != umax_xc)
                {
                    WMP.URL = movem;
                    WMP.controls.play();
                    xc--;
                    CheckForDungon();
                    Console.WriteLine("CorDL {0}, {1}", xc, yc);
                    MobSpawn();
                }
                else
                {
                    Console.WriteLine("You have reached the end of the map! CorDL {0}, {1}", xc, yc);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("There is a dungon wall to the east, and the west; you can not pass here!");
            }
        }
        public static void BossFight()
        {
            int boss_lvl = 1;
            {
                NameOfMob = "The Red Dragon";
                while (boss_lvl <= level)
                {
                    ml = 1 + level;
                    MAtt = 15 + level;
                    Mdef = 8 + level;
                    ml = 1 + level;
                    MHealth = 120 + level;
                    boss_lvl++;
                }
                while (ml < level)
                {
                    ml = ml + 1;
                    MHealth = MHealth + 10;
                    MAtt = MAtt + 3;
                    Mdef = Mdef + 3;
                }
                battle();
                in_dungon = false;
                xc = 0;
                yc = 0;
                copperc += 500;
                silverc += 300;
                goldx += 100;
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
            spawn = rnd.Next(1, 6);
            number = rnd.Next(1, 3);
            sq = number;
            if (in_dungon == false)
            {
                if (wourld == "zalenth")
                {
                    switch (spawn)
                    {
                        case 1:
                            if (sq > 0)
                            {
                                Console.WriteLine("{0} ogre(s) has spawned!", sq);
                                Console.WriteLine("Press any key.Easter Egg");
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
            else
            {
                if (ycdl == 2)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 3)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 4)
                {
                    number = 2;
                    StartBattle();
                }
                if (ycdl == 5)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 6)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 7)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 8)
                {
                    number = 1;
                    StartBattle();
                }
                if (ycdl == 9)
                {
                    number = 2;
                    StartBattle();
                }
                else
                {
                    Console.WriteLine("The Red Demon: 'HAHAHAHA!!! YOU THINK YOU CAN FIGHT ME!?!?!");
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    Console.WriteLine("{0} THE {1}, YOU ARE ONLY LEVEL {2}! YOU THINK YOU CAN WIN? PREPARE TO FIGHT ME!!!", name.ToUpper(), clasl.ToUpper(), level);
                    Console.WriteLine("Press any key");
                    Console.ReadKey();
                    BossFight();
                }
            }
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
                                    Console.WriteLine("You can't use that in battle!");
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
                                case "init console":
                                    inconsole = true;
                                    while (inconsole)
                                    {
                                        //string[] myvalue = Console.ReadLine().Split(' ');
                                        List<string> AllS = new List<string>();
                                        string intSpacedString;
                                        char[] spaceSeparator = new char[] { ' ' };
                                        string[] result;
                                        while (inconsole)
                                        {
                                            Console.Write(">>> ");
                                            intSpacedString = Console.ReadLine();
                                            result = intSpacedString.Split(spaceSeparator, StringSplitOptions.None);
                                            foreach (string str in result)
                                            {
                                                AllS.Add(str);
                                            }
                                            TCon.Run(result);
                                        }
                                    }
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
        #endregion //VOIDS
    }
    #endregion //CLASS
    public class TCon
    {
        public static void Run(string[] command)
        {

            //            static bool in_dungon = false;
            //static int ycdl;
            //static int maxycdl = 10;
            //static int umaxycdl = 0;
            ////---ALL---
            //static int BMV = 80;
            //static int ATV = 100;
            //static int MVV = 100;
            //static int MIINVV = 100;
            //static int INVOPV = 100;

            //static int cracked_staff_att = 10;
            //static int rusty_dagger_att = 9;
            //static int golden_dagger_att = 10;
            //static int broken_bow_att = 11;
            //static int chipped_short_sword_att = 12;
            ////
            //static int helth_pts;
            //static int att_pts;
            //static int def_pts;
            //static int speed_pts;
            ////


            //public static string h;
            ////
            //public static int skill_points;
            //public static int bow_staff_att = 8;
            //public static int long_bow_att = 30;
            //public static int med_long_bow_att = 15;
            //public static int sti_long_bow_att = 8;
            //public static int reg_dagger_att = 5;
            //public static int tin_hat_def;
            //public static int long_sword_att = 30;
            //public static int med_long_sword_att = 15;
            //public static int short_dagger_att = 15;
            //public static int short_staff_att = 15;
            //public static int sil_dagger_att = 30;
            //public static int mage_staff_att = 30;
            //public static int short_sword_att = 9;
            //public static int posion_dagger_att = 8;
            //public static int regular_mage_staff_att = 10;
            try
            {
                switch (command[0])
                {
                    case "set":
                        switch (command[1])
                        {
                            case "skill_points":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.skill_points)) { Console.WriteLine(">>> {0}", Program.skill_points); }
                                break;
                            case "chance_for_drop":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.chance_for_drop)) { Console.WriteLine(">>> {0}", Program.chance_for_drop); }
                                break;
                            case "price":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.price)) { Console.WriteLine(">>> {0}", Program.price); }
                                break;
                            case "mcc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.mcc)) { Console.WriteLine(">>> {0}", Program.mcc); }
                                break;
                            case "scc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.scc)) { Console.WriteLine(">>> {0}", Program.scc); }
                                break;
                            case "gcc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.gcc)) { Console.WriteLine(">>> {0}", Program.gcc); }
                                break;

                            case "t":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.t)) { Console.WriteLine(">>> {0}", Program.t); }
                                break;
                            case "dek":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.dek)) { Console.WriteLine(">>> {0}", Program.dek); }
                                break;
                            case "xp_gained":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.xp_gained)) { Console.WriteLine(">>> {0}", Program.xp_gained); }
                                break;
                            case "sq":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.sq)) { Console.WriteLine(">>> {0}", Program.sq); }
                                break;
                            case "temp_def":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.temp_def)) { Console.WriteLine(">>> {0}", Program.temp_def); }
                                break;
                            case "wourld":
                                if (command[2] != null)
                                    Program.wourld = command[2];
                                Console.WriteLine(">>> {0}", Program.wourld);
                                break;
                            case "scorea":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.scorea)) { Console.WriteLine(">>> {0}", Program.scorea); }
                                break;
                            case "max_health":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.max_health)) { Console.WriteLine(">>> {0}", Program.max_health); }
                                break;
                            case "classDef":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.classDef)) { Console.WriteLine(">>> {0}", Program.classDef); }
                                break;
                            case "classAtt":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.classAtt)) { Console.WriteLine(">>> {0}", Program.classAtt); }
                                break;
                            case "copperc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.copperc)) { Console.WriteLine(">>> {0}", Program.copperc); }
                                break;
                            case "silverc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.silverc)) { Console.WriteLine(">>> {0}", Program.silverc); }
                                break;
                            case "goldx":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.goldx)) { Console.WriteLine(">>> {0}", Program.goldx); }
                                break;
                            case "HealthPotions":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.HealthPotions)) { Console.WriteLine(">>> {0}", Program.HealthPotions); }
                                break;
                            case "version":
                                if (command[2] != null)
                                    Program.version = command[2];
                                Console.WriteLine(">>> {0}", Program.version);
                                break;
                            case "ynl":
                                if (command[2] != null)
                                    Program.ynl = command[2];
                                Console.WriteLine(">>> {0}", Program.ynl);
                                break;
                            case "okxp":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.okxp)) { Console.WriteLine(">>> {0}", Program.okxp); }
                                break;
                            case "okay":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.ok)) { Console.WriteLine(">>> {0}", Program.ok); }
                                break;
                            case "xpt":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.xpt)) { Console.WriteLine(">>> {0}", Program.xpt); }
                                break;
                            case "xp":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.xp)) { Console.WriteLine(">>> {0}", Program.xp); }
                                break;
                            case "name":
                                if (command[2] != null) {Program.name = command[2]; Console.WriteLine(">>> {0}", Program.name);}
                                break;
                            case "speed":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.speed)) { Console.WriteLine(">>> {0}", Program.speed); }
                                break;
                            case "yc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.yc)) { Console.WriteLine(">>> {0}", Program.yc); }
                                break;
                            case "xc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.xc)) { Console.WriteLine(">>> {0}", Program.xc); }
                                break;
                            case "umax_yc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.umax_yc)) { Console.WriteLine(">>> {0}", Program.umax_yc); }
                                break;
                            case "umax_xc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.umax_xc)) { Console.WriteLine(">>> {0}", Program.umax_xc); }
                                break;
                            case "max_yc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.max_yc)) { Console.WriteLine(">>> {0}", Program.max_yc); }
                                break;
                            case "max_xc":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.max_xc)) { Console.WriteLine(">>> {0}", Program.max_xc); }
                                break;
                            case "wdtbl":
                                if (command[2] != null)
                                    Program.wdtbl = command[2];
                                Console.WriteLine(">>> {0}", Program.wdtbl);
                                break;
                            case "health":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.health)) { Console.WriteLine(">>> {0}", Program.health); }
                                break;
                            case "level":
                                if (command[2] != null)
                                    if (int.TryParse(command[2], out Program.level)) { Console.WriteLine(">>> {0}", Program.level); }
                                break;
                            case "exit":
                                Program.inconsole = false;
                                break;
                            default:
                                break;

                        }
                        break;
                    case "exit":
                        Program.inconsole = false;
                        break;

                }
            }

            catch
            {

            }
        }
    }
}
#endregion //NAMESPACE
#endregion //ALL
