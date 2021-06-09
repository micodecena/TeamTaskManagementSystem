using System;
using System.Collections.Generic;
using System.Text;

namespace BLlayer
{
   public class teamMembersManagement : team

    {

        //This class contains all the function that revolves around the team portion of the system
        //this class also implemented inheritance. this class is a derived class of the parent class team

        //allows the user to add members
        public void AddMember()
        {

            Console.WriteLine("enter members name");
            TeamMembers.Add(Console.ReadLine());

            Console.WriteLine("would you like to add another member? (y) yes or (n) no");
            Addmemberdes = Console.ReadLine();

            if (Addmemberdes == "y")
            {
                AddMember();
            }


        }


        //allows the user to view the current members
        public void ViewMembers()
        {

            if (TeamMembers.Count == 0)
            {
                Console.WriteLine("No Members");
                Console.WriteLine("");

            }

            else
            {
                Console.WriteLine("Members:");
                for (int b = 0; b < TeamMembers.Count; b++)
                {

                    Console.WriteLine(TeamMembers[b]);

                }

            }

        }

        //part of the project intializer(initialize member)
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

        //this method allows the user to assign members to an existing tast(still a work in progress)
        public void assignMember()
        {


            Console.WriteLine("Choose a member to assign");
            for (int i = 0; i < TeamMembers.Count; i++)
            {
                i++;
                Console.Write("(" + i + ")" + " ");
                i--;
                Console.WriteLine(TeamMembers[i]);
            }
            int choice;


            choice = Convert.ToInt32(Console.ReadLine());
            taskmem.Add(TeamMembers[choice]);

        }


    }
}
