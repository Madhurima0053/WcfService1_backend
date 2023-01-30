using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=LTIN289725\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable (Name, Address, Pin, Phone, Email) values( @Name , @Address , @Pin , @Phone , @Email)", con);
            cmd.Parameters.AddWithValue("Name", userInfo.Name);
            cmd.Parameters.AddWithValue("Address", userInfo.Address);
            cmd.Parameters.AddWithValue("Pin", userInfo.Pin);   
            cmd.Parameters.AddWithValue("Phone", userInfo.Phone);
            cmd.Parameters.AddWithValue("Email", userInfo.Email);
            int result = cmd.ExecuteNonQuery();
            if(result == 1)
            {
                Message = userInfo.Name + "Details inserted successfully";
            }
            else
            {
                Message = userInfo.Name + "Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
