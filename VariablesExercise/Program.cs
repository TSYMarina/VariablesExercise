using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string Intro;
            string heroName = "Hulk";
            int year = 1962;
            int howOldIsTheBook;

            Intro = "The Hulk is a fictional superhero appearing in publications by the American publisher Marvel Comics. Created by writer Stan Lee and artist Jack Kirby, the character first appeared in the debut issue of The Incredible Hulk";
            howOldIsTheBook = 60;
            bool IsAnniversaryYear = true;

            string sentence1 = "The Hulk is typically seen as a hulking man with green skin, hair, and eyes, wearing only a pair of torn purple pants that survive his physical transformation as the character progressed.";
            string sentence2 = "Originally, Stan Lee wanted the Hulk to be grey. Due to ink problems, Hulk's color was changed to green.";
            string added = $"{sentence1} {sentence2}";

            
            Console.WriteLine(heroName);
            Console.WriteLine(Intro);
            Console.WriteLine($"The book was written in {year}");
            Console.WriteLine(added);
            if (IsAnniversaryYear)
            {
                Console.WriteLine("Many people will be celebrating Hulk's 60th anniversary in 2022");
            }

         }
    }
}
