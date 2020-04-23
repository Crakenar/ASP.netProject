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
    public partial class TimeLine_EditAlbum : System.Web.UI.Page
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

        // Profile Upload Photo
        protected void uploadBtn_Click(object sender, EventArgs e)
        {
            lbl_error.Text = ""; // Path.GetExtentiob
            if (FileUpload1.HasFiles)
            {
                string rnd_number = DateTime.Now.Ticks.ToString();
                string virtual_path = "~/images/" + FileUpload1.FileName + "_" + rnd_number + ".jpg";
                string pysical_path = Server.MapPath(virtual_path);
                FileUpload1.SaveAs(pysical_path);
                lbl_error.Text = "file has been uploaded successfully";
                lbl_error.ForeColor = System.Drawing.Color.Green;
                Image1.ImageUrl = virtual_path;
            }
            else
            {
                lbl_error.Text = "please select a file";
                lbl_error.ForeColor = System.Drawing.Color.Red;
            }
        }


        // New Post Button
        // insert into user posts table
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
            SDA.InsertCommand.CommandText = "insert into tbl_album values (@p1,@p2,@p3)";

            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            SDA.InsertCommand.Parameters.AddWithValue("@p1", ID);
            SDA.InsertCommand.Parameters.AddWithValue("@p2", DateTime.Now.Ticks);
            SDA.InsertCommand.Parameters.AddWithValue("@p3", Image1.ImageUrl);


            SDA.InsertCommand.ExecuteNonQuery();
            SC.Close();

            Response.Redirect("TimeLine.aspx");
        }
    }
}