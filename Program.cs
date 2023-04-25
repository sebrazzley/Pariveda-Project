// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Threading;
using System;
using Pariveda_Project;
//MAIN

//creation of variables
int customersThatPurchased = 0;
int totalCustomersThatPurchased = 0;
int totalCustomersThatStoppedBy = 0;
int sugarLevel = 1;
int caffeineLevel = 1;
int addictivenessLevel = 1;
int dayNum = 1;
int cupsNum = 0;
int money = 100;

//generates random preferences for customers each time you play game
Random rnd1 = new Random();
int CUSTOMER_PREFERENCE_1Sugar = rnd1.Next(1, 6);
int CUSTOMER_PREFERENCE_2Caffeine = rnd1.Next(1, 6);
int CUSTOMER_PREFERENCE_3Addictiveness = rnd1.Next(1, 6);

Random rnd = new Random();
int sugarCustomersThatStoppedBy = rnd.Next(10, 16);
int caffeineCustomersThatStoppedBy = rnd.Next(10, 16);
int addictivenessCustomersThatStoppedBy = rnd.Next(10, 16);

string userInput = GetMenuChoice();

while (userInput != "3")
{
    Route(userInput, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref dayNum, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness, ref totalCustomersThatPurchased, ref totalCustomersThatStoppedBy, ref cupsNum, ref money);
    userInput = GetMenuChoice();

}




//END MAIN
//Menu

//retrieves menu choice and error checks for valid menu choice selection
static string GetMenuChoice()
{
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

//displays the menu
static void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("1:   Play UA Energy");
    Console.WriteLine("2:   Rules & Instructions");
    Console.WriteLine("3:   Exit Game");
}

