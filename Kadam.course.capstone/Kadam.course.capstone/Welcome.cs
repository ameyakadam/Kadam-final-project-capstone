using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadam.course.capstone
{
    class Welcome
    {
        
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        private static string t1;
        public static string getsName()
        {
            return studentname;
        }

        public static void setsName(String stdname) // This method is used to set students name in the form
        {
            string s;
            s = studentname;
            studentname = stdname;
            if (s != studentname)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to " + studentname);
            }
        }

        public static int getnocours()// This method is used to set variables in form
        {
            return courseno;

        }

        public static void setsnocours(int course)//This method is used to set courseno in class welcome
        {
            int a;
            a = courseno;
            courseno = course;
            if (a != courseno)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to "+ courseno);
            }
        }

        public static DateTime getdate()// This variable is used to set datetime
        {
            return dateTime;

        }

        public static void setdate(DateTime dtTime)// This method is used to set datetime in class welcome
        {
            DateTime dt;
            dt = dateTime;
            dateTime = dtTime;
            if(dt != dateTime)
            {
                System.Windows.Forms.MessageBox.Show("The value has been changed to " + dateTime);
            }
        }

        public static string gettype()// This method is used to get the type of the variable
        {
            return type2;

        }

        public static void settype(string Type)
        {
            string g;
            g = type2;
            type2 = Type;
            if(g != type2)
            {
                System.Windows.Forms.MessageBox.Show("The value has changed to " + type2);
            }
            gettype();
        }

        public static string getnumber()// This method is used to get the number from class hello
        {
            return t1;

        }

        public static void setnumber(string Type)// This method is used to set the number
        {
            string t;
            t = t1;
            t1 = Type;
            if (t != t1)
            {
                System.Windows.Forms.MessageBox.Show("The value has changed to "+ t1);
            }
            gettype();
        }
    }
}

