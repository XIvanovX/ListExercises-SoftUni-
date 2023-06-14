using System.Collections.Generic;

namespace _04.List_operations
{
    class Program
    {
        static void Main(string[] args)
        {

            //        The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
            //The possible commands are:
            //	•	Add { number} – add the given number to the end of the list
            //	•	Insert { number}
            //        { index} – insert the number at the given index
            //	•	Remove { index} – remove the number at the given index
            //	•	Shift left { count} – first number becomes last. This has to be repeated the specified number of times
            //	•	Shift right { count} – last number becomes first. To be repeated the specified number of times
            //Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".


            List<int> numbers = Console.ReadLine().
                             Split().
                             Select(int.Parse).
                             ToList();


            string input;

            while ((input = Console.ReadLine()) != "End")
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
                    int index = int.Parse(parameters[1]);
                    if (index >= numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }

                else if (command == "Insert")


                {
                    int value = int.Parse(parameters[1]);
                    int index = int.Parse(parameters[2]);
                    if (index >= numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;

                    }


                    numbers.Insert(index, value);


                }

                else if (command == "Shift" && parameters[1] == "left")
                {
                    for (int i = 0; i < int.Parse(parameters[2]); i++)

                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }

                else if (command == "Shift" && parameters[1] == "right")
                {
                    for (int i = 0; i < int.Parse(parameters[2]); i++)

                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);

                    }

                }


            }

            Console.WriteLine(String.Join(" ", numbers));


        }
    }
}