//Checks for valid menu choice
static bool ValidMenuChoice(string userInput)
{

    if (userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    else
        return false;
}


//runs menu options
static void Route(string userInput, ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, ref int customersThatPurchased, ref int sugarCustomersThatStoppedBy, ref int dayNum, ref int caffeineCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness, ref int totalCustomersThatPurchased, ref int totalCustomersThatStoppedBy, ref int cupsNum, ref int money)
{
    if (userInput == "1")
    {
        WelcomeMessage();
        Console.Clear();
        EnergyDrinkSettings(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref cupsNum, ref money);
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
        Purchases(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness, ref totalCustomersThatPurchased, ref totalCustomersThatStoppedBy, ref cupsNum, ref money);
        Thread.Sleep(800);
        Console.Clear();
        Feedback(ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, ref customersThatPurchased, ref dayNum, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness, ref cupsNum, ref money);
        dayNum++;

        while (dayNum != 6)
        {
            Random rnd = new Random();
            sugarCustomersThatStoppedBy = rnd.Next(10, 16);
            caffeineCustomersThatStoppedBy = rnd.Next(10, 16);
            addictivenessCustomersThatStoppedBy = rnd.Next(10, 16);
            EnergyDrinkSettings(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref cupsNum, ref money);
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
            Purchases(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref customersThatPurchased, ref sugarCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness, ref totalCustomersThatPurchased, ref totalCustomersThatStoppedBy, ref cupsNum, ref money);
            Thread.Sleep(800);
            Console.Clear();
            Feedback(ref sugarCustomersThatStoppedBy, ref caffeineCustomersThatStoppedBy, ref addictivenessCustomersThatStoppedBy, ref customersThatPurchased, ref dayNum, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness, ref cupsNum, ref money);
            dayNum++;
        }
        GameResults(ref totalCustomersThatPurchased, ref totalCustomersThatStoppedBy, ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, ref dayNum, ref money);



    }
    else if (userInput == "2")
    {
        Instructions();
    }
}

//RunGame

//welcome message
static void WelcomeMessage()
{
    System.Console.WriteLine("                                    Welcome to UA Energy!");
    System.Console.WriteLine("");
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
    System.Console.WriteLine("");
    System.Console.WriteLine("");
    Console.WriteLine("                                      PRESS ANY KEY TO BEGIN THE GAME");
    Console.ReadKey();
}

//displays instructions
static void Instructions()
{
    System.Console.WriteLine("Welcome to UA Energy");
    System.Console.WriteLine("");
    System.Console.WriteLine("About Game:");
    System.Console.WriteLine("             UA Energy is an energy drink tycoon game. You will have 5 days to create the");
    System.Console.WriteLine("             the best energy drink UA has every seen! The goal is to sell as many drinks and make as ");
    System.Console.WriteLine("             much money as you can. Its finals week and they are depending on you! Best of luck!");
    System.Console.WriteLine("");
    System.Console.WriteLine("");
    System.Console.WriteLine("Instructions: ");
    System.Console.WriteLine("              Create and sell a $5 energy drink with 3 components: sugar, caffeine, and addictiveness");
    System.Console.WriteLine("              At the start of each day, you will be able to change the level of each of ");
    System.Console.WriteLine("              these ingredients. You can change it on a scale of 1 to 5. 1 being the");
    System.Console.WriteLine("              least amount of this product. Listen to customer feedback and tailor your");
    System.Console.WriteLine("              drink until it's perfect! Also, you have to buy cup inventory. If you run out of cups, ");
    System.Console.WriteLine("              that is a missed opportunity to sell your drink that day! Make sure you keep an eye on");
    System.Console.WriteLine("              your cup inventory!");


    Console.WriteLine("Press any key to return to the menu");
    Console.ReadKey();


}

//allows user to change drink recipe and error checks for correct input
static void EnergyDrinkSettings(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, ref int cupNum, ref int money)
{
    string userInput = "";

    int yes = -1;

    System.Console.WriteLine("");
    System.Console.WriteLine("* *");
    System.Console.WriteLine("Sugar Content");
    System.Console.WriteLine("         ---    ---    ---    ---    ---");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("        | 1 |  | 2 |  | 3 |  | 4 |  | 5 |");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("         ---    ---    ---    ---    --- ");
    System.Console.WriteLine("");
    System.Console.WriteLine("                               Current Sugar Level: " + sugarLevel);
    System.Console.WriteLine("");
    System.Console.WriteLine("Please enter your desired sugar level");

    //checks for correct input
    while (yes == -1)
    {
        userInput = System.Console.ReadLine();
        if (int.TryParse(userInput, out int sugarLevelTemp))
        {
            if (sugarLevelTemp >= 1 && sugarLevelTemp <= 5)
            {
                sugarLevel = sugarLevelTemp;
                System.Console.WriteLine("");
                System.Console.WriteLine("                               Updated Current Sugar Level " + sugarLevel);
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                yes = 1;
            }
            else
            {
                yes = -1;
                System.Console.WriteLine("Invalid input, try again!");
            }


        }
        else
        {
            System.Console.WriteLine("Invalid input, try again!");
            userInput = System.Console.ReadLine();
        }
    }
    yes = -1;





    System.Console.WriteLine("* *");
    System.Console.WriteLine("Caffeine Content");
    System.Console.WriteLine("         ---    ---    ---    ---    ---");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("        | 1 |  | 2 |  | 3 |  | 4 |  | 5 |");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("         ---    ---    ---    ---    --- ");
    System.Console.WriteLine("");
    System.Console.WriteLine("                               Current Caffeine Level: " + caffeineLevel);
    System.Console.WriteLine("");
    System.Console.WriteLine("Please enter your desired caffeine level");

    //checks for correct input
    while (yes == -1)
    {
        userInput = System.Console.ReadLine();
        if (int.TryParse(userInput, out int caffeineLevelTemp))
        {
            if (caffeineLevelTemp >= 1 && caffeineLevelTemp <= 5)
            {
                caffeineLevel = caffeineLevelTemp;
                System.Console.WriteLine("");
                System.Console.WriteLine("                               Updated Current Caffeine Level " + caffeineLevel);
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                yes = 1;
            }
            else
            {
                yes = -1;
                System.Console.WriteLine("Invalid input, try again!");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid input, try again!");
            userInput = System.Console.ReadLine();
        }
    }
    yes = -1;

    System.Console.WriteLine("* *");
    System.Console.WriteLine("   Addictiveness Content");
    System.Console.WriteLine("         ---    ---    ---    ---    ---");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("        | 1 |  | 2 |  | 3 |  | 4 |  | 5 |");
    System.Console.WriteLine("        |   |  |   |  |   |  |   |  |   |");
    System.Console.WriteLine("         ---    ---    ---    ---    --- ");
    System.Console.WriteLine("");
    System.Console.WriteLine("                               Current addictiveness Level: " + addictivenessLevel);
    System.Console.WriteLine("");
    System.Console.WriteLine("Please enter your desired addictiveness level");

    //checks for correct data input

    while (yes == -1)
    {
        userInput = System.Console.ReadLine();
        if (int.TryParse(userInput, out int addictivenessLevelTemp))
        {
            if (addictivenessLevelTemp >= 1 && addictivenessLevelTemp <= 5)
            {
                addictivenessLevel = addictivenessLevelTemp;
                System.Console.WriteLine("");
                System.Console.WriteLine("                               Updated Current Addictiveness Level " + addictivenessLevel);
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                yes = 1;
            }
            else
            {
                yes = -1;
                System.Console.WriteLine("Invalid input, try again!");
            }

        }
        else
        {
            System.Console.WriteLine("Invalid input, try again!");
            userInput = System.Console.ReadLine();
        }
    }
    yes = -1;

    System.Console.WriteLine("* *");
    System.Console.WriteLine("   Price of cups: 2 Dollars");
    System.Console.WriteLine("");
    System.Console.WriteLine("                               Current money: $" + money + " dollars");
    System.Console.WriteLine("                               Current cup inventory: " + cupNum);
    System.Console.WriteLine("");
    System.Console.WriteLine("How many cups would you like to buy?");

    //checks for correct data input

    while (yes == -1)
    {
        userInput = System.Console.ReadLine();
        if (int.TryParse(userInput, out int cupNumTemp))
        {
            if (cupNumTemp >= 0 && !(cupNumTemp * 2 > money))
            {
                money = money - cupNumTemp * 2;
                cupNum += cupNumTemp;
                System.Console.WriteLine("");
                System.Console.WriteLine("                               Current money: $" + money);
                System.Console.WriteLine("                               You have " + cupNum + " cups available!");
                System.Console.WriteLine("");
                System.Console.WriteLine("");
                yes = 1;

            }
            else if (!(cupNumTemp >= 0))
            {
                yes = -1;
                System.Console.WriteLine("Invalid input, try again!");
            }
            else if ((cupNumTemp * 2 > money))
            {
                yes = -1;
                System.Console.WriteLine("Not enough money! Try again");
            }

        }
        else
        {
            System.Console.WriteLine("Invalid input, try again!");
            userInput = System.Console.ReadLine();
        }
    }
    System.Console.WriteLine("");
    System.Console.WriteLine("");

    CupPour(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel);


    Console.WriteLine("Press any key to start the day");
    Console.ReadKey();




}

//DiplayStandOpen1-5 is animation to simulate customers attending your shop
static void DisplayStandOpen1()
{
    System.Console.WriteLine("                                                                -----------------------------------");
    System.Console.WriteLine("                                                                |                 _______         |");
    System.Console.WriteLine("                                                                |                /      /         |");
    System.Console.WriteLine("                                                                |               /      /          |");
    System.Console.WriteLine("                                                                |              /      /__         |");
    System.Console.WriteLine("                                                                |             /__       /         |");
    System.Console.WriteLine("                                                                |               /     /           |");
    System.Console.WriteLine("                                                                |              /    /             |");
    System.Console.WriteLine("                                                                |             /   /               |");
    System.Console.WriteLine("                                                                |            /  /                 |");
    System.Console.WriteLine("                                                                |           / /                   |");
    System.Console.WriteLine("                                                                |           /                     |");
    System.Console.WriteLine("                                                                -----------------------------------");
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
    System.Console.WriteLine("                                                       -----------------------------------");
    System.Console.WriteLine("                                                       |                 _______         |");
    System.Console.WriteLine("                                                       |                /      /         |");
    System.Console.WriteLine("                                                       |               /      /          |");
    System.Console.WriteLine("                                                       |              /      /__         |");
    System.Console.WriteLine("                                                       |             /__       /         |");
    System.Console.WriteLine("                                                       |               /     /           |");
    System.Console.WriteLine("                                                       |              /    /             |");
    System.Console.WriteLine("                                                       |             /   /               |");
    System.Console.WriteLine("                                                       |            /  /                 |");
    System.Console.WriteLine("                                                       |           / /                   |");
    System.Console.WriteLine("                                                       |           /                     |");
    System.Console.WriteLine("                                                       -----------------------------------");
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
    System.Console.WriteLine("                                              -----------------------------------");
    System.Console.WriteLine("                                              |                 _______         |");
    System.Console.WriteLine("                                              |                /      /         |");
    System.Console.WriteLine("                                              |               /      /          |");
    System.Console.WriteLine("                                              |              /      /__         |");
    System.Console.WriteLine("                                              |             /__       /         |");
    System.Console.WriteLine("                                              |               /     /           |");
    System.Console.WriteLine("                                              |              /    /             |");
    System.Console.WriteLine("                                              |             /   /               |");
    System.Console.WriteLine("                                              |            /  /                 |");
    System.Console.WriteLine("                                              |           / /                   |");
    System.Console.WriteLine("                                              |           /                     |");
    System.Console.WriteLine("                                              -----------------------------------");
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
    System.Console.WriteLine("                                     -----------------------------------");
    System.Console.WriteLine("                                     |                 _______         |");
    System.Console.WriteLine("                                     |                /      /         |");
    System.Console.WriteLine("                                     |               /      /          |");
    System.Console.WriteLine("                                     |              /      /__         |");
    System.Console.WriteLine("                                     |             /__       /         |");
    System.Console.WriteLine("                                     |               /     /           |");
    System.Console.WriteLine("                                     |              /    /             |");
    System.Console.WriteLine("                                     |             /   /               |");
    System.Console.WriteLine("                                     |            /  /                 |");
    System.Console.WriteLine("                                     |           / /                   |");
    System.Console.WriteLine("                                     |           /                     |");
    System.Console.WriteLine("                                     -----------------------------------");
    System.Console.WriteLine("                                         |                         |");
    System.Console.WriteLine("                                         |                         |");
    System.Console.WriteLine("                                         |                         |");
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
    System.Console.WriteLine("                                                           -----------------------------------");
    System.Console.WriteLine("                                                           |                 _______         |");
    System.Console.WriteLine("                                                           |                /      /         |");
    System.Console.WriteLine("                                                           |               /      /          |");
    System.Console.WriteLine("                                                           |              /      /__         |");
    System.Console.WriteLine("                                                           |             /__       /         |");
    System.Console.WriteLine("                                                           |               /     /           |");
    System.Console.WriteLine("                                                           |              /    /             |");
    System.Console.WriteLine("*******************************************************    |             /   /               |");
    System.Console.WriteLine("*|  ____|         | |        / _| |  __ \\             *    |            /  /                 |");
    System.Console.WriteLine("*| |__   _ __   __| |   ___ | |_  | |  | | __ _ _   _ *    |           / /                   |");
    System.Console.WriteLine("*|  __| | '_ \\ / _` |  / _ \\|  _| | |  | |/ _` | | | |*    |           /                     |");
    System.Console.WriteLine("*| |____| | | | (_| | | (_) | |   | |__| | (_| | |_| |*    -----------------------------------");
    System.Console.WriteLine("*|______|_| |_|\\__,_|  \\___/|_|   |_____/ \\__,_|\\__, |*        |                         |");
    System.Console.WriteLine("*                                                __/ |*        |                         |");
    System.Console.WriteLine("*                                               |___/ *        |                         |");
    System.Console.WriteLine("*********************************************************      |                         |");
    System.Console.WriteLine("                                                               |                         |");
    System.Console.WriteLine("                                                               |                         |");
    System.Console.WriteLine("                                                               |                         |");
    System.Console.WriteLine("                                                               |                         |");
    System.Console.WriteLine("                                                               |                         |");
    System.Console.WriteLine("                                                           ----------------------------------");
    System.Console.WriteLine("                                                           |                                |");
    System.Console.WriteLine("                                                           |                                |");
    System.Console.WriteLine("                                                           |             [CLOSED]           |");
    System.Console.WriteLine("                                                           |                                |");
    System.Console.WriteLine("                                                           |                                |");
    System.Console.WriteLine("                                                           ----------------------------------");









}






//creating customers with their preferences
Customer customerSugar = new Customer();
customerSugar.SetPreference(CUSTOMER_PREFERENCE_1Sugar);

Customer customerCaffeine = new Customer();
customerCaffeine.SetPreference(CUSTOMER_PREFERENCE_2Caffeine);

Customer customerAddictiveness = new Customer();
customerAddictiveness.SetPreference(CUSTOMER_PREFERENCE_3Addictiveness);


//calculates the number of customers that purchased your goods and your money earned
static void Purchases(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, ref int customersThatPurchased, ref int sugarCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, ref int caffeineCustomersThatStoppedBy, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness, ref int totalCustomersThatPurchased, ref int totalCustomersThatStoppedBy, ref int cupNum, ref int money)
{
    if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel)
    {
        customersThatPurchased += sugarCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 1 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 1)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy * .75);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 2)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy * .50);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 3)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy * .40);
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 4 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 4)
    {
        customersThatPurchased += (int)(sugarCustomersThatStoppedBy * .20);
    }

    //CAFFEINE
    if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel)
    {
        customersThatPurchased += caffeineCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 1 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 1)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy * .75);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 2)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy * .50);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 3 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 3)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy * .40);
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 4 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 4)
    {
        customersThatPurchased += (int)(caffeineCustomersThatStoppedBy * .20);
    }

    //Addictiveness

    if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel)
    {
        customersThatPurchased += addictivenessCustomersThatStoppedBy;
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 1 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 1)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy * .75);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 2)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy * .50);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 3)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy * .40);
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 4 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 4)
    {
        customersThatPurchased += (int)(addictivenessCustomersThatStoppedBy * .20);
    }


    if (cupNum - customersThatPurchased < 0)
    {
        customersThatPurchased = cupNum;
        cupNum = 0;
        money = money + (5 * customersThatPurchased);
    }
    else
    {
        cupNum = cupNum - customersThatPurchased;
        money = money + (5 * customersThatPurchased);
    }

    totalCustomersThatPurchased += customersThatPurchased;
    totalCustomersThatStoppedBy += sugarCustomersThatStoppedBy + caffeineCustomersThatStoppedBy + addictivenessCustomersThatStoppedBy;

}

