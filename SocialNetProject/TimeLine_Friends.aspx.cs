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
    public partial class TimeLine_Friends : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null) // To check if youy are logged in ! ( this is My ID )
            {
                if (Request.QueryString["me"] != null && Request.QueryString["me"].ToString() == "1") //if this is me ! calling back to my page
                {
                    Session.Remove("uID");
                }

                if (Session["uID"] != null) // Someone else ID or some1 else --> that I want to load data for !
                {
               
                    Load_Friends(Session["uID"].ToString());
                }
                else // Load My Info
                {
                    Load_Friends("-1");
   
                }

            }
        }

        public string SetImagePath(object o)
        {
            return o.ToString().Replace("~", "..");
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string uID = ((sender as LinkButton).Parent.FindControl("lblID") as Label).Text;
            Session["uID"] = uID; //this is some1 else ID
            Response.Redirect("TimeLine.aspx");
        }

        public void Load_Friends(string uID)
        {
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.Connection = SC;
            SDA2.SelectCommand.CommandType = CommandType.Text;
            // SDA2.SelectCommand.CommandText = "select * from tbl_users where users_id != @p1 AND users_id NOT IN(select user_id_1 from tbl_friendships) AND users_id NOT IN(select user_id_2 from tbl_friendships)";
            SDA2.SelectCommand.CommandText = "select distinct users_id,first_name,last_name,profile_image,background_image,about_me from tbl_users,tbl_friendships where users_id != @p1 and @p1 in 	(select user_id_1 from tbl_friendships) or @p1 in (select user_id_1 from tbl_friendships)";
            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            Int32 localID = Convert.ToInt32(uID);  // Someone else ID

            if (localID == -1)
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", ID);
            else
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", localID);

            // Step 3 --- Store Data
            DataSet DS = new DataSet();
            SDA2.Fill(DS);

            // Step 4 -- 
            if (DS.Tables[0].Rows.Count != 0)
            {
                Repeater1.DataSource = DS.Tables[0];
                Repeater1.DataBind(); // Refresh Data Source
            }
            SC.Close();

        }
    }
}