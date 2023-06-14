using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace _03.Mergint_LIsts;
class Program
{
    static void Main(string[] args)
    {
        //You are going to receive two lists of numbers.Create a list that contains the numbers from both of the lists.
        //    The first element should be from the first list, the second from the second list, and so on.
        //    If the length of the two lists is not equal,just add the remaining elements at the end of the list.


        List<int> firstList = Console.ReadLine().
                             Split().
                             Select(int.Parse).
                             ToList();

        List<int> secondList = Console.ReadLine().
                             Split().
                             Select(int.Parse).
                             ToList();

        List<int> result = new List<int>();

        int n = Math.Min(firstList.Count, secondList.Count);


        for (int i = 0; i < n; i++)
        {
            result.Add(firstList[i]);
            result.Add(secondList[i]);

        }

        if (firstList.Count > secondList.Count)
        {
            for (int i = n; i < firstList.Count; i++)
            {
                result.Add(firstList[i]);
            }


        }

        else if (secondList.Count > firstList.Count)
        {
            for (int i = (n ); i <secondList.Count; i++)
            {
                result.Add(secondList[i]);
            }
        }

        Console.WriteLine(string.Join(" ", result));


    

    }
}