//displays recept feedback
static void Feedback(ref int sugarCustomersThatStoppedBy, ref int caffeineCustomersThatStoppedBy, ref int addictivenessCustomersThatStoppedBy, ref int customersThatPurchased, ref int dayNum, ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness, ref int cupNum, ref int money)
{
    int totalCustomers = sugarCustomersThatStoppedBy + caffeineCustomersThatStoppedBy + addictivenessCustomersThatStoppedBy;
    System.Console.WriteLine(" 0000000000000000000000000000000000");
    System.Console.WriteLine("0          Pear Phone (&)          0");
    System.Console.WriteLine("0  ------------------------------  0");
    System.Console.WriteLine("0              DAY " + dayNum + "               0");
    System.Console.WriteLine("0                                  0");
    System.Console.WriteLine("0 Total Customers ------------ " + totalCustomers + "  0");
    System.Console.WriteLine("0 Total Energy Drinks Sold ---- " + customersThatPurchased + "  0");
    System.Console.WriteLine("0 Money Earned: $" + money + "                0");

    if (cupNum - customersThatPurchased < 0)
    {
        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *** You ran out of cups ***      0");
        System.Console.WriteLine("0                                  0");
    }

    System.Console.WriteLine("0  ------------------------------  0");
    System.Console.WriteLine("0                                  0");
    System.Console.WriteLine("0             YELP Reviews         0");
    System.Console.WriteLine("0 *******************************  0");

    FeedbackOptions(ref sugarLevel, ref caffeineLevel, ref addictivenessLevel, CUSTOMER_PREFERENCE_1Sugar, CUSTOMER_PREFERENCE_2Caffeine, CUSTOMER_PREFERENCE_3Addictiveness);
    customersThatPurchased = 0;
    Console.WriteLine("Press any key to start the day");
    Console.ReadKey();
}

