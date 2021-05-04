using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace teamTaskManagement
{
    class team
    {

       
        public List<string> TeamMembers = new List<string> { };
        public string Addmemberdes;
        public int VMchoice;


        //allows the user to add members
        public void AddMember()
        {

            Console.WriteLine("enter members name");
            TeamMembers.Add(Console.ReadLine());
            
            Console.WriteLine("would you like to add another member? (type y if yes or n if no)");
            Addmemberdes = Console.ReadLine();


        }

        //allows the user to view the current members
        public void ViewMembers()
        {

            if (TeamMembers.Count == 0)
            {
                Console.WriteLine("No Members");
                Console.WriteLine("");
                Console.WriteLine("press 1 to go back");
                VMchoice = Convert.ToInt32(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("Members:");
                for (int b = 0; b < TeamMembers.Count; b++)
                {

                    Console.WriteLine(TeamMembers[b]);

                }

                Console.WriteLine("");
                Console.WriteLine("press 1 to go back");
                VMchoice = Convert.ToInt32(Console.ReadLine());
            }

        }

        public void BeginProjectAddMember()
        {

            int teamlimiter = 1;
            for (int a = 0; a < teamlimiter; a++)
            {
                AddMember();

                if (Addmemberdes == "y")
                {
                    teamlimiter++;
                }



            }
        }



    }
}
