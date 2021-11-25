using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damn
{
    class Program
    {
        static void Main(string[] args)
        {
            int ite = 0;
            Console.WriteLine("Combien de températures voulez-vous renseigner? : ");
            ite = int.Parse(Console.ReadLine());
            float[] temps = new float[ite];
            int negative = 0, positive = 0;

            for (int i = 0; i < ite; i++)
            {
                Console.WriteLine($"Saisie n°{i} | Entrez une température entre -20°C et +40°C : ");
                temps[i] = int.Parse(Console.ReadLine());
                if (temps[i] < -20 || temps[i] > 40) 
                {
                    i--;
                    Console.WriteLine("Erreur de saisie, veuillez recommencer");
                }
            }

            for (int i = 0; i < ite; i++) 
            {
                Console.WriteLine(temps[i] + " ");
                if(temps[i]<0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }
            }
            Console.WriteLine("Il y a " + negative + " valeurs négatives et " + positive + " valeurs positives");
            Console.ReadKey();
        }
    }
}
