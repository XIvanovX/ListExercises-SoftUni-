using System.Collections.Generic;

namespace _02.Gaus_Trick;
class Program
{
    static void Main(string[] args)
    {
        //Create a program that sums all numbers in a list in the following order:
        //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.


        List<int> number = Console.ReadLine().
                            Split().
                            Select(int.Parse).
                            ToList();

        List<int> newList = new List<int>();

        for(int i=0;i<number.Count/2;i++)
        {

            int currentNumber=number[i] + number[number.Count - 1-i];
            newList.Add(currentNumber);
            
            
        }

        if(number.Count%2!=0)
        {
            newList.Add(number[number.Count / 2]);
        }

        Console.WriteLine(string.Join(" ", newList));

    }
}

