using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class Response
    {
        private string StatusCode, StatusDescription;

        public string StatusCode1
        {
            get { return StatusCode; }
            set { StatusCode = value; }
        }

        public string StatusDescription1
        {
            get { return StatusDescription; }
            set { StatusDescription = value; }
        }
    }
}
