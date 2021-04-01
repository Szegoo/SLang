using System;

namespace SLang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosao u SLang!");
            System.Console.WriteLine("komande: print, :run");
            string komanda = "";
            string[] komande = new string[5];
            int index = 0;
            do
            {
                System.Console.Write("> ");
                komanda = Console.ReadLine();
                if (komanda != ":run")
                {
                    komande[index] = komanda + ";";
                    index++;
                }
            } while (komanda != ":run");
            for (int i = 0; i < index; i++)
            {
                string kom = komande[i].Split(" ")[0];
                switch (kom)
                {
                    case "print":
                        int ind = komande[i].IndexOf(" ");
                        int end = komande[i].IndexOf(";");
                        string text = komande[i].Substring(ind + 1, (end - ind) - 1);
                        System.Console.WriteLine(text);
                        break;
                    case "saberi":
                        ind = komande[i].IndexOf(" ");
                        end = komande[i].IndexOf(";");
                        int num1 = Convert.ToInt32(komande[i].Substring(ind + 1, 1));
                        string br2 = komande[i].Substring(ind + 3, 1);
                        int num2 = Convert.ToInt32(br2);
                        int zbir = num1 + num2;
                        System.Console.WriteLine("zbir: " + zbir);
                        break;
                }
            }
        }
    }
}
