using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _09.Change_List;
class Program
{
    static void Main(string[] args)
    {
        //        Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
        //Your program may receive the following commands:
        //	•	Delete { element} – delete all elements in the array, which are equal to the given element.
        //	•	Insert { element}
        //        { position} – insert the element at the given position.
        //You should exit the program when you receive the "end" command.
        //Print all numbers in the array, separated by a single whitespace.

        List<int> numbers = Console.ReadLine().
                                    Split().
                                    Select(int.Parse).
                                    ToList();

        string input;

        while((input=Console.ReadLine())!="end")
        {
            string[] command = input.Split();

            if (command[0]=="Delete")
            {
                int value = int.Parse(command[1]);
                numbers.RemoveAll(x => x == value);
            }

            else if (command[0]=="Insert")
            {
                int value = int.Parse(command[1]);
                int position = int.Parse(command[2]);

                numbers.Insert(position, value);
            }

        }

        Console.WriteLine(String.Join(" ", numbers));
    }
}

