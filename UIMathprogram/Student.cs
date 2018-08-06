using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIMathprogram
{
    public class Student
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public int Score { get; set; }

        public Student(string login, string pass, int score)
        {
            Login = login;
            Pass = pass;
            Score = score;
        }
        //    public void AddNewStudent (string login,string pass,int score)
        //{
            
        //}
    }

 
}
