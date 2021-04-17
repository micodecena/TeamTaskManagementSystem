using System;
using System.Linq;

namespace teamTaskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int repeater = 1;
            string[] team = new string[] { };

            for (int i = 0; i < repeater; i++)
            {
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("Add member, Add task, View members, View tasks");
                Console.WriteLine("type 1 if Add member, type 2 if Add task, type 3 if View members,type 4 View tasks,  ");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    int teamlimiter = 1;
                    for (int a = 0; a < teamlimiter; a++)
                    {
                        Console.WriteLine("enter members name");
                        team = team.Concat(new string[] { Console.ReadLine() }).ToArray();
                        string des;
                        Console.WriteLine("would you like yo add another member? (type y if yes or n if no)");
                        des = Console.ReadLine();

                        if (des == "y")
                        {
                            teamlimiter++;
                        }
                        else
                        {
                            repeater++;
                        }
                    }
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Members:");
                    for (int b = 0; b < team.Length; b++)
                    {
                        
                        Console.WriteLine(team[b]);
            
                    }

                    Console.WriteLine("");
                    Console.WriteLine("press 1 to go back");
                    int c1;
                    c1 = Convert.ToInt32(Console.ReadLine());
                    if (c1 == 1)
                    {
                        repeater++;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT");
                    }

                }
            

            }

        }
    }
}
