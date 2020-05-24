using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BANKOMATAS_KLASES
{
    class Program
    {

        public static string userLanguage = "0";
        public static string PIN = "1234";
        public static double invoiceBalance = 1006.66;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            languageMenu();

            if (checkPIN(enterPIN()))
            {
                showMainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(" Viršytas bandymų skaičius. Kortele uzblokuota!");
                Console.WriteLine("-----------------------------------------------");
                Console.ReadLine();
            }

        }
        public static string languageMenu() //papildyti patikrinimu ar pasirinkimas teisingas
        {

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine(" Pasirinkite kalbą/ Select your language/ Выбрать язык/ Sprache wählen ");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("           --->         1 - Lietuviškai LT            <---             ");
            Console.WriteLine("           --->         2 - In English EN             <---             ");
            Console.WriteLine("           --->         3 - По русски RU              <---             ");
            Console.WriteLine("           --->         4 - Auf Deutsch DE            <---             ");

            userLanguage = Console.ReadLine();
            Console.Clear();

            switch (userLanguage)
            {
                case "1":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("                Laba diena!                  ");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case "2":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("                Good day!                    ");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case "3":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("                   Привет!                   ");
                    Console.WriteLine("---------------------------------------------");
                    break;
                case "4":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("                 Guten Tag!                  ");
                    Console.WriteLine("---------------------------------------------");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine("           KLAIDA! Pasirinkimas negalimas. Bandykite dar kartą.         ");
                    languageMenu();
                    break;
            }

            return userLanguage;

        }

        static string enterPIN()
        {
            Console.Write(" Įveskite PIN: ");
            return Console.ReadLine();

        }

        static bool checkPIN(string userPIN)
        {
            bool correctPIN = false;
            for (int i = 1; i < 3; i++)
            {
                if (userPIN != PIN)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.WriteLine($" Neteisingas PIN! Bandykite dar kartą. Jums likusių bandymų sk. - {3 - i}.");
                    Console.WriteLine("---------------------------------------------------------------------");
                    Console.Write(" Įveskite PIN: ");
                    userPIN = Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine(" PIN teisingas.");
                    correctPIN = true;
                    break;
                }
            }
            return correctPIN;
        }

        public static void showMainMenu()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" Prašome pasirinkti pageidaujamą operaciją:  ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("    --->  1 - Keisti kalbą          <---     ");
            Console.WriteLine("    --->  2 - Keisti PIN            <---     ");
            Console.WriteLine("    --->  3 - Sąskaitos likutis     <---     ");
            Console.WriteLine("    --->  4 - Sąskaitos išrašas     <---     ");
            Console.WriteLine("    --->  5 - Pinigų išėmimas       <---     ");
            Console.WriteLine("    --->  6 - Sąskaitos papildymas  <---     ");
            Console.WriteLine("    --->  7 - Baigti darbą          <---     ");

            string userMenu = Console.ReadLine();
            switch (userMenu)
            {
                case "1":
                    changeLanguage();
                    break;
                case "2":
                    Console.Clear();
                    changePIN();
                    break;
                case "3":
                    Console.Clear();
                    ShowCurrentBalance();
                    break;
                case "4":
                    Console.Clear();
                    ShowOperations();
                    break;
                case "5":
                    Console.Clear();
                    Cashout();
                    break;
                case "6":
                    Console.Clear();
                    TopUp();
                    break;
                case "7":
                    Console.Clear();
                    FinishIt();
                    break;
            }
        }

        static void changePIN()
        {

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(" PIN KEITIMAS. Nurodykite pirmiausia savo dabartinį PIN.");
            //Console.WriteLine("-------------------------------------------------------");
            if (checkPIN(enterPIN()))
            {
                Console.WriteLine("---------------------------------------------");
                Console.Write(" Įveskite naują PIN: ");
                var newPIN = Console.ReadLine();
                if (newPIN == PIN)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine(" Naujas PIN negali sutapti su senu. Bandykite dar kartą.");
                    changePIN();
                }
                else if (newPIN.Length == 4 && newPIN != PIN)
                {
                    PIN = newPIN;
                    Console.Clear();
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine(" PIN sėkmingai pakeistas.");
                    showPIN();
                }
                else if (newPIN.Length < 4)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine(" Įvestas PIN per trumpas. Bandykite dar kartą.");
                    Console.ReadLine();
                    changePIN();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine(" Įvyko nenumatyta klaida. Bandykite dar karta.");
                    Console.ReadLine();
                    changePIN();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Viršytas bandymų skaičius. Kortele uzblokuota!");
                Console.WriteLine("-----------------------------------------------");
                Console.ReadLine();
            }
        }

        static void showPIN()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Pasirinkite ką norite atlikti toliau:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" --> 1 - Pamatyti pakeistą PIN     <-- ");
            Console.WriteLine(" --> 2 - Pasirinkti kitą operaciją <-- ");
            var userinput = Console.ReadLine();
            if (userinput == "1")
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" Jūsų naujasis PIN: {PIN}");
                Console.WriteLine("---------------------------------------");
                FinishOrContinue();
            }
            else if (userinput == "2")
            {
                Console.Clear();
                showMainMenu();
            }
            else
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" Pasirinkimas neteisingas. Bandykite dar kartą.");
                Console.WriteLine("---------------------------------------------");
                showPIN();
            }
        }

        public static string changeLanguage()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine(" KALBOS KEITIMAS");
            string newLanguage = languageMenu();
            showMainMenu();
            return newLanguage;
        }

        public static void FinishIt()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("    --->  Geros dienos!  <---   ");
            Console.WriteLine("--------------------------------");
            Thread.Sleep(2000);
        }

        public static void FinishOrContinue()
        {

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Pasirinkite ką norite atlikti toliau:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     --> 1 - Kita operacija <--        ");
            Console.WriteLine("     --> 2 - Baigti darbą   <--        ");
            var userInput2 = (Console.ReadLine());
            if (userInput2 == "1")
            {
                Console.Clear();
                if (checkPIN(enterPIN()))
                {
                    showMainMenu();
                }

            }
            else if (userInput2 == "2")
            {
                FinishIt();
            }
            else
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" Pasirinkimas negalimas. Bandykite dar kartą");
                Console.WriteLine("---------------------------------------------");
                FinishOrContinue();
            }
        }

        public static void ShowCurrentBalance()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($" Jūsų sąskaitos likutis: {invoiceBalance} Eur");
            FinishOrContinue();
        }

        public static void ShowOperations()
        {
            List<string> operations = new List<string>();
            operations.Add("2020.03.08, Parduotuvė IKI, -30,00 Eur");
            operations.Add("2020.03.07, Neste Degalinė, -49,99 Eur");
            operations.Add("2020.03.07, Coffee Inn, -2,09 Eur");
            operations.Add("2020.03.06, Restoranas, -22,33 Eur");
            operations.Add("2020.03.06, Parduotuvė Maxima, -0,66 Eur");
            operations.Add("2020.03.05, UAB 'Trys Paršeliai', -20,00 Eur");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" SĄSKAITOS IŠRAŠAS");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Paskutinių 5-ių operacijų sąrašas:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" { operations[i]}");
                Console.WriteLine("---");
            }
            FinishOrContinue();

        }

        public static void Cashout()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(" PINIGŲ IŠĖMIMAS");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(" Galimi pinigų banknotai yra: 10 Eur, 20 Eur, 50 Eur ir 100 Eur");
            Console.Write(" Įveskite pinigų sumą, kurią norite išimti: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            if (cash <= Convert.ToInt32(invoiceBalance) && (cash % 10 == 0 || cash % 20 == 0 || cash % 50 == 0 || cash == 100))
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($" Jūsų išgryninta suma: {cash}Eur.");
                Console.WriteLine(" Prašome paimti pinigus.");
                invoiceBalance = invoiceBalance - cash;
                FinishOrContinue();
            }
            else if (cash > Convert.ToInt32(invoiceBalance))
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine(" Sąskaitos likutis nepakankamas.Nurodykite kitą sumą.");
                Console.WriteLine("---------------------------------------------------------------");
                Cashout();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine(" Neteisingai nurodyta suma. Nurodykite kitą sumą");
                Console.WriteLine("---------------------------------------------------------------");
                Cashout();
            }
        }

        public static void TopUp()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(" PINIGŲ ĮNEŠIMAS");
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("Įdėkite pinigus ir nurodykite sumą: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            invoiceBalance = invoiceBalance + cash;
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($" Jūsų sąskaita papildyta {cash}Eur");
            FinishOrContinue();
        }

    }

}

