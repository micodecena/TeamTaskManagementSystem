using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLlayer;

namespace teamTaskManagement
{
    class homemenu
    {
        //this class contains the main user interface of the system

        taskManagement projectcon = new taskManagement();
        teamMembersManagement teamcon = new teamMembersManagement();
        public int menurepeater = 1;

        public void mainmenu()
        {


            for (int i = 0; i < menurepeater; i++)
            {

                displayMenu();

                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 1)
                {
                    int teamlimiter = 1;
                    for (int a = 0; a < teamlimiter; a++)
                    {
                        teamcon.AddMember();
                        menurepeater++;
                    }
                }

                else if (choice == 2)
                {
                    projectcon.AddTask();
                    menurepeater++;
                }

           

             




                else
                {
                    Console.WriteLine("no no no");

                }


            }
        }

        //project initializer
        public void BeginProject()
        {
            Console.WriteLine("What would be the name of your Project");
            projectcon.projectname = Console.ReadLine();
            Console.WriteLine("Please enter Team Leader Name:");
            teamcon.leadername = Console.ReadLine();
            Console.WriteLine("Would you like to add the members now?");
            Console.WriteLine("(y)Yes                 (n)No             ");
            string choice;
            choice = Console.ReadLine();
            if (choice == "y")
            {
                teamcon.BeginProjectAddMember();

            }

        }


        //main interface title/mainmenu screen
        public void displayMenu()
        {
            Console.Clear();  
            Console.WriteLine("                          TEAM TASK                           ");
            Console.WriteLine("                      MANAGEMENT SYSTEM                       ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                       Project: " + projectcon.projectname);
            Console.WriteLine("                     Project Leader: " + teamcon.leadername);
            Console.WriteLine("                  what would you like to do?");
            Console.WriteLine("                                                           ");
            teamcon.ViewMembers();
            Console.WriteLine("                                                           ");
            projectcon.ViewTask();
            Console.WriteLine("(1) Manage Member                               (2) Manage Task ");
        }


        public void taskinterface()
            {
                



            }

    }
}
