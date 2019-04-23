using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem
{
    class ItemPayment : Response
    {
        private string DateOfPayment, StudentName, AdmissionNo, Class, Item;
        int ItemFee, AmountPaid, Balance, CurrentAmountPaid;

        public int CurrentAmountPaid1
        {
            get { return CurrentAmountPaid; }
            set { CurrentAmountPaid = value; }
        }

        public int ItemFee1
        {
            get { return ItemFee; }
            set { ItemFee = value; }
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

        public string Item1
        {
            get { return Item; }
            set { Item = value; }
        }

       

    }
}