//determines what feedback will be shown
static void FeedbackOptions(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, int CUSTOMER_PREFERENCE_1Sugar, int CUSTOMER_PREFERENCE_2Caffeine, int CUSTOMER_PREFERENCE_3Addictiveness)
{
    //Sugar feedback logic
    if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel)
    {
        System.Console.WriteLine("0  SweetTooth:                     0");
        System.Console.WriteLine("0       ' This is so perfectly     0");
        System.Console.WriteLine("0         flavored!I'm in love<3 ' 0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 1 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 1)
    {
        System.Console.WriteLine("0  SugarHighGuy:                   0");
        System.Console.WriteLine("0       ' Something about this     0");
        System.Console.WriteLine("0         drink was so close, then 0");
        System.Console.WriteLine("0         it just misses :( The    0");
        System.Console.WriteLine("0         sweetness seems off '    0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 4)
    {
        System.Console.WriteLine("0  SweetVictory:                   0");
        System.Console.WriteLine("0       ' Is this what they        0");
        System.Console.WriteLine("0         calling a energy drink   0");
        System.Console.WriteLine("0         now?? Tastes just like   0");
        System.Console.WriteLine("0         stale water '            0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 2 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 4)
    {
        System.Console.WriteLine("0  Sugar!YesPlease!:               0");
        System.Console.WriteLine("0       ' I paid money for this? I 0");
        System.Console.WriteLine("0         could've just bought a   0");
        System.Console.WriteLine("0         cheap bag of sugar x_X ' 0");
        System.Console.WriteLine("0                                  0");
    }


    //CAFFEINE

    if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel)
    {
        System.Console.WriteLine("0  GotCaffeine:                    0");
        System.Console.WriteLine("0       ' I feel so energized!     0");
        System.Console.WriteLine("0         I will be back! :) '     0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 1 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 1)
    {
        System.Console.WriteLine("0  TripleShot:                     0");
        System.Console.WriteLine("0       ' You know that itch that  0");
        System.Console.WriteLine("0         is just out of reach?    0");
        System.Console.WriteLine("0         Thats what this drink    0");
        System.Console.WriteLine("0         just gave me '           0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel - 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel - 4)
    {
        System.Console.WriteLine("0  JitterBug:                      0");
        System.Console.WriteLine("0       ' I can't stop shaking!    0");
        System.Console.WriteLine("0         Is this normal? '        0");
        System.Console.WriteLine("0                                  0");
    }
    else if (CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 2 || CUSTOMER_PREFERENCE_2Caffeine == caffeineLevel + 3 || CUSTOMER_PREFERENCE_1Sugar == sugarLevel + 4)
    {

        System.Console.WriteLine("0  DailyGrind:                     0");
        System.Console.WriteLine("0       ' I still feel ded inside  0");
        System.Console.WriteLine("0         -_- Is it too late to    0");
        System.Console.WriteLine("0         go back to bed? '        0");
        System.Console.WriteLine("0                                  0");
    }


    //ADDICTIVENESS

    if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel)
    {
        System.Console.WriteLine("0   AddicTED:                      0");
        System.Console.WriteLine("0        'I wanna keep coming back 0");
        System.Console.WriteLine("0         and back... in a         0");
        System.Console.WriteLine("0         completely healthy way   0");
        System.Console.WriteLine("0         heh heh '                0");
        System.Console.WriteLine("0                                  0");
        System.Console.WriteLine("0 *******************************  0");
        System.Console.WriteLine("0           ````````````           0");
        System.Console.WriteLine("0          -   RECEIPT    -        0");
        System.Console.WriteLine("0           ------------           0");
        System.Console.WriteLine("  0000000000000000000000000000000");
    }
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 1 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 1)
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
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel + 4)
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
    else if (CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 2 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 3 || CUSTOMER_PREFERENCE_3Addictiveness == addictivenessLevel - 4)
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

}

//shows your overall game stats
static void GameResults(ref int totalCustomersThatPurchased, ref int totalCustomersThatStoppedBy, ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel, ref int dayNum, ref int money)
{
    string score;
    System.Console.WriteLine("-You made " + money + " dollars");
    System.Console.WriteLine("");
    System.Console.WriteLine("-You saw a total of " + totalCustomersThatStoppedBy + " customers that stopped by your shop");
    System.Console.WriteLine("");
    System.Console.WriteLine("-Of these, you were able to sell your energy drink to " + totalCustomersThatPurchased + " customers");
    System.Console.WriteLine("");

    //score calculation

    if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 97)
        score = "A+";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 93)
        score = "A";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 90)
        score = "A-";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 87)
        score = "B+";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 83)
        score = "B";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 80)
        score = "B-";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 77)
        score = "C+";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 73)
        score = "C";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 70)
        score = "C-";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 67)
        score = "D+";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 63)
        score = "D";
    else if ((totalCustomersThatPurchased / (double)(totalCustomersThatStoppedBy)) * 100 >= 60)
        score = "D-";
    else
        score = "F";

    System.Console.WriteLine("      Game score: " + score);
    System.Console.WriteLine("");
    System.Console.WriteLine("     Thanks for playing! ");

    //resets level for new game
    sugarLevel = 1;
    caffeineLevel = 1;
    addictivenessLevel = 1;
    dayNum = 1;

    Console.WriteLine("Press any key to return to the menu");
    Console.ReadKey();
}

