using System;
using System.Security.Principal;
using System.Text;


namespace Anna_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //string char[]
            //1
            //string an = "-Hi!";
            //string na = "-How are u?";

            //string anna = new string(new char[] { 'H', 'e', 'l', 'l', 'o','!' });
            //Console.WriteLine(an);
            //Console.WriteLine(anna);
            //Console.WriteLine(na);

            //Console.WriteLine(an == anna);
            //Console.WriteLine(an[1]);

            //2
            //string first = "Yalla";
            //string second = new string(new char[] { 'Y', 'a', 'l', 'l', 'a' });
            //Console.WriteLine("First=" + first);
            //Console.WriteLine("Second=" + second);
            //Console.WriteLine( first == second);

            //Compare
            //1
            //string one = "Hello";
            //string two = "Hello";
            //string three = "Hi";
            //int returnResult = string.Compare(one, two,three);
            //Console.WriteLine(returnResult);

            //2
            //string one = "Hello";
            //string two = "Hello";
            //int returnResult = string.Compare(one, two);
            //Console.WriteLine(returnResult);

            //Remove
            //string removeString = "Hoduapushches";
            //int yalla = removeString.Length - 2;
            //removeString = removeString.Remove(yalla);
            //Console.WriteLine(removeString);

            //EndsWith
            //    string[] name = new string[]
            //    {
            //        "Gev.org",
            //        "Ang.am",
            //        "Amin.org",
            //        "Zur.org",
            //        "Ann.am"
            //};
            //    for(int i=0;i<name.Length;i++)
            //    {
            //        if (name[i].EndsWith(".org"))
            //        {
            //            Console.WriteLine(name[i]);
            //   }
            //}

            //StartsWith
            //            string[] name = new string[]
            //{
            //                "Gev.org",
            //                "Ang.am",
            //                "Amin.org",
            //                "Zur.org",
            //                "Ann.am"
            //};
            //            for (int i = 0; i < name.Length; i++)
            //            {
            //                if (name[i].StartsWith("A"))
            //                {
            //                    Console.WriteLine(name[i]);
            //                }
            //                else Console.WriteLine("ERROR");
            //            }

            //IndexOf
            //string indexString = "Ho du apush ches??";
            //char yalla = 'd';
            //int charIndex = indexString.IndexOf(yalla);
            //Console.WriteLine(charIndex);

            //Insert
            //string console = "Ho du apush ches";
            //string subConsole = "Always ";

            //console = console.Insert(8, subConsole);
            //Console.WriteLine(console);

            //Join
            //string firstCompany = "Ho du";
            //string secondCompnay = "Apush";
            //string thirdCompany = "Ches";
            //string[] companies = new string[] { firstCompany, secondCompnay, thirdCompany };

            //string allCompanies = string.Join(", ", companies);
            //Console.WriteLine("{0} + {1}", allCompanies, firstCompany);
            //Console.WriteLine($"{allCompanies} + {firstCompany}");

            //Replace
            //string fullText = "du apush ches";
            //string replacedString = "es";

            //fullText = fullText.Replace("ches", "es");
            //Console.WriteLine(fullText);

            ////ToLower, ToUpper
            //string Ejmiatsin = "Ejmiatsin";

            //Console.WriteLine(Ejmiatsin.ToLower());
            //Console.WriteLine(Ejmiatsin.ToUpper());


            ////Trim
            //string countryCapital = " Armenia Yerevan ";
            //countryCapital = countryCapital.Trim();
            //Console.WriteLine(countryCapital);
            //countryCapital = countryCapital.Trim(new char[] { 'n', 'A' });
            //Console.WriteLine(countryCapital);


            //StringBuilder

            StringBuilder sb = new StringBuilder("Name: ");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);

            sb.Append(firstCompany);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb);


        }

    }
}
