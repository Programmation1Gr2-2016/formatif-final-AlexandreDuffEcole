using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    /// <summary>
    /// Entête???
    /// 10/15
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            bool [] tabCellulle = new bool[100];    // Serait-il possible de trouver un nom plus significatif?
            string key = "";                        // ??
            Random rnd = new Random();
            int random;
            int position = 0;
            int essaie = 0;
            bool possible = true;
            string instructions = "";



            tabCellulle[0] = true;
            tabCellulle[99] = true;





            for (int i = 1; i < 99 ; i++)           // Super!
            {
                random = rnd.Next(1, 3);            // Bien, je préférerais (0,2) 0: false, 1:true
                if(random == 1)
                {
                    tabCellulle[i] = true;
                }
                else
                {
                    tabCellulle[i] = false;
                }
            }


            


            while(possible == true)
            {
                Console.WriteLine("Que voulez vous faire?");
                Console.WriteLine(instructions);

                key = Console.ReadLine();
                key = key.ToUpper();
                Console.Clear();

                if(key == "A")
                {
                    essaie++;
                    if (position - 3 >= 0 && tabCellulle[position - 3] == true)
                    {
                        position -= 3;
                    }
                    else
                    {
                        Console.WriteLine("Ce mouvement est impossible");
                    }
                }
                else if (key == "S")
                {
                    essaie++;
                    if(position - 2 >= 0 && tabCellulle[position - 2] == true) 
                    {
                        position -= 2;

                    }
                    else
                    {
                        Console.WriteLine("Ce mouvement est impossible");
                    }
                }
                else if (key == "D")
                {
                    essaie++;
                    if (position - 1 >= 0 && tabCellulle[position - 1] == true)
                    {
                        position -= 1;

                    }
                    else
                    {
                        Console.WriteLine("Ce mouvement est impossible");
                    }
                }
                else if (key == "G")
                {
                    essaie++;
                    if (position + 2 <= 100 && tabCellulle[position + 2] == true)
                    {
                        position += 2;

                    }
                    else
                    {
                        Console.WriteLine("Ce mouvement est impossible");
                    }
                }
                else if (key == "H")
                {
                    essaie++;
                    if (position + 4 <= 100 && tabCellulle[position + 4] == true)
                    {
                        position += 4;

                    }
                    else
                    {
                        Console.WriteLine("Ce mouvement est impossible");
                    }
                }
                else if (key == "Q")                // OK : Ça marche mais c'est +/- clair. J'aurais ajouté key == "Q" dans la condition while
                {
                    possible = false;
                }
                else if (key == "Y")
                {
                    AffichageEntier();
                }
                else if (key == "P")
                {
                    Affiche10();
                }
                else
                {
                    Console.WriteLine("C'est pas dans les choix!!!");
                }

                Console.WriteLine("vous etes a la case " + position + "/100");

                for (int i = 1; i < 5; i++)
                {
                    if(tabCellulle[i + position] == true)
                    {
                        i = 10;                 // Pas clean
                        Console.WriteLine("Vous pouvez encore aller plus loin :)");
                    }
                    else if (tabCellulle[i + position] == false)
                    {
                        if(i == 4)
                        {
                            Console.WriteLine("C'est impossible de continuer plus loin que cette case... :/");
                            possible = false;
                        }
                    }
                }



            }








        }

        // Incomplet
        private static void AffichageEntier()
        {

        }
        private static void Affiche10()
        {

            for (int i = 0; i < 10; i++)
            {

            }

        }
    }
}
