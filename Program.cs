// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Threading;
using System;
using Pariveda_Project;
//MAIN


 int customersThatPurchased = 0;
 int sugarLevel = 0;
 int caffeineLevel = 0;
 int addictivenessLevel = 0;
 int dayNum = 1;

Random rnd1 = new Random();
 int CUSTOMER_PREFERENCE_1Sugar = rnd1.Next(1,6);
 int CUSTOMER_PREFERENCE_2Caffeine = rnd1.Next(1,6);
 int CUSTOMER_PREFERENCE_3Addictiveness = rnd1.Next(1,6);

 Random rnd = new Random();
 int sugarCustomersThatStoppedBy = rnd.Next(10,16);
 int caffeineCustomersThatStoppedBy =rnd.Next(10,16);
 int addictivenessCustomersThatStoppedBy =rnd.Next(10,16);

string userInput = GetMenuChoice();

while (userInput != "3")
{
    Route(userInput, ref sugarLevel,ref caffeineLevel, ref addictivenessLevel, ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref dayNum, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
    userInput = GetMenuChoice();
    
}




//END MAIN
//Menu


static string GetMenuChoice(){
    DisplayMenu();
    string userInput = Console.ReadLine();

    while (!ValidMenuChoice(userInput))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayMenu();
        userInput = Console.ReadLine();
    }

    return userInput;
}

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("1:   Play UA Energy");
    Console.WriteLine("2:   Rules & Instructions");
    Console.WriteLine("3:   Exit Game");
}

