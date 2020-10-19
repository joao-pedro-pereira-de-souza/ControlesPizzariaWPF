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

        public bool VerificarDado(string cmd)
        {
            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();

            return bd.VerificaDado(cmd);

        }

        public DataTable ShowTable(string table)
        {
            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();

           return bd.ShowTable(table);


        }

    }
}
