using GridViewApplication.Dados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewApplication
{
    public partial class TesteLigacao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ligacao = Ligacao.Criar())
                {
                    ligacao.Open();
                    lblResultado.Text = "Ligou ao servidor " + ligacao.DataSource
                        + ", base " + ligacao.Database;
                }
            }
            catch (SqlException ex)
            {
                lblResultado.Text = "Erro: " + ex.Message;
            }

        }
    }
}