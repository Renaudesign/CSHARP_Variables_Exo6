using System;

namespace CSHARP_Variables_Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;
            int todayYear = date.Year;

            Console.WriteLine("Utilisateur numéro 751 203C, veuillez renseigner votre prénom:");
            string firstname = Console.ReadLine();

            Console.WriteLine("Utilisateur numéro 751 203C, veuillez maintenant renseigner votre nom de famille:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enfin, utilisateur numéro 751 203C, veuillez renseigner votre année de naissance:");
            int birthYear = int.Parse(Console.ReadLine());


            int age = todayYear-birthYear;

            Console.WriteLine($"Fiche de renseignement 751 203C :\n *Nom : {lastname} \n *Prénom : {firstname} \n *Age : {age}");


        }
    }
}
