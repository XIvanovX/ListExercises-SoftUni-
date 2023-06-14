using System;
using System.Collections.Generic;

namespace _06.List_Manipulation_Basics;
class Program
{
    static void Main(string[] args)
    {
        //        Create a program that reads a list of integers.Then until you receive "end", you will receive different commands:
        //	•	Add { number}: add a number to the end of the list.
        //	•	Remove { number}: remove a number from the list.
        //	•	RemoveAt { index}: remove a number at a given index.
        //	•	Insert { number}
        //        { index}: insert a number at a given index.
        //        Note: All the indices will be valid!
        //When you receive the "end" command, print the final state of the list(separated by spaces).


        List<int> numbers = Console.ReadLine().
                         Split().
                         Select(int.Parse).
                         ToList();


        string input;

        while ((input = Console.ReadLine()) != "end")
        {

            string[] parameters = input.Split();
            string command = parameters[0];

            if (command == "Add")
            {
                int value = int.Parse(parameters[1]);
                numbers.Add(value);

            }
            else if (command == "Remove")
            {
                int value = int.Parse(parameters[1]);
                numbers.Remove(value);
            }
            else if (command == "RemoveAt")
            {
                int value = int.Parse(parameters[1]);
                numbers.RemoveAt(value);
            }
            else if (command == "Insert")
            {
                int value = int.Parse(parameters[1]);
                int index = int.Parse(parameters[2]);
                numbers.Insert(index, value);


            }
        }

        Console.WriteLine(String.Join(" ", numbers));


    }

}