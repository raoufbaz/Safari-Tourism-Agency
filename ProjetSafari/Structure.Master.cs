using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace ProjetSafari
{
    public partial class Structure : System.Web.UI.MasterPage
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlCommand cmd2;
        private SqlDataReader reader;
        public List<string> translation = new List<string>();
        public List<string> Langue = new List<string>();


        protected void Page_Load(object sender, EventArgs e)
        {
            this.FillText();
        }


        public void FillText()
        {
           
            this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");
            try
            {
                this.cmd = new SqlCommand("select txtgallery from master,langues where master.id_langue = langues.Id and langues.defaut = 1;", this.conn);
                this.cmd2 = new SqlCommand("select symbol from langues;", this.conn);

                this.conn.Open();
                this.reader = this.cmd.ExecuteReader();
                translation.Clear();
                while (reader.Read())
                {
                    translation.Add(reader["txtgallery"].ToString());


                }
                reader.Close();
                this.NavLbl1.Text = translation[0];
                this.NavLbl2.Text = translation[1];
                this.NavLbl3.Text = translation[2];
                this.NavLbl4.Text = translation[3];
               this.NavLbl5.Text = translation[4];
                this.NavLbl6.Text = translation[5];

                this.reader = this.cmd2.ExecuteReader();
                while (reader.Read())
                {
                   Langue.Add(reader["symbol"].ToString());

                }
                BtnLangue1.Text = Langue[0];
                BtnLangue2.Text = Langue[1];
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                this.conn.Close();
                this.reader.Close();
            }

        }

        protected void Btnlangue1_Click(object sender, EventArgs e)
        {
            this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");

            try
            {
                this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");
                this.cmd = new SqlCommand("update langues set defaut=0;", this.conn);
                //this.cmd2 = new SqlCommand("update langues set defaut=1 where symbol=@a", this.conn);
                //this.cmd2.Parameters.AddWithValue("@a", this.BtnLangue1.Text);
                this.conn.Open();
                int status = this.cmd.ExecuteNonQuery();
                conn.Close();

               this.cmd2 = new SqlCommand("update langues set defaut=1 where symbol=@a", this.conn);
              this.cmd2.Parameters.AddWithValue("@a", this.BtnLangue1.Text);
               this.conn.Open();
                int status2 = this.cmd2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                this.FillText();
                this.conn.Close();
            }

        }



        protected void Btnlangue2_Click(object sender, EventArgs e)
        {
            this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");

            try
            {
                this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");
                this.cmd = new SqlCommand("update langues set defaut=0;", this.conn);
                //this.cmd2 = new SqlCommand("update langues set defaut=1 where symbol=@a", this.conn);
                //this.cmd2.Parameters.AddWithValue("@a", this.BtnLangue1.Text);
                this.conn.Open();
                int status = this.cmd.ExecuteNonQuery();
                conn.Close();

                this.cmd2 = new SqlCommand("update langues set defaut=1 where symbol=@a", this.conn);
                this.cmd2.Parameters.AddWithValue("@a", this.BtnLangue2.Text);
                this.conn.Open();
                int status2 = this.cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                this.FillText();
                this.conn.Close();
            }
        }
    }
}