using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace vetApp
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LENOVOA9; DATABASE=BD_VETERINARIA; integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
