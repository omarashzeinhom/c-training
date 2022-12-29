using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle
{
    internal class Student
    {
        public string name;
        public string classes;
        public double gpa;
        public Student(string aName, string allClasses, double anGpa)
        {
            name = aName;
            classes = allClasses;
            gpa = anGpa;
        }




        public bool hasHonors()
        {
            if (gpa >= 3.6)
            {
                return true;

            }
            return false;
        }




    }



}
