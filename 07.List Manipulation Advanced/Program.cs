using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace _07.List_Manipulation_Advanced;
class Program
{
    static void Main(string[] args)
    {
        //        Next, we are going to implement more complicated list commands, extending the previous task.
        //        Again, read a list and keep reading commands until you receive "end":
        //	•	Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
        //	•	PrintEven – print all the even numbers, separated by a space.
        //	•	PrintOdd – print all the odd numbers, separated by a space.
        //	•	GetSum – print the sum of all the numbers.
        //	•	Filter { condition}
        //        { number} – print all the numbers that fulfill the given condition.The condition will be either '<', '>', ">=", "<=".
        //After the end command, print the list only if you have made some changes to the original list.
        //Changes are made only fromcommands from the previous task.

        List<int> numbers = Console.ReadLine().
                        Split().
                        Select(int.Parse).
                        ToList();


        string input;

        bool isChecked = false;

        while ((input = Console.ReadLine()) != "end")
        {

            string[] parameters = input.Split();
            string command = parameters[0];

            if (command == "Add")

            {
                isChecked = true;
                int value = int.Parse(parameters[1]);
                numbers.Add(value);

            }
            else if (command == "Remove")
            {
                isChecked = true;
                int value = int.Parse(parameters[1]);
                numbers.Remove(value);
            }
            else if (command == "RemoveAt")
            {
                isChecked = true;
                int value = int.Parse(parameters[1]);
                numbers.RemoveAt(value);
            }
            else if (command == "Insert")
            {
                isChecked = true;
                int value = int.Parse(parameters[1]);
                int index = int.Parse(parameters[2]);
                numbers.Insert(index, value);


            }
            else if (command == "Contains")
            {
                int value = int.Parse(parameters[1]);

                if (numbers.Contains(value))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            else if (command == "PrintEven")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            else if(command=="PrintOdd")
                {
                Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));

            }
            else if(command=="GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }
            else if(command=="Filter")
            {
                string condition = parameters[1];
                int value = int.Parse(parameters[2]);

                if (condition == "<")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x < value)));
                }
                else if (condition == "<=")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x <= value)));

                }
                else if (condition == ">")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x > value)));

                }
                else if (condition == ">=")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x >= value)));
                }
            }
                
                 
            }


        if (isChecked)
        {
            Console.WriteLine(String.Join(" ", numbers));
        }

        






    }




    }


