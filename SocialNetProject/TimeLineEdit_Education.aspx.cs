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
    public partial class TimeLineEdit_Education : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] != null) // To check if youy are logged in ! ( this is My ID )
            {

                if (Request.QueryString["uID"] != null) // Someone else ID --> that I want to load data for !
                    Load_Data(Request.QueryString["uID"].ToString());
                else // Load My Info
                    Load_Data("-1");

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


        // New Post Button
        // insert into user_education table
        // becareful about useres_id !
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // STep 2 -- Create the command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.Connection = SC;
            SDA.InsertCommand.CommandText = "insert into tbl_education values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";

            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            SDA.InsertCommand.Parameters.AddWithValue("@p1", ID);
            if (RadioButton1.Checked == true) { 
                SDA.InsertCommand.Parameters.AddWithValue("@p2", 0);
            } else {
                    SDA.InsertCommand.Parameters.AddWithValue("@p2", 1);
            }
           
            SDA.InsertCommand.Parameters.AddWithValue("@p3",TextBox1.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p4", TextBox2.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p5", TextBox3.Text);
            if (CheckBox1.Checked == true) {
                SDA.InsertCommand.Parameters.AddWithValue("@p6",1 );
            }else
            {
                SDA.InsertCommand.Parameters.AddWithValue("@p6",0);
            }
            SDA.InsertCommand.Parameters.AddWithValue("@p7", TextBox4.Text);
            SDA.InsertCommand.ExecuteNonQuery();
            SC.Close();

            Response.Redirect("TimeLine.aspx");
        }
    }
}