﻿using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace _10.House_Party;
class Program
{
    static void Main(string[] args)
    {

//        Create a program that keeps track of the guests that are going to a house party.
//            On the first line, of input you are going to receive the number of commands that will follow.
//On the next lines, you are going to receive some of the following:  "{name} is going!"
//	•	You have to add the person, if they are not on the guestlist already.
//	•	If the person is on the list print the following to the console: "{name} is already in the list!"
//"{name} is not going!"
//	•	You have to remove the person, if they are on the list. 
//	•	If not, print out: "{name} is not in the list!"
//Finally, print all of the guests, each on a new line.


            List<string> guests = new List<string>();

        int n = int.Parse(Console.ReadLine());

        for(int i=0;i<n;i++)
        {
            string[] command = Console.ReadLine().
                            Split().
                            ToArray();

            if(command.Length==3)
            {
                if (guests.Contains(command[0]))
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
                else
                {
                    guests.Add(command[0]);
                }

            }
            if(command.Length==4)
            {
                if (guests.Contains(command[0]))
                {
                    guests.Remove(command[0]);
                }
                else
                {
                    Console.WriteLine($"{command[0]} is not in the list!");
                }

            }

           
        }

        foreach(string str in guests)
        {
            Console.WriteLine(str);
        }
    }
}