static bool ValidMenuChoice(string userInput){
  
   if(userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    else
        return false;
}


static void Route(string userInput, ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel,ref int customersThatPurchased, ref int sugarCustomersThatStoppedBy, ref int dayNum,ref int caffeineCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness){
    if(userInput == "1")
    {
        WelcomeMessage();
        EnergyDrinkSettings(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel);
        Console.Clear();
        DisplayStandOpen1();
        Thread.Sleep(800);
        Console.Clear();
        DisplayStandOpen2();
        Thread.Sleep(800);
        Console.Clear();
        DisplayStandOpen3();
        Thread.Sleep(800);
        Console.Clear();
        DisplayStandOpen4();
        Thread.Sleep(800);
        Console.Clear();
        DisplayStandOpen5();
        Thread.Sleep(1000);
        Purchases(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel,ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
        Thread.Sleep(800);
        Console.Clear();
        Feedback(ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy,ref addictivenessCustomersThatStoppedBy, ref customersThatPurchased,ref dayNum, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel,  CUSTOMER_PREFERENCE_1Sugar,  CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
        dayNum++;

        while(dayNum != 5)
        {
             Random rnd = new Random();
            sugarCustomersThatStoppedBy = rnd.Next(10,16);
            caffeineCustomersThatStoppedBy =rnd.Next(10,16);
            addictivenessCustomersThatStoppedBy =rnd.Next(10,16);
            EnergyDrinkSettings(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel);
            Console.Clear();
            DisplayStandOpen1();
            Thread.Sleep(800);
            Console.Clear();
            DisplayStandOpen2();
            Thread.Sleep(800);
            Console.Clear();
            DisplayStandOpen3();
            Thread.Sleep(800);
            Console.Clear();
            DisplayStandOpen4();
            Thread.Sleep(800);
            Console.Clear();
            DisplayStandOpen5();
            Thread.Sleep(1000);
            Purchases(ref sugarLevel,ref caffeineLevel, ref addictivenessLevel, ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
            Thread.Sleep(800);
            Console.Clear();
            Feedback(ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy,ref addictivenessCustomersThatStoppedBy, ref customersThatPurchased,ref dayNum, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel,  CUSTOMER_PREFERENCE_1Sugar,  CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
            dayNum++;
        }

    }
    /*else if (userInput == "2")
    {
        ScoreBoard(gamesWon, gamesLost);
    } */
} 


//RunGame

static void WelcomeMessage()
{
    System.Console.WriteLine("Welcome to UA Energy!");
    System.Console.WriteLine("(((((((((((((((((((((((((((((((((((((((((((((((((((((()))))))))))))))))))))))))))))))))))))))))))))))))))))))");
    System.Console.WriteLine("|        /$$   /$$  /$$$$$$        /$$$$$$$$ /$$   /$$ /$$$$$$$$ /$$$$$$$    /$$$$$$$ /$$     /$$|          |");
    System.Console.WriteLine("|       | $$  | $$ /$$__  $$      | $$_____/| $$$ | $$| $$_____/| $$__  $$  /$$__  $$|  $$   /$$/           |");
    System.Console.WriteLine("|       | $$  | $$| $$  \'$$       | $$      | $$$$| $$| $$      | $$  \'  $$| $$ \' __/ \'  $$ /$$/            |");
    System.Console.WriteLine("|       | $$  | $$| $$$$$$$$      | $$$$$   | $$ $$ $$| $$$$$   | $$$$$$$/ | $$ /$$$$  \'  $$$$/             |");
    System.Console.WriteLine("|       | $$  | $$| $$__  $$      | $$__/   | $$  $$$$| $$__/   | $$__  $$ | $$|_  $$   \'  $$/              |");
    System.Console.WriteLine("|       | $$  | $$| $$  | $$      | $$      | $$\' $$$ | $$      | $$  \'  $$| $$  \' $$    | $$               |");
    System.Console.WriteLine("|       |  $$$$$$/| $$  | $$      | $$$$$$$$| $$ \' $$ | $$$$$$$$| $$  |  $$|  $$$$$$/    | $$               |");
    System.Console.WriteLine("|        \'_____/ |__/  |__/       |________/|__/  \'_ /|________/|__/  |__/  \'______/     |__/               |");
    System.Console.WriteLine("(((((((((((((((((((((((((((((((((((((((((((((((((((((()))))))))))))))))))))))))))))))))))))))))))))))))))))))");

}

static void EnergyDrinkSettings(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel)
{
    System.Console.WriteLine("* *");
    System.Console.WriteLine("   Sugar Content { 1  2  3  4  5 }");
    System.Console.WriteLine("   Current Sugar Level: " + sugarLevel);
    System.Console.WriteLine("Please enter your desired sugar level ( 1 - 5) ");
    sugarLevel = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("You have changed your sugar level to " + sugarLevel);

    System.Console.WriteLine("* *");
    System.Console.WriteLine("   Caffeine Content { 1  2  3  4  5 }");
    System.Console.WriteLine("   Current Caffeine Level: " + caffeineLevel);
    System.Console.WriteLine("Please enter your desired caffeine level ( 1 - 5) ");
    caffeineLevel = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("You have changed your caffeine level to " + caffeineLevel);

    System.Console.WriteLine("* *");
    System.Console.WriteLine("   Addictiveness Content { 1  2  3  4  5 }");
    System.Console.WriteLine("   Current addictiveness Level: " + addictivenessLevel);
    System.Console.WriteLine("Please enter your desired addictiveness level ( 1 - 5) ");
    addictivenessLevel = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("You have changed your sugar level to " + addictivenessLevel);



   
}

static void DisplayStandOpen1()
{
    System.Console.WriteLine("                                                                 -----------------------------------");
    System.Console.WriteLine("                                                                 |                 _______         |");
    System.Console.WriteLine("                                                                 |                /      /         |");
    System.Console.WriteLine("                                                                 |               /      /          |");
    System.Console.WriteLine("                                                                 |              /      /__         |");
    System.Console.WriteLine("                                                                 |             /__       /         |");
    System.Console.WriteLine("                                                                 |               /     /           |");
    System.Console.WriteLine("                                                                 |              /    /             |");
    System.Console.WriteLine("                                                                 |             /   /               |");
    System.Console.WriteLine("                                                                 |            /  /                 |");
    System.Console.WriteLine("                                                                 |           / /                   |");
    System.Console.WriteLine("                                                                 |           /                     |");
    System.Console.WriteLine("                                                                 -----------------------------------");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine(" ///|\\\\\\'         ///|\\\\\\'      ///|\\\\\\'         ///|\\\\\\'           |                         |");
    System.Console.WriteLine("|    (@)|        |    (@)|     |    (@)|        |    (@)|           |                         |");
    System.Console.WriteLine("|      ~|        |      ~|     |      ~|        |      ~|           |                         |");
    System.Console.WriteLine(" \\     /          \\     /       \\     /          \\     /            |                         |");
    System.Console.WriteLine("  |   |            |   |         |   |            |   |             |                         |");
    System.Console.WriteLine(" /     \\   /      /     \\   /   /     \\   /      /     \\   /        |                         |");
    System.Console.WriteLine("|   /   | /      |    /  | /   |   /   | /      |    /  | /     ----------------------------------");
    System.Console.WriteLine("|  /    |/       |   /   |/    |  /    |/       |   /   |/      |                                |");
    System.Console.WriteLine("|_______|        |_______|     |_______|        |_______|       |                                |");
    System.Console.WriteLine("|       |        |       |     |       |        |       |       |             [OPEN]             |");
    System.Console.WriteLine("|   _   |        |   _   |     |   _   |        |   _   |       |                                |");
    System.Console.WriteLine("|  | |  |        |  | |  |     |  | |  |        |  | |  |       |                                |");
    System.Console.WriteLine("|  | |  |        |  | |  |     |  | |  |        |  | |  |       ----------------------------------");

   

}

static void DisplayStandOpen2()
{
    System.Console.WriteLine("                                                        -----------------------------------");
    System.Console.WriteLine("                                                        |                 _______         |");
    System.Console.WriteLine("                                                        |                /      /         |");
    System.Console.WriteLine("                                                        |               /      /          |");
    System.Console.WriteLine("                                                        |              /      /__         |");
    System.Console.WriteLine("                                                        |             /__       /         |");
    System.Console.WriteLine("                                                        |               /     /           |");
    System.Console.WriteLine("                                                        |              /    /             |");
    System.Console.WriteLine("                                                        |             /   /               |");
    System.Console.WriteLine("                                                        |            /  /                 |");
    System.Console.WriteLine("                                                        |           / /                   |");
    System.Console.WriteLine("                                                        |           /                     |");
    System.Console.WriteLine("                                                        -----------------------------------");
    System.Console.WriteLine("                                                           |                         |");
    System.Console.WriteLine("                                                           |                         |");
    System.Console.WriteLine("                                                           |                         |");
    System.Console.WriteLine("         ///|\\\\\\'      ///|\\\\\\'         ///|\\\\\\'           |                         |");
    System.Console.WriteLine("        |    (@)|     |    (@)|        |    (@)|           |                         |");
    System.Console.WriteLine("        |      ~|     |      ~|        |      ~|           |                         |");
    System.Console.WriteLine("         \\     /       \\     /          \\     /            |                         |");
    System.Console.WriteLine("          |   |         |   |            |   |             |                         |");
    System.Console.WriteLine("         /     \\   /   /     \\   /      /     \\   /        |                         |");
    System.Console.WriteLine("        |    /  | /   |   /   | /      |    /  | /     ----------------------------------");
    System.Console.WriteLine("        |   /   |/    |  /    |/       |   /   |/      |                                |");
    System.Console.WriteLine("        |_______|     |_______|        |_______|       |                                |");
    System.Console.WriteLine("        |       |     |       |        |       |       |             [OPEN]             |");
    System.Console.WriteLine("        |   _   |     |   _   |        |   _   |       |                                |");
    System.Console.WriteLine("        |  | |  |     |  | |  |        |  | |  |       |                                |");
    System.Console.WriteLine("        |  | |  |     |  | |  |        |  | |  |       ----------------------------------");

 

}

static void DisplayStandOpen3()
{
    System.Console.WriteLine("                                                  -----------------------------------");
    System.Console.WriteLine("                                                  |                 _______         |");
    System.Console.WriteLine("                                                  |                /      /         |");
    System.Console.WriteLine("                                                  |               /      /          |");
    System.Console.WriteLine("                                                  |              /      /__         |");
    System.Console.WriteLine("                                                  |             /__       /         |");
    System.Console.WriteLine("                                                  |               /     /           |");
    System.Console.WriteLine("                                                  |              /    /             |");
    System.Console.WriteLine("                                                  |             /   /               |");
    System.Console.WriteLine("                                                  |            /  /                 |");
    System.Console.WriteLine("                                                  |           / /                   |");
    System.Console.WriteLine("                                                  |           /                     |");
    System.Console.WriteLine("                                                  -----------------------------------");
    System.Console.WriteLine("                                                  |                         |");
    System.Console.WriteLine("                                                  |                         |");
    System.Console.WriteLine("                                                  |                         |");
    System.Console.WriteLine("               ///|\\\\\\'         ///|\\\\\\'          |                         |");
    System.Console.WriteLine("             |    (@)|        |    (@)|           |                         |");
    System.Console.WriteLine("             |      ~|        |      ~|           |                         |");
    System.Console.WriteLine("              \\     /          \\     /            |                         |");
    System.Console.WriteLine("               |   |            |   |             |                         |");
    System.Console.WriteLine("              /     \\   /      /     \\   /        |                         |");
    System.Console.WriteLine("             |   /   | /      |    /  | /     ----------------------------------");
    System.Console.WriteLine("             |  /    |/       |   /   |/      |                                |");
    System.Console.WriteLine("             |_______|        |_______|       |                                |");
    System.Console.WriteLine("             |       |        |       |       |             [OPEN]             |");
    System.Console.WriteLine("             |   _   |        |   _   |       |                                |");
    System.Console.WriteLine("             |  | |  |        |  | |  |       |                                |");
    System.Console.WriteLine("             |  | |  |        |  | |  |       ----------------------------------");


}

static void DisplayStandOpen4()
{
    System.Console.WriteLine("                                         -----------------------------------");
    System.Console.WriteLine("                                         |                 _______         |");
    System.Console.WriteLine("                                         |                /      /         |");
    System.Console.WriteLine("                                         |               /      /          |");
    System.Console.WriteLine("                                         |              /      /__         |");
    System.Console.WriteLine("                                         |             /__       /         |");
    System.Console.WriteLine("                                         |               /     /           |");
    System.Console.WriteLine("                                         |              /    /             |");
    System.Console.WriteLine("                                         |             /   /               |");
    System.Console.WriteLine("                                         |            /  /                 |");
    System.Console.WriteLine("                                         |           / /                   |");
    System.Console.WriteLine("                                         |           /                     |");
    System.Console.WriteLine("                                         -----------------------------------");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine("                                                                    |                         |");
    System.Console.WriteLine("                      ///|\\\\\\'           |                         |");
    System.Console.WriteLine("                     |    (@)|           |                         |");
    System.Console.WriteLine("                     |      ~|           |                         |");
    System.Console.WriteLine("                      \\     /            |                         |");
    System.Console.WriteLine("                       |   |             |                         |");
    System.Console.WriteLine("                      /     \\   /        |                         |");
    System.Console.WriteLine("                     |    /  | /     ----------------------------------");
    System.Console.WriteLine("                     |   /   |/      |                                |");
    System.Console.WriteLine("                     |_______|       |                                |");
    System.Console.WriteLine("                     |       |       |             [OPEN]             |");
    System.Console.WriteLine("                     |   _   |       |                                |");
    System.Console.WriteLine("                     |  | |  |       |                                |");
    System.Console.WriteLine("                     |  | |  |       ----------------------------------");


      
}

static void DisplayStandOpen5()
{
    System.Console.WriteLine("                                         -----------------------------------");
    System.Console.WriteLine("                                         |                 _______         |");
    System.Console.WriteLine("                                         |                /      /         |");
    System.Console.WriteLine("                                         |               /      /          |");
    System.Console.WriteLine("                                         |              /      /__         |");
    System.Console.WriteLine("                                         |             /__       /         |");
    System.Console.WriteLine("                                         |               /     /           |");
    System.Console.WriteLine("                                         |              /    /             |");
    System.Console.WriteLine("                                         |             /   /               |");
    System.Console.WriteLine("                                         |            /  /                 |");
    System.Console.WriteLine("                                         |           / /                   |");
    System.Console.WriteLine("                                         |           /                     |");
    System.Console.WriteLine("                                         -----------------------------------");
    System.Console.WriteLine("                                             |                         |                         |");
    System.Console.WriteLine("                                             |                         |                         |");
    System.Console.WriteLine("                                             |                         |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                             |                         |");
    System.Console.WriteLine("                                         ----------------------------------");
    System.Console.WriteLine("                                         |                                |");
    System.Console.WriteLine("                                         |                                |");
    System.Console.WriteLine("                                         |             [CLOSED]           |");
    System.Console.WriteLine("                                         |                                |");
    System.Console.WriteLine("                                         |                                |");
    System.Console.WriteLine("                                         ----------------------------------");



      
}







Customer customerSugar = new Customer();
customerSugar.SetPreference(CUSTOMER_PREFERENCE_1Sugar);

Customer customerCaffeine = new Customer();
customerCaffeine.SetPreference(CUSTOMER_PREFERENCE_2Caffeine);

Customer customerAddictiveness = new Customer();
customerAddictiveness.SetPreference(CUSTOMER_PREFERENCE_3Addictiveness);



static void Purchases (ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, ref int customersThatPurchased, ref int sugarCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, ref int caffeineCustomersThatStoppedBy, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness)
{
    if(CUSTOMER_PREFERENCE_1Sugar == sugarLevel)
    {
        customersThatPurchased += sugarCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 1 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel -1)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy*.75);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel -2)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy*.50);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel -3)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy*.40);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 4|| CUSTOMER_PREFERENCE_1Sugar == sugarLevel -4)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy*.20);
    }

    //CAFFEINE
    if(CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel)
    {
        customersThatPurchased += caffeineCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 1 ||CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel-1)
    {    
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy*.75);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel+ 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel  -2)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy*.50);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 3 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel -3)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy*.40);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel+ 4|| CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel -4)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy*.20);
    }

    //Addictiveness

    if(CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel)
    {
        customersThatPurchased += addictivenessCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 1 ||CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel-1)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy*.75);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel+ 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel -2)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy*.50);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel-3)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy*.40);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 4|| CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel -4)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy*.20);
    }

}

