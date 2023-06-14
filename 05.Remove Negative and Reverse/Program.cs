using System.Xml.Linq;

namespace _05.Remove_Negative_and_Reverse;
class Program
{
    static void Main(string[] args)
    {
        //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
        //    If there are no elements left in the list, print "empty".


        List<int> number = Console.ReadLine().
                         Split().
                         Select(int.Parse).
                         ToList();

        for(int i=0;i<number.Count;i++)
        {
            if (number[i]<0)
            {
                number.Remove(number[i]);
                i--;

            }
        }

        if(number.Count==0)
        {
            Console.WriteLine("empty");
        }

        

        else
        {
            number.Reverse();

            Console.WriteLine(string.Join(" ", number));

        }


    }
}

