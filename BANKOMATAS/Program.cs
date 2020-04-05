using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKOMATAS
{

    //1. Pasirinkti kalba; LT, EN, RUS
    //2. Pasisveikinti pasirinkta kalba(naudoti Switch)
    //3. Prašome įvesti PIN kodą.Įvedus 3 kartus neteisingai, užblokuoti kortelę. (naudoti ciklą)
    //4. Parodyti meniu:
    //- Keisti kalbą
    //- Keisti PIN kodą (naujas pin kodas turi sutapti su senuoju, tik tada galima įvesti naują.Jis griežtai turi būti sudarytas tik iš skaičiu ir formatu 1234)
    //- Sąskaitos likutis
    //- Sąskaitos išrašas(sąrašas su operacijomis)
    //- Įnešti pinigus(sąskaitos likutis padidėja)
    //- Pasiimti pinigus(sąskaitos likutis sumažėja)
    //- Baigti darbą

    //(stengiamės programa kuo labiau išskaidyti į skirtingus metodus, kurie būtų nepriklausomi, galėtume juos perpanaudoti)
    //(nepamirštame panaudoti Console.Clear())

    //Objektiniam programavimui.

    //- Sukurti klasę Tranzakcija, su laukais: Valiuta, Suma, MokejimoPaskirtis, Data.
    //- Sukurti klasę Klientas, su laukais Vardas, Pavardė, Amzius
    //- Sukurti klase Saskaita, su laukais SaskaitosNumeris, Kortelė , paveldės savybes iš klasės Klientas
    //- Sukurti klasę Kortele, su laukais, KortelesNumeris, CVV, KortelesTipas (tai bus enum: Visa, MasterCard, Revolut), PIN kodas.
    //- Klasėje Kortele, bus metodas, kuris priims pin, jį patikrins ir gražins true arba false. Pin kodas, bus saugomas klasėje Kortele. Jis bus private, todėl jo reikšmes
    //bus galima keisti tik iš klasės ribų.
    //- Klasėje Kortele reikalingas metodas, ChangePIN().
    //- Klaseje Kortele. Tures pinkoda ir metodus pakeisti pin kodui, patikrinti pin koda.
    //- Klase saskaita. Metodai ir nariai susiję su saskaitomis

        // 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Pasirinkite kalba:");
            Console.WriteLine("-------------------");
            Console.WriteLine("1 - Lietuviu kalba LT");
            Console.WriteLine("2 - In English EN");
            Console.WriteLine("3 - По русски RU");
            Console.WriteLine("4 - Auf Deutsch DE");
            string pasirinktaKalba = Console.ReadLine();

            Console.ReadLine();

            switch (pasirinktaKalba)
            {
                case "1":
                    Console.WriteLine("Laba diena LT");
                    break;
                case "2":
                    Console.WriteLine("Good day!");
                    break;

            }
        }
    }
}