static void CupPour(ref int sugarLevel, ref int caffeineLevel, ref int addictivenessLevel)
{
        System.Console.WriteLine("     -----------------------------------------------");
        System.Console.WriteLine("        GETTING READY TO POUR IN NEW INGREDIENTS...");
        System.Console.WriteLine("     -----------------------------------------------");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
        Thread.Sleep(2000);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("                                * * *** * ");
        System.Console.WriteLine("                                  **** *");
        System.Console.WriteLine(""); 
        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("                                * * *** * ");
        System.Console.WriteLine("                                  **** *");
        System.Console.WriteLine("");
        System.Console.WriteLine("");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

 
        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("                                * * *** * ");
        System.Console.WriteLine("                                  **** *");
        System.Console.WriteLine("");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("                                * * *** * ");
        System.Console.WriteLine("                                  **** *");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("                                * * *** * ");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

       System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("                            ** ***  * *    *");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("                          **   * * ** *   **  ");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("                           * *  * ** * ** ");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("                          *  ** * * * * * * *");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);
        Thread.Sleep(600);
        Console.Clear();

        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("&                       Your New Energy Drink                      &");
        System.Console.WriteLine(" &                                                                &");
        System.Console.WriteLine("  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        System.Console.WriteLine("  &                                                              &");
        cupAddict(ref addictivenessLevel);
        CupSugar(ref sugarLevel);
        cupCaff(ref caffeineLevel);

}



