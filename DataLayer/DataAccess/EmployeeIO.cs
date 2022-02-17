using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DataLayer.Business;

namespace DataLayer.DataAccess
{
    public static class EmployeeIO
    {
        const string dir = @"";

        const string filepath = dir + "employee.dat";

        public static void SaveRecord(Employee emp)
        {
            StreamWriter sw = new StreamWriter(filepath,true);
            sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName);
            MessageBox.Show("Data Successfully Saved");
            sw.Close();
        }

        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee();

            if (File.Exists(filepath))
            {
                StreamReader sr = new StreamReader(filepath);
                string line = sr.ReadLine();
                bool found = false;

                while (line != null)
                {
                    string[] fields = line.Split(',');
                }
            }
        }
    }
}
