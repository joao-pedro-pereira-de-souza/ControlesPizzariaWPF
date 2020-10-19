using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControlUser
{
    public class ControlDatabase
    {

        public bool VerificarDado(string nameTable, string whereColumns, string seach)
        {
            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();

            DataTable dt = bd.SeachTable(nameTable, whereColumns, seach);

            if(dt.Rows == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public DataTable ShowTable(string table)
        {
            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();

           return bd.ShowTable(table);


        }

    }
}
