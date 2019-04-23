using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class SchoolFees : Response
    {
        private string DateOfPayment, StudentName, AdmissionNo, Class, Term, Level;

        public string DateOfPayment1
        {
            get { return DateOfPayment; }
            set { DateOfPayment = value; }
        }

        public string StudentName1
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public string AdmissionNo1
        {
            get { return AdmissionNo; }
            set { AdmissionNo = value; }
        }

        public string Class1
        {
            get { return Class; }
            set { Class = value; }
        }

        public string Term1
        {
            get { return Term; }
            set { Term = value; }
        }

        public string Level1
        {
            get { return Level; }
            set { Level = value; }
        }

        int SchoolFeesAmount, AmountPaid, Balance, CurrentAmountPaid;

        public int CurrentAmountPaid1
        {
            get { return CurrentAmountPaid; }
            set { CurrentAmountPaid = value; }
        }

        public int SchoolFeesAmount1
        {
            get { return SchoolFeesAmount; }
            set { SchoolFeesAmount = value; }
        }

        public int AmountPaid1
        {
            get { return AmountPaid; }
            set { AmountPaid = value; }
        }

        public int Balance1
        {
            get { return Balance; }
            set { Balance = value; }
        }

    }
}
