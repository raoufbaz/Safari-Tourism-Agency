using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetSafari
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nom = Request["nom"].ToString();
            string email = Request["email"].ToString();
            string phone = Request["phone"].ToString();
            string message = Request["message"].ToString();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");
            string feedback = "";
            try
            {

               
                SqlCommand cmd = new SqlCommand("insert into contact(nom,email,phone,message) values(@n,@e,@p,@m);", conn);
                cmd.Parameters.AddWithValue("@n",nom);
                cmd.Parameters.AddWithValue("@e",email);
                cmd.Parameters.AddWithValue("@p",phone);
                cmd.Parameters.AddWithValue("@m",message);
                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result != 1)
                {
                    feedback = "il y a eu un probleme";
                }
                else
                {
                    feedback = "Good job";
                }

                Response.Write(feedback);

            }
            catch (Exception ex)
            {
                feedback = ex.Message;
                Response.Write(feedback);
            }
            finally
            {
                conn.Close();
            }


        }




    }


}
