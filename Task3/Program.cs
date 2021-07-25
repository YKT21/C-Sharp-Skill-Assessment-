﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var people = new List<Person>();

            string[] subjects = { "Math", "Science", "English" };
            string studentName = "Sue";

            //TODO: 6, instantiate student and add to people collection
            Student std = new Student(studentName, subjects);
            people.Add(std);


            string faculty = "Computer Science";
            string teacherName = "Tim";

            //TODO: 7, instantiate teacher and add to people collection
            Teacher tch = new Teacher(teacherName, faculty);
            people.Add(tch);

            //TODO: 8, iterate through people collection and invoke PrintDetails for each element
            foreach (var p in people)
            {
                p.PrintDetails();
            }


           // Console.ReadKey(); 
        }
    }
}