static void cupAddict(ref int addictivenessLevel)
{
    if (addictivenessLevel == 1)
    {
        System.Console.WriteLine("   &                                                            &");
        System.Console.WriteLine("    &                             1                            &");
        System.Console.WriteLine("     &      __    __   __  ____   __ _____ ____ _     _ ___   & ");
        System.Console.WriteLine("      &    /__\\  |  \\ |  \\   |   |     |     |   \\   /  |_   &   ");
        System.Console.WriteLine("       &  /    \\ |__/ |__/ __|__ |__   |   __|__  \\_/   |__ &      ");
        System.Console.WriteLine("        &                                                  &");
    }
    else if (addictivenessLevel == 2)
    {
        System.Console.WriteLine("   &                                                            &");
        System.Console.WriteLine("    &                             2                            &");
        System.Console.WriteLine("     &      __    __   __  ____   __ _____ ____ _     _ ___   & ");
        System.Console.WriteLine("      &    /__\\  |  \\ |  \\   |   |     |     |   \\   /  |_   &   ");
        System.Console.WriteLine("       &  /    \\ |__/ |__/ __|__ |__   |   __|__  \\_/   |__ &      ");
        System.Console.WriteLine("        &                                                  &");
    }
    else if (addictivenessLevel == 3)
    {
        System.Console.WriteLine("   &                                                            &");
        System.Console.WriteLine("    &                             3                            &");
        System.Console.WriteLine("     &      __    __   __  ____   __ _____ ____ _     _ ___   & ");
        System.Console.WriteLine("      &    /__\\  |  \\ |  \\   |   |     |     |   \\   /  |_   &   ");
        System.Console.WriteLine("       &  /    \\ |__/ |__/ __|__ |__   |   __|__  \\_/   |__ &      ");
        System.Console.WriteLine("        &                                                  &");
    }
    else if (addictivenessLevel == 4)
    {
        System.Console.WriteLine("   &                                                            &");
        System.Console.WriteLine("    &                             4                            &");
        System.Console.WriteLine("     &      __    __   __  ____   __ _____ ____ _     _ ___   & ");
        System.Console.WriteLine("      &    /__\\  |  \\ |  \\   |   |     |     |   \\   /  |_   &   ");
        System.Console.WriteLine("       &  /    \\ |__/ |__/ __|__ |__   |   __|__  \\_/   |__ &      ");
        System.Console.WriteLine("        &                                                  &");
    }
    else if (addictivenessLevel == 5)
    {
        System.Console.WriteLine("   &                                                            &");
        System.Console.WriteLine("    &                             5                            &");
        System.Console.WriteLine("     &      __    __   __  ____   __ _____ ____ _     _ ___   & ");
        System.Console.WriteLine("      &    /__\\  |  \\ |  \\   |   |     |     |   \\   /  |_   &   ");
        System.Console.WriteLine("       &  /    \\ |__/ |__/ __|__ |__   |   __|__  \\_/   |__ &      ");
        System.Console.WriteLine("        &                                                  &");
    }

}

