using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAcess
{
    public class ControlDatabase:connect
    {

        public DataTable ShowTable(string nameTable)
        {
           
            using(MySqlConnection cone = Connection())
            {
                MySqlCommand cmd = new MySqlCommand();

                MySqlDataReader rd;

                DataTable dt = new DataTable();

                cone.Open();

      
                cmd.Connection = cone;
                cmd.CommandText = "Select * " + nameTable;
                cmd.CommandType = CommandType.Text;

                rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;



            }
        }

        public DataTable SeachTable(string nameTable , string whereColumns , string seach)
        {

            using (MySqlConnection cone = Connection())
            {
                MySqlCommand cmd = new MySqlCommand();

                MySqlDataReader rd;

                DataTable dt = new DataTable();

                cone.Open();

                string formatText = string.Format("Select * {0} where {1} Link %{2}%", nameTable, whereColumns, seach);

                cmd.Connection = cone;
                cmd.CommandText = formatText;
                cmd.CommandType = CommandType.Text;

                rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;


            }

        }

        public void ExecuteNoQuery(string cmdText)
        {
            using (MySqlConnection cone = Connection())
            {
                MySqlCommand cmd = new MySqlCommand();

                cone.Open();

                cmd.Connection = cone;
                cmd.CommandText = cmdText;
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();               
              

            }

        }


    }
}
