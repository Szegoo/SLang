using System;

namespace SLang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobrodosao u SLang!");
            System.Console.WriteLine("komande: PRINT, SUM, DECLARE, :run");
            string komanda = "";
            string[] komande = new string[20];
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
                    case "PRINT":
                        int ind = komande[i].IndexOf(" ");
                        int end = komande[i].IndexOf(";");
                        string text = komande[i].Substring(ind + 1, (end - ind) - 1);
                        System.Console.WriteLine(text);
                        break;
                    case "SUM":
                        ind = komande[i].IndexOf(";");
                        string[] koms = komande[i].Substring(0, ind).Split(" ");
                        int num1 = Convert.ToInt32(koms[1]);
                        int num2 = Convert.ToInt32(koms[2]);
                        int zbir = num1 + num2;
                        System.Console.WriteLine("zbir: " + zbir);
                        break;
                    case "DECLARE":
                        ind = komande[i].IndexOf(";");
                        koms = komande[i].Substring(0, ind).Split(" ");
                        string ime = koms[1];
                        string vrednost = koms[2];
                        for (int m = 3; m < koms.Length; m++)
                        {
                            vrednost += " " + koms[m];
                        }
                        for (int j = i; j < index; j++)
                        {
                            if (komande[j].Contains(ime))
                            {
                                komande[j] = komande[j].Replace(ime, vrednost);
                            }
                        }
                        break;
                    default:
                        System.Console.WriteLine(komande[i].Substring(0, komande[i].IndexOf(";")) + " - nije definisan!");
                        break;
                }
            }
        }
    }
}