static void CupSugar(ref int sugarLevel)
{
    if (sugarLevel == 1)
    {
        System.Console.WriteLine("         &                        1                       &");
        System.Console.WriteLine("          &           ___          ____    __   ___      &     ");
        System.Console.WriteLine("           &          |__   |   |  | __   / _\\  |__|    &      ");
        System.Console.WriteLine("            &         ___|  |___|  |___| /    \\ |  \\   &");
        System.Console.WriteLine("             &                                        &");
    }

    else if (sugarLevel == 2)
    {
        System.Console.WriteLine("         &                        2                       &");
        System.Console.WriteLine("          &           ___          ____    __   ___      &     ");
        System.Console.WriteLine("           &          |__   |   |  | __   / _\\  |__|     &      ");
        System.Console.WriteLine("            &         ___|  |___|  |___| /    \\ |  \\   &");
        System.Console.WriteLine("             &                                        &");
    }

    else if (sugarLevel == 3)
    {
        System.Console.WriteLine("         &                        3                       &");
        System.Console.WriteLine("          &           ___          ____    __   ___      &     ");
        System.Console.WriteLine("           &          |__   |   |  | __   / _\\  |__|    &      ");
        System.Console.WriteLine("            &         ___|  |___|  |___| /    \\ |  \\   &");
        System.Console.WriteLine("             &                                        &");
    }
    else if (sugarLevel == 4)
    {
        System.Console.WriteLine("         &                        4                       &");
        System.Console.WriteLine("          &           ___          ____    __   ___      &     ");
        System.Console.WriteLine("           &          |__   |   |  | __   / _\\  |__|    &      ");
        System.Console.WriteLine("            &         ___|  |___|  |___| /    \\ |  \\   &");
        System.Console.WriteLine("             &                                        &");
    }
    else if (sugarLevel == 5)
    {
        System.Console.WriteLine("         &                        5                       &");
        System.Console.WriteLine("          &           ___          ____    __   ___      &     ");
        System.Console.WriteLine("           &          |__   |   |  | __   / _\\  |__|    &      ");
        System.Console.WriteLine("            &         ___|  |___|  |___| /    \\ |  \\   &");
        System.Console.WriteLine("             &                                        &");
    }
}



