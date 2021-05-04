using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace teamTaskManagement
{
    class homemenu
    {
        ProjectsandTasks projectcon = new ProjectsandTasks();
        team teamcon = new team();
        public int menurepeater = 1;

        public void mainmenu()
        {
          
            
            for (int i = 0; i < menurepeater; i++)
            {

                Console.Clear();
                Console.WriteLine("                     TEAM TASK                           ");
                Console.WriteLine("                 MANAGEMENT SYSTEM                       ");
                Console.WriteLine("                                                         ");
                Console.WriteLine("                 Project: " + projectcon.projectname);
                Console.WriteLine("               Project Leader: " + projectcon.leadername);
                Console.WriteLine("             what would you like to do?");
                Console.WriteLine("(1) Add member (2) Add task (3) View members (4)View tasks");

                int choice;

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 1)
                {
                    int teamlimiter = 1;
                    for (int a = 0; a < teamlimiter; a++)
                    {
                        teamcon.AddMember();

                        if (teamcon.Addmemberdes == "y")
                        {
                            teamlimiter++;
                        }

                        else
                        {
                            menurepeater++;

                        }
                    }
                }

                else if (choice == 2)
                {
                    projectcon.AddTask();
                    menurepeater++;
                }

                else if (choice == 3)
                {
                    teamcon.ViewMembers();
                    if (teamcon.VMchoice == 1)
                    {
                        menurepeater++;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT");
                    }
                }
                
                else if (choice == 4)
                {
                    projectcon.ViewTask();
                    if (projectcon.VTchoice == 1)
                    {
                        menurepeater++;
                    }
                    else
                    {
                        Console.WriteLine("INVALID INPUT");
                    }
                }

                else
                {
                    Console.WriteLine("no no no");
                
                }


            }
        }

        public void BeginProject()
        {

            

            Console.WriteLine("What would be the name of your Project");
            projectcon.projectname = Console.ReadLine();
            Console.WriteLine("Please enter Team Leader Name:");
            projectcon.leadername = Console.ReadLine();
            Console.WriteLine("Would you like to add the members now?");
            Console.WriteLine("(y)Yes                 (n)No             ");
            string choice;
            choice = Console.ReadLine();
            if (choice == "y")
            {
                teamcon.BeginProjectAddMember();

            }

        }




    }
}
