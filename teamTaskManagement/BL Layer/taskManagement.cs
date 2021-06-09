using System;
using System.Collections.Generic;
using System.Text;

namespace BLlayer
{
    public class taskManagement : ProjectsandTasks
    {
        //This class contains all the function that revolves around the task portion of the system
        //this class also implemented inheritance. this class is a child class of the parent class ProjectsandTasks
        
        
        //combination of all the methods involved that enables the user to add a task
        public void AddTask()
        {

            AddTaskName();
            AddTaskPriority();
            AddTaskDate();
            taskcount++;
            Console.WriteLine("");
            Console.WriteLine("Task Added");
        }

        //past of the AddTask function this function allows the user to input the task name
        public void AddTaskName()
        {

            Console.WriteLine("Enter Task Name: ");
            taskname.Add(Console.ReadLine());

        }

        //past of the AddTask function this function allows the user to choose task proirity
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



        //past of the AddTask function this function allows the user to input the task deadline
        public void AddTaskDate()//this is a work in progress just a prototype
        {
            Console.WriteLine("input Task Deadline");
            Console.WriteLine("Input Month");
            taskdeadline.Add(Console.ReadLine());
            Console.WriteLine("input day(numbers)");
            taskdeadline[tdc] = taskdeadline[tdc] + ", " + Console.ReadLine();
            Console.WriteLine("input year");
            taskdeadline[tdc] = taskdeadline[tdc] + " " + Console.ReadLine();
            tdc++;
        }



        //function that allows the user to view tasks
        public void ViewTask()
        {

            if (taskcount == 0)
            {
                Console.WriteLine("No Current Task Assigned");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("TaskName           Priority Level         Deadline         Members Assigned");

                for (int i = 0; i < taskname.Count; i++)
                {
                    Console.WriteLine(taskname[i] + "           " + taskprio[i] + "         " + taskdeadline[i] + "         ");
                }

            }

        }




    }
}
