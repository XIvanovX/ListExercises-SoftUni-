using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace ListsExercises_SoftUni_;
class Program
{
    static void Main(string[] args)
    {
        //     Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.
        //•	After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)
        //•	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available)

        List<double> number = Console.ReadLine().
                             Split().
                             Select(double.Parse).
                             ToList();

        //We must go trough all the elements, check if the one next to eachother are equal and combine them and after that,
        //we must go back to the first index

        for(int i = 0;i<number.Count-1;i++)
        {
            if (number[i] == number[i+1])

            {
                number[i] += number[i + 1];
                number.RemoveAt(i + 1);
                i = -1;
            }

        }

        Console.WriteLine(string.Join(" ", number));
   

    }

}

