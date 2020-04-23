using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SocialNetProject
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] != null) // To check if youy are logged in ! ( this is My ID )
            {
                if (Session["UserID"].ToString() == "3")
                    Load_Data();
                else
                    Response.Redirect("AccessDenied.aspx");
            }
            else
            {
                Response.Redirect("RegisterLogin.aspx");
            }
            

        }
        public void Load_Data() { 
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

                // Step 2 -- Create Command 
                SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.Connection = SC;
                SDA2.SelectCommand.CommandType = CommandType.Text;
                SDA2.SelectCommand.CommandText = "select * from tbl_users";

                // Step 3 --- Store Data
                DataSet DS = new DataSet();
            SDA2.Fill(DS);

                // Step 4 -- 
                if (DS.Tables[0].Rows.Count != 0)
                {
                
                    GridView1.DataSource = DS.Tables[0];
                    GridView1.DataBind(); // Refresh Data Source
                }
             SC.Close();
        }

        protected void Button1_Click(object o, EventArgs e)
        {

            string userID = ((o as Button).Parent.FindControl("Label1") as Label).Text;

            //Step 1 Create a connection to Database
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString(); // to connect where ? what ? how ?
            SC.Open();

            //Step 2 -- Create Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.DeleteCommand = new SqlCommand();
            SDA.DeleteCommand.Connection = SC;
            SDA.DeleteCommand.CommandType = CommandType.Text;
            SDA.DeleteCommand.CommandText = "DELETE FROM tbl_users where users_id=@p1";


            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(userID));

            SDA.DeleteCommand.ExecuteNonQuery();

            SC.Close();
            Load_Data();


        }

    }
}