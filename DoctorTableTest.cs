using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;






namespace session6
{
    class DoctorTableTest
    {




        static void Main(string[] args)
        {
            try
            {
                DotorTable objDoctorTable = new DotorTable();
                objDoctorTable.AcceptDetail();
                objDoctorTable.DisplayDetail();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("/nSelect one of the following options:");
                    Console.WriteLine(" 1. Remove \n 2.Remove All \n 3. Search \n 4. Exit ");
                    Console.Write("Enter your choice :");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            if (objDoctorTable.Remove())
                            {
                                Console.WriteLine("\n----- After Removing-----");
                                objDoctorTable.DisplayDetail();
                            }
                            else
                                Console.WriteLine("Dotor with this namr does not exits");
                            break;
                        case 2:
                            objDoctorTable.objDoctorDetails.Clear();
                            Console.WriteLine("\n-----After removing all the doters-----");
                            Console.WriteLine("Total number of doctors :" + objDoctorTable.objDoctorDetails.Count);
                            return;
                        case 3:
                            objDoctorTable.Search();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }

        }
    }
}

