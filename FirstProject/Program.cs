using FirstProject;
using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstProject.Assignments;

class MainClass
{
    static int Main(string[] args)
    {
        //Old assignments
        Assignment1 asg1 = new Assignment1();

        //=============================================================
        //Assignment : 1 C# Language Basics
        UpdatedAssignment updatedAssignment = new UpdatedAssignment();
        //updatedAssignment.TestAssignment1();

        //=============================================================
        //Assignment : 2 Delegates & Exceptional Handling
        Assignment2 asg2 = new Assignment2();
        //asg2.TestAssignment2();

        //=============================================================
        //Assignment : 3 Object Oriented Programming: Inheritance, Abstract classes and interfaces
        Assignment3 asg3 = new Assignment3();
        //asg3.TestAssignment3();

        //=============================================================
        //Assignment : 5 File Handling Concepts
        Assignment5 asg5 = new Assignment5();
        //asg5.TestAssignment5();

        //=============================================================
        //Assignment : 8 File Handling Concepts
        Assignment8 asg8 = new Assignment8();
        asg8.TestAssignment8();



        return 0;
    }
}
