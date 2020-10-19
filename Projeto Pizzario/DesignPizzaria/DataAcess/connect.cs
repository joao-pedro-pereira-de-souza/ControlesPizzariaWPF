using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAcess
{
    public class connect
    {
         protected  MySqlConnection Connection()
         {
            return new MySqlConnection("datasource=localhost;uid=root;password='';database=bdPizzaria");
         }
    }
}
