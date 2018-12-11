using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadam.course.capstone
{
    class Hello
    {
        private static string stdname;
        private static int nocourse;
        private static DateTime datTime;
        private static string type;
        private static string t;
        public static void getsn()
        {
            Welcome.setsName(stdname);// This method is used to set the student name in class welcome

        }

        public static void setsn(String sname)
        {
            stdname = sname;
            getsn();// This method is used to get the variable 
        }

        public static void getcourseno()
        {
            Welcome.setsnocours(nocourse);// This method is used to set the variable in class welcome

        }

        public static void setcourseno(int course)
        {
            nocourse = course;
            getcourseno();// This method is used to set the variable "" of class welcome
        }

        public static void getstartdate()// This method is used to set the variable in class welcome
        {
            Welcome.setdate(datTime);

        }

        public static void setstartdate(DateTime dtTime)// This method is used to set variable in class hello
        {
            datTime = dtTime;
            getstartdate(); //This method is used to set the "start date variable" variable of class welcome
        }

        public static void getclasstype()// This method is used to return variable type
        {
            Welcome.settype(type);// This method is used to set variable type

        }

        public static void setclasstype(string Type)
        {
            type = Type;
            getclasstype();// This method gives the value of class type
        }

        public static void getno()
        {
            Welcome.setnumber(t);// This method sets variable by taking the input from the user

        }

        public static void setno(string T)
        {
            t = T;
            getno();
        }
    }

    
}

