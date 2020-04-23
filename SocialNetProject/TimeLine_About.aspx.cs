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
    public partial class TimeLine_About : System.Web.UI.Page
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
                    Load_Data(Session["uID"].ToString());
                    Load_AboutInfo(Session["uID"].ToString());
                }
                else // Load My Info
                {
                    Load_Data("-1");
                    Load_AboutInfo("-1");
                }

            }
        }

        public void Load_Data(string uID)
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
            SDA2.SelectCommand.CommandText = "select * from tbl_users where users_id=@p1";

            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            Int32 localID = Convert.ToInt32(uID);  // Someone else ID

            if (localID == -1)
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", ID);
            else
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", localID);

            // Step 3 -- Run and store results
            DataSet DS = new DataSet();
            SDA2.Fill(DS);

            // Step 4 -- Check incomming
            if (DS.Tables[0].Rows.Count != 0)
            {
                // Update Session Variables
                Session["FullName"] = DS.Tables[0].Rows[0]["first_name"].ToString() + " " + DS.Tables[0].Rows[0]["last_name"].ToString();
                Session["ProfileImage"] = DS.Tables[0].Rows[0]["profile_image"].ToString().Replace("~", "..");
                Session["CoverImage"] = DS.Tables[0].Rows[0]["background_image"].ToString().Replace("~", "..");
                Session["ShortBio"] = DS.Tables[0].Rows[0]["short_bio"].ToString();
            }

        }


        public void Load_AboutInfo(string uID)
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
            SDA2.SelectCommand.CommandText = "select * from tbl_education inner join tbl_users on tbl_education.users_id = tbl_users.users_id where tbl_users.users_id=@p1";

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
                //filing a sttatic label
                Label1.Text = DS.Tables[0].Rows[0]["about_me"].ToString();
                Label2.Text = DS.Tables[0].Rows[0]["city"].ToString() + "|" + DS.Tables[0].Rows[0]["country"].ToString();
                Label3.Text = DS.Tables[0].Rows[0]["birthdate"].ToString();
                Label4.Text = DS.Tables[0].Rows[0]["account_date"].ToString();

                //feed repeater date source (work experience etc.)
                Repeater1.DataSource = DS.Tables[0];
                Repeater1.DataBind(); // Refresh Data Source
            }
            SC.Close();

        }
    }
}