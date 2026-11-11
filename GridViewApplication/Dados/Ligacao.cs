using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GridViewApplication.Dados
{
    public class Ligacao
    {
        public static SqlConnection Criar()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["Gestao_BibliotecaConnectionString1"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}