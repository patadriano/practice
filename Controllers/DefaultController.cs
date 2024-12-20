using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;



namespace SimpleCRUD.Controllers
{
    public class DefaultController
    {
        public void PersonTable(Model person) {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                string query = $"insert into Person (Name, Age) values ('{person.Name}','{person.Age}')";

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //using (SqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Employee temp = new Employee();
                    //        temp.Name = reader["Name"].ToString();
                    //        temp.Address = reader["Address"].ToString();

                    //        ldata.Add(temp);
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
            }

        }
    }
}