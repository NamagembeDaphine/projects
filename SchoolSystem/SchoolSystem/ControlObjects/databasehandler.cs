using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace SchoolSystem
{
    class databasehandler
    {
        private Database Schooldb;
        private DbCommand command;

        public databasehandler() 
        {
            try 
            {
                Schooldb = DatabaseFactory.CreateDatabase("schooldbstring");
            }
            catch(Exception ex)
            {
                throw ex; 
            }
        }

        public void InsertUser(UserLogin user) 
        {
            try 
            {
                command = Schooldb.GetStoredProcCommand("InsertSystemUsers",user.DateOfRegistration1,user.Name1,user.Type1,user.Gender1,user.UserName1,user.PassWord1);
                Schooldb.ExecuteNonQuery(command);
                
               
                    
                     
                     
                    
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public UserLogin SelectUser(UserLogin user)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectSystemUser", user.UserName1, user.PassWord1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    user.StatusCode1 = "0";
                    user.StatusDescription1 = "Your Logged in";
                }
                else
                {
                    user.StatusCode1 = "1";
                    user.StatusDescription1 = "Login failed, Please Check Your UserName OR PassWord";
                }

                return user;
                 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertItem(ItemPayment item)
        {
            try 
            {
                command = Schooldb.GetStoredProcCommand("InsertItemPayment", item.DateOfPayment1, item.StudentName1, item.AdmissionNo1, item.Class1, item.Item1, item.ItemFee1, item.AmountPaid1, item.Balance1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectItem()
        {
            try 
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectItems");
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public DataTable SelectStudentItemRecords(ItemPayment item)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectStudentItem", item.AdmissionNo1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectItemByClass(ItemPayment item)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectItemsByClass", item.Class1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectItemByDate(ItemPayment item)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectItemsByDate", item.DateOfPayment1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertStudent(Student stud)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("InsertStudentsDetails", stud.DateOfRegistration1,stud.StudentName1, stud.AdmissionNo1,stud.Class1,stud.Level1,stud.Term1,stud.Section1,stud.DateOfBirth1,stud.NameOfParent1,stud.Contact1,stud.Address1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectStudents()
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectStudentDetails");
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectStudentsByClass(Student stud)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectStudentDetailsByClass", stud.Class1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertStaffMembers(StaffMember staff)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("InsertStaffMember",staff.DateOfRegistration1,staff.Name1,staff.Department1,staff.Type1,staff.Salary1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectStaffMembersByDep(StaffMember staff)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectStaffMembersByDepartment", staff.Department1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectStaffMembers()
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectAllStaffMembers");
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertSalaryPayment(Salary sal)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("InsertSalaryPayment",sal.DateOfPayment1,sal.PaidTo1,sal.Department1,sal.Type1,sal.Salo1,sal.AmountRecieved1,sal.Balance1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectAllSalaryPaymment()
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectAllSalaryPayments");
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable SelectSalaryPayByDep(Salary sal)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        command = Schooldb.GetStoredProcCommand("SelectSalaryPaymentsByDepartment", sal.Department1);
        //        dt = Schooldb.ExecuteDataSet(command).Tables[0];

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void InsertSchoolFeesPayment(SchoolFees fees)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("InsertSchoolFeesPayment", fees.DateOfPayment1,fees.StudentName1,fees.AdmissionNo1,fees.Class1,fees.Term1,fees.Level1,fees.SchoolFeesAmount1,fees.AmountPaid1,fees.Balance1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSchoolFeesPayment(SchoolFees fees)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("UpdatePaymentRec", fees.DateOfPayment1, fees.AmountPaid1, fees.Balance1, fees.AdmissionNo1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateItemPayment(ItemPayment item)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("UpdateItemPayment", item.DateOfPayment1, item.AmountPaid1, item.Balance1, item.AdmissionNo1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStudentRecords(Student stud)
        {
            try
            {
                command = Schooldb.GetStoredProcCommand("UpdateStudentsRecord", stud.DateOfRegistration1, stud.StudentName1, stud.AdmissionNo1, stud.Class1,stud.Level1, stud.Term1,stud.Section1);
                Schooldb.ExecuteNonQuery(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectSchoolFeesPayment(SchoolFees fees)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectSchoolFeesPayment", fees.Balance1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SchoolFees SelectOldAmountPaid(SchoolFees fees)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectOldAmount", fees.AdmissionNo1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        fees.StudentName1 = dt.Rows[0]["StudentName"].ToString();
                        fees.AdmissionNo1 = dt.Rows[0]["AdmissionNo"].ToString();
                        fees.Class1 = dt.Rows[0]["Class"].ToString();
                        fees.Term1 = dt.Rows[0]["Term"].ToString();
                        fees.Level1 = dt.Rows[0]["Level"].ToString();
                        fees.SchoolFeesAmount1 = int.Parse(dt.Rows[0]["SchoolFeesAmount"].ToString());
                        fees.AmountPaid1 = int.Parse(dt.Rows[0]["AmountPaid"].ToString());
                        fees.Balance1 = int.Parse(dt.Rows[0]["Balance"].ToString());
                        
                        
                        fees.StatusCode1 = "0";
                        fees.StatusDescription1 = "Payment Updated";
                    }
                }
                else 
                {
                    fees.StatusCode1 = "1";
                    fees.StatusDescription1 = "Payment Not Updated";
                }

                return fees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemPayment SelectOldItemAmountPaid(ItemPayment item)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectOldItemAmountPaid", item.AdmissionNo1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        item.StudentName1 = dt.Rows[0]["StudentName"].ToString();
                        item.AdmissionNo1 = dt.Rows[0]["AdmissionNo"].ToString();
                        item.Class1 = dt.Rows[0]["Class"].ToString();
                        item.Item1 = dt.Rows[0]["Item"].ToString();
                        item.ItemFee1 = int.Parse(dt.Rows[0]["ItemFee"].ToString());
                        item.AmountPaid1 = int.Parse(dt.Rows[0]["AmountPaid"].ToString());
                        item.Balance1 = int.Parse(dt.Rows[0]["Balance"].ToString());
                        
                        item.StatusCode1 = "0";
                        item.StatusDescription1 = "Payment Updated";
                    }
                }
                else
                {
                    item.StatusCode1 = "1";
                    item.StatusDescription1 = "Payment Not Updated";
                }

                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectSchoolFeesPaymentWithBal(SchoolFees fees)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectSchoolFeesPaymentWithBal", fees.Balance1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudentsWithZeroBal(SchoolFees fees)
        {
            try
            {
                
                command = Schooldb.GetStoredProcCommand("DeleteStudentsWithZeroBalance", fees.Balance1);
                Schooldb.ExecuteNonQuery(command);

             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudentSchoolFeesPayment(SchoolFees fees)
        {
            try
            {

                command = Schooldb.GetStoredProcCommand("DeleteStudentSchoolFeesPay", fees.AdmissionNo1);
                Schooldb.ExecuteNonQuery(command);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudentFunctionalFeesPayment(ItemPayment item)
        {
            try
            {

                command = Schooldb.GetStoredProcCommand("DeleteStudentFunctionalFeesPayment", item.AdmissionNo1);
                Schooldb.ExecuteNonQuery(command);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudentsWithZeroBalFunctionalFeesPayment(ItemPayment item)
        {
            try
            {

                command = Schooldb.GetStoredProcCommand("DeleteStudentsWithZeroBalanceFunctionalFees", item.Balance1);
                Schooldb.ExecuteNonQuery(command);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteStudentFromDb(Student stud)
        {
            try
            {
                
                command = Schooldb.GetStoredProcCommand("DeleteStudentFromSchoolDatabase", stud.AdmissionNo1);
                Schooldb.ExecuteNonQuery(command);
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectAllSchoolFeesPaymment()
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectSchoolFeesPayments");
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectSchoolFeesPaymentClass(SchoolFees fees)
        {
            try
            {
                DataTable dt = new DataTable();
                command = Schooldb.GetStoredProcCommand("SelectSchoolFeesPaymentsByClass", fees.Class1);
                dt = Schooldb.ExecuteDataSet(command).Tables[0];

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertExceptions(Exception ex)
        {
            try
            {
                DataTable dtable = new DataTable();
                command = Schooldb.GetStoredProcCommand("InsertExceptionDetails",ex.Message, ex.Source.ToString(), ex.TargetSite.ToString());
                Schooldb.ExecuteNonQuery(command);
                
            }
            catch (Exception e)
            {
                //databasehandler dh = new databasehandler();
                //dh.InsertExceptions(e);

                throw e;
               
            }
        }
    }
}
