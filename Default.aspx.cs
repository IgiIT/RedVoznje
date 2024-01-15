using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedVoznje
{
    public partial class _Default : Page
    {
        public string conStr = "Data Source=DESKTOP-CK9VBS0\\SQLEXPRESS;Initial Catalog=rezervacije;Integrated Security=True";
        public const int MIN_SEDISTA = 2;
        public const int MAX_SEDISTA = 53;
        public List<int> rezervisana = new List<int>();
        private List<Button> mesta = new List<Button>();
        protected void Page_Load(object sender, EventArgs e)
        {
            iscitaj();
            //kreirajMesta();
            //kreirajTabelu();
        }
        public bool rezervisano(int sediste)
        {
            foreach(int broj in rezervisana)
            {
                if (broj == sediste)
                {
                    return true;
                }
            }
            return false;
        }
        public void iscitaj()
        {
            string select = "select brojSedista from sedista";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;

            SqlCommand cmd = new SqlCommand(select, con);

            SqlDataReader reader;

            using (con)
            {
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rezervisana.Add(Int32.Parse(reader["brojSedista"].ToString()));
                    }
                    reader.Close();
                    con.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        protected void btn_Click(object sender, EventArgs e)
        {

        }
    }
}