static void cupCaff(ref int caffeineLevel)
{
    if (caffeineLevel == 1)
    {
        System.Console.WriteLine("              &                    1                 & ");
        System.Console.WriteLine("               &        ____    __   ____ ____      &    ");
        System.Console.WriteLine("                &       |      /__\\  |__  |__      &");
        System.Console.WriteLine("                 &      |____ /    \\ |    |       &");
        System.Console.WriteLine("                  &                              &");
        System.Console.WriteLine("                  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
    }
    else if (caffeineLevel == 2)
    {
        System.Console.WriteLine("              &                    2                 & ");
        System.Console.WriteLine("               &        ____    __   ____ ____      &    ");
        System.Console.WriteLine("                &       |      /__\\  |__  |__      &");
        System.Console.WriteLine("                 &      |____ /    \\ |    |       &");
        System.Console.WriteLine("                  &                              &");
        System.Console.WriteLine("                  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
    }
    else if (caffeineLevel == 3)
    {
        System.Console.WriteLine("              &                    3                 & ");
        System.Console.WriteLine("               &        ____    __   ____ ____      &    ");
        System.Console.WriteLine("                &       |      /__\\  |__  |__      &");
        System.Console.WriteLine("                 &      |____ /    \\ |    |       &");
        System.Console.WriteLine("                  &                              &");
        System.Console.WriteLine("                  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
    }
    else if (caffeineLevel == 4)
    {
        System.Console.WriteLine("              &                    4                 & ");
        System.Console.WriteLine("               &        ____    __   ____ ____      &    ");
        System.Console.WriteLine("                &       |      /__\\  |__  |__      &");
        System.Console.WriteLine("                 &      |____ /    \\ |    |       &");
        System.Console.WriteLine("                  &                              &");
        System.Console.WriteLine("                  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
    }
    else if (caffeineLevel == 5)
    {
        System.Console.WriteLine("              &                    5                 & ");
        System.Console.WriteLine("               &        ____    __   ____ ____      &    ");
        System.Console.WriteLine("                &       |      /__\\  |__  |__      &");
        System.Console.WriteLine("                 &      |____ /    \\ |    |       &");
        System.Console.WriteLine("                  &                              &");
        System.Console.WriteLine("                  &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
    }
}





