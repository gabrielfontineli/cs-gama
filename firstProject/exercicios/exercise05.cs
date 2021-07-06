using System;

namespace firstProject
{
    class exercise05
    {
        public static void run()
        {
            Console.WriteLine("-------Exercise 05-------");
            int electors, blankVotes, nullVotes, validVotes;
            
            Console.WriteLine("number of electors:");
            electors = int.Parse(Console.ReadLine());

            Console.WriteLine("number of blank votes");
            blankVotes = int.Parse(Console.ReadLine());
            
            Console.WriteLine("number of null votes");
            nullVotes = int.Parse(Console.ReadLine());
            
            Console.WriteLine("number of valid votes");
            validVotes = int.Parse(Console.ReadLine());
            double validPercentage, blankPercentage, nullPercentage;

            validPercentage = ((double)validVotes/electors) * 100;
            nullPercentage = ((double)nullVotes/electors) * 100;
            blankPercentage = ((double) blankVotes/electors) * 100;

            Console.WriteLine($"percentage of blank votes:{blankPercentage}%");
            Console.WriteLine($"percentage of null votes:{nullPercentage}%");
            Console.WriteLine($"percentage of valid votes:{validPercentage}%");
        }

    }

}