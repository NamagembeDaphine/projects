using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class UserLogin : Response
    {
        private string DateOfRegistration, Name, Type, Gender, UserName, PassWord;

        public string DateOfRegistration1
        {
            get { return DateOfRegistration; }
            set { DateOfRegistration = value; }
        }

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Type1
        {
            get { return Type; }
            set { Type = value; }
        }

        public string Gender1
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string PassWord1
        {
            get { return PassWord; }
            set { PassWord = value; }
        }

        
    }
}
