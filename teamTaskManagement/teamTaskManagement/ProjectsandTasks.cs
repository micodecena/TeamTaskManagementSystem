using System;
using System.Collections.Generic;
using System.Text;

namespace teamTaskManagement
{
    class ProjectsandTasks
    {
        public int VTchoice;//viewtask choice
        
        public String projectname;
        public string leadername;

        public int taskcount = 0;
        public int tdc = 0;//tast date counter
        
        public List<string> taskname = new List<string> { };
        public List<string> taskprio = new List<string> { };
        public List<string> taskmem = new List<string> { };
        public List<string> taskdeadline = new List<string> { };
       

        public void AddTask()
        {

            Console.WriteLine("Enter Task Name: ");
            taskname.Add(Console.ReadLine());
            AddTaskPriority();
            AddTaskDate();

            taskcount++;
            Console.WriteLine("");
            Console.WriteLine("Task Added");
        }

        public void AddTaskPriority()
        {
            Console.WriteLine("choose Task priority level");
            Console.WriteLine("(1)Low (2)Medium (3)High");
            int pc;//priority choice
            pc = Convert.ToInt32(Console.ReadLine());
            if (pc == 1)
            {
                taskprio.Add("Low Priority");
            }
            else if (pc == 2)
            {
                taskprio.Add("Mediun Priority");
            }
            else if (pc == 3)
            {
                taskprio.Add("High Priority");
            }
            else 
            {
                Console.WriteLine("INCORRECT INPUT");
            }

        }

        public void AddTaskDate()
        {
            
            Console.WriteLine("input Task Deadline");
            Console.WriteLine("Input Month");
            taskdeadline.Add(Console.ReadLine());
            Console.WriteLine("input day(numbers)");
            taskdeadline[tdc] = taskdeadline[tdc] + Console.ReadLine();
            Console.WriteLine("input year");
            taskdeadline[tdc] = taskdeadline[tdc] + Console.ReadLine();
            tdc++;

        }

        public void ViewTask()
        {

            if (taskcount == 0)
            {
                Console.WriteLine("No Current Task Assigned");
                Console.WriteLine("");
                Console.WriteLine("press 1 to go back");
                VTchoice = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("TaskName           Priority Level         Deadline         Members Assigned");
               
                for (int i = 0; i < taskname.Count; i++)
                {
                Console.WriteLine(taskname[i]+ "           " + taskprio[i]+ "         " + taskdeadline[i]+ "         ");
                }

                Console.WriteLine("");
                Console.WriteLine("press 1 to go back");
                VTchoice = Convert.ToInt32(Console.ReadLine());
            }

        }




    }
}
