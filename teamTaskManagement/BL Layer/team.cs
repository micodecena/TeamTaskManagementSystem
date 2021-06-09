using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLlayer
{
    public class team
    {
        //This class contains all the variables that involves in the team portion of the system
        


        public List<string> TeamMembers = new List<string> { };
        public List<string> taskmem = new List<string> { };
        public string leadername;
        public string Addmemberdes;
        

        
        public void viewLeader()
        {
            Console.WriteLine("Project Leader:");
            Console.WriteLine(leadername);

        }

      


        




      


    }
}
