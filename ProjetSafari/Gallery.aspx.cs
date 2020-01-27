using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetSafari
{
    public partial class Gallery : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public List<string> translation = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            FillText();
        }

        public void FillText()
        {

            this.conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\Users\raouf\Desktop\ASP\Travaux\ProjetSafari\App_Data\Safari.mdf");
            try
            {
                this.cmd = new SqlCommand("select txtgallery from gallery,langues where gallery.id_langue = langues.Id and langues.defaut = 1;", this.conn);

                this.conn.Open();
                this.reader = this.cmd.ExecuteReader();
                translation.Clear();
                while (reader.Read())
                {
                    translation.Add(reader["txtgallery"].ToString());


                }
                reader.Close();
                this.TitreGall.Text = translation[0];

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
    }
}