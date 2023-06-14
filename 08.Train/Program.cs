using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Text;
namespace _08.Train;
class Program
{
    static void Main(string[] args)
    {
        //        On the first line, we will receive a list of wagons(integers). Each integer represents the number of passengers that are currently in each wagon of the passenger train. On the next line, you will receive the max capacity of a wagon, represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:
        //	•	Add { passengers} – add a wagon to the end of the train with the given number of passengers.
        //	•	{ passengers} – find a single wagon to fit all the incoming passengers(starting from the first wagon).
        //In the end, print the final state of the train(all the wagons separated by a space).

        List<int> trainWagons = Console.ReadLine().
                              Split().
                              Select(int.Parse).
                              ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string input;



        while((input=Console.ReadLine())!="end")
        {

            string[] command = input.Split();

            //We made the input into array,so we can take each element separetly as index

            if (command[0] == "Add") 
            {
                int value = int.Parse(command[1]);
                trainWagons.Add(value);
            }

            else
            {
                int value = int.Parse(command[0]);
                for(int i=0;i<trainWagons.Count;i++)
                {

                    if ((maxCapacity - trainWagons[i]) >= value)
                    {
                        trainWagons[i]+=value;
                        break;

                    }
                }
            }
        }


        Console.WriteLine(String.Join(" ", trainWagons));



    }
}