static void Feedback(ref int sugarCustomersThatStoppedBy, ref int caffeineCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, ref int customersThatPurchased, ref int dayNum, ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness)
{
    int totalCustomers = sugarCustomersThatStoppedBy + caffeineCustomersThatStoppedBy + addictivenessCustomersThatStoppedBy;
    System.Console.WriteLine(" 0000000000000000000000000000000000");
    System.Console.WriteLine("0          Pear Phone (&)          0");
    System.Console.WriteLine("0  ------------------------------  0");
    System.Console.WriteLine("0              DAY " + dayNum + "               0");
    System.Console.WriteLine("0                                  0");  
    System.Console.WriteLine("0 Total Customers ------------ " + totalCustomers + "  0");
    System.Console.WriteLine("0 Total Energy Drinks Sold ---- " + customersThatPurchased + " 0");
    System.Console.WriteLine("0  ------------------------------  0");
    System.Console.WriteLine("0                                  0");
    System.Console.WriteLine("0             YELP Reviews         0");
    System.Console.WriteLine("0 *******************************  0");

    FeedbackOptions(ref sugarLevel, ref caffeineLevel,ref addictivenessLevel, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
    customersThatPurchased = 0;
    Console.WriteLine("Press any key to begin the game");
    Console.ReadKey();
}


static void FeedbackOptions(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness)
{
    //Sugar feedback logic
    if(CUSTOMER_PREFERENCE_1Sugar == sugarLevel)
    {
        System.Console.WriteLine("0  SweetTooth:                     0");
        System.Console.WriteLine("0       ' This is so perfectly     0");
        System.Console.WriteLine("0         flavored!I'm in love<3 ' 0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 1 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel -1)
    {
        System.Console.WriteLine("0  SugarHighGuy:                   0");
        System.Console.WriteLine("0       ' Something about this     0");
        System.Console.WriteLine("0         drink was so close, then 0");
        System.Console.WriteLine("0         it just misses :( The    0");
        System.Console.WriteLine("0         sweetness seems off '    0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel + 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel +3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 4)
    {
        System.Console.WriteLine("0  Sugar!YesPlease!:               0");
        System.Console.WriteLine("0       ' I paid money for this? I 0");
        System.Console.WriteLine("0         could've just bought a   0");
        System.Console.WriteLine("0         cheap bag of sugar x_X '  0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar== sugarLevel - 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel -3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 4)
    {
        System.Console.WriteLine("0  SweetVictory:                   0");
        System.Console.WriteLine("0       ' Is this what they        0");
        System.Console.WriteLine("0         calling a energy drink   0");
        System.Console.WriteLine("0         now?? Tastes just like   0");
        System.Console.WriteLine("0         stale water '            0");
        System.Console.WriteLine("0                                  0");
    }


    //CAFFEINE

    if(CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel)
    {
        System.Console.WriteLine("0  GotCaffeine:                    0");
        System.Console.WriteLine("0       ' I feel so energized!     0");
        System.Console.WriteLine("0         I will be back! :) '     0");
        System.Console.WriteLine("0                                  0");
     }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 1 ||CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel-1)
    {    
        System.Console.WriteLine("0  TripleShot:                     0");
        System.Console.WriteLine("0       ' You know that itch that  0");
        System.Console.WriteLine("0         is just out of reach?    0");
        System.Console.WriteLine("0         Thats what this drink    0");
        System.Console.WriteLine("0         just gave me '           0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel  - 3|| CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 4)
    {
        System.Console.WriteLine("0  DailyGrind:                     0");
        System.Console.WriteLine("0       ' I still feel ded inside  0");
        System.Console.WriteLine("0         -_- Is it too late to    0");
        System.Console.WriteLine("0         go back to bed? '        0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 4)
    {
        System.Console.WriteLine("0  JitterBug:                      0");
        System.Console.WriteLine("0       ' I can't stop shaking!    0");
        System.Console.WriteLine("0         Is this normal? '        0");
        System.Console.WriteLine("0                                  0");
    }


    //ADDICTIVENESS

    if(CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel)
    {
        System.Console.WriteLine("0   AddicTED:                      0"); 
        System.Console.WriteLine("0        'I wanna keep coming back 0");
        System.Console.WriteLine("0         and back... in a         0");
        System.Console.WriteLine("0         completely healthy way   0");
        System.Console.WriteLine("0         heh heh '                    0");
        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *******************************  0");
        System.Console.WriteLine("0           ````````````           0");
        System.Console.WriteLine("0          -   RECEIPT    -        0");
        System.Console.WriteLine("0           ------------           0");
        System.Console.WriteLine("  0000000000000000000000000000000");
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 1 ||CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel-1)
    {
        System.Console.WriteLine("0   GottaHaveIt:                   0"); 
        System.Console.WriteLine("0       ' Theres a little voice    0");
        System.Console.WriteLine("0         inside my hed that's     0");
        System.Console.WriteLine("0         telling me to go back!   0");
        System.Console.WriteLine("0         I'm gonna ignore it      0");
        System.Console.WriteLine("0         this time :) '           0");


        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *******************************  0");
        System.Console.WriteLine("0           ````````````           0");
        System.Console.WriteLine("0          -   RECEIPT    -        0");
        System.Console.WriteLine("0           ------------           0");
        System.Console.WriteLine("  0000000000000000000000000000000");
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 4 )
    {
        System.Console.WriteLine("0   BabyIGotIT:                    0"); 
        System.Console.WriteLine("0       ' Obsessed? Me? Never? But 0");
        System.Console.WriteLine("0         my bank cut my card off  0");
        System.Console.WriteLine("0         so I can't come back:( ' 0");
        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *******************************  0");
        System.Console.WriteLine("0           ````````````           0");
        System.Console.WriteLine("0          -   RECEIPT    -        0");
        System.Console.WriteLine("0           ------------           0");
        System.Console.WriteLine("  0000000000000000000000000000000");
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 4 )
    {
        System.Console.WriteLine("0   RedbullWarrior:                0"); 
        System.Console.WriteLine("0       ' There is nothing special 0");
        System.Console.WriteLine("0         about this drink! One    0");
        System.Console.WriteLine("0         time was enough.Where's  0");
        System.Console.WriteLine("0         my redbull?? '           0");
        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *******************************  0");
        System.Console.WriteLine("0           ````````````           0");
        System.Console.WriteLine("0          -   RECEIPT    -        0");
        System.Console.WriteLine("0           ------------           0");
        System.Console.WriteLine("  0000000000000000000000000000000");
    }
}