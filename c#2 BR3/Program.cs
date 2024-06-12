using System.Globalization;

namespace c_2_BR3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //    string palindrom = "kuna nese nanuk";
            //    char[] charArray = palindrom.ToArray();
            //    Array.Reverse(charArray);
            //    string opacnyPalindrom = new string(charArray);
            //    Console.WriteLine(opacnyPalindrom);


            //    string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

            //    Console.WriteLine("Palindromy v poli jsou:");

            //    foreach (string slovo in slova)
            //    {
            //        if (JePalindrom(slovo))
            //        {
            //            Console.WriteLine(slovo);
            //        }
            //    }
            //}

            //static bool JePalindrom(string slovo)
            //{
            //    // Převrácení slova
            //    char[] charArray = slovo.ToArray();
            //    Array.Reverse(charArray);
            //    string reversedSlovo = new string(charArray);

            //    // Porovnání původního a převráceného slova
            //    return slovo.Equals(reversedSlovo);
            //}

            string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

            char[] charArray = capsLock.ToArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                // Pokud je znak malé písmeno, převeď ho na velké, a naopak
                if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
                else if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }
            Console.WriteLine(charArray);
            //string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
            //char[] sifraArray = sifra.ToArray();

            //for (int i = 0; i < sifraArray.Length; i++)
            //{
            //    // Pro každý znak zjistíme jeho hodnotu Unicode
            //    int hodnotaUnicode = (int)sifraArray[i];

            //    // Pro písmena 'b' až 'z' provedeme posunutí o jedno písmeno doleva
            //    if (hodnotaUnicode > 'A' && hodnotaUnicode <= 'z')
            //    {
            //        sifraArray[i] = (char)(hodnotaUnicode - 1);
            //    }
            //    // Pro písmeno 'a' provedeme speciální posun na 'z'
            //    else if (hodnotaUnicode == 'a')
            //    {
            //        sifraArray[i] = 'z';
            //    }
            //}

            //Console.WriteLine(sifraArray);





        }
        }

    }
