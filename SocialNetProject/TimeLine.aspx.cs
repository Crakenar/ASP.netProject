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
    public partial class TimeLine1 : System.Web.UI.Page
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
                    Load_Posts(Session["uID"].ToString());
                }
                else // Load My Info
                {
                    Load_Data("-1");
                    Load_Posts("-1");
                }

            }
        }

        public void Load_Data( string uID )
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

            if (localID == -1 )
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

        public void Load_Posts( string uID )
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
            SDA2.SelectCommand.CommandText = "select * from tbl_posts where users_id=@p1";

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

        public string SetImagePath(object o)
        {
            return o.ToString().Replace("~", "..");
        }

        public string SetPrettyDate(object o)
        {
            Int64 dt_ticks = Convert.ToInt64(o.ToString());
            DateTime dt = new DateTime(dt_ticks);
            return dt.ToShortDateString() ;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string postID = ((sender as LinkButton).Parent.FindControl("lbl_postID") as Label).Text;

            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.UpdateCommand = new SqlCommand();
            SDA2.UpdateCommand.Connection = SC;
            SDA2.UpdateCommand.CommandType = CommandType.Text;
            SDA2.UpdateCommand.CommandText = "update tbl_posts set post_dislike = post_dislike +1 where post_id = @p1 ";

            SDA2.UpdateCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(postID));
            SDA2.UpdateCommand.ExecuteNonQuery();

            Factorized("Dislikes");
            SC.Close();


            if (Request.QueryString["uID"] != null) // Someone else ID --> that I want to load data for !
            {
                Load_Posts(Request.QueryString["uID"].ToString());
            }
            else // Load My Info
            {
                Load_Posts("-1");
            }
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string postID = ((sender as LinkButton).Parent.FindControl("lbl_postID") as Label).Text;

            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.UpdateCommand = new SqlCommand();
            SDA2.UpdateCommand.Connection = SC;
            SDA2.UpdateCommand.CommandType = CommandType.Text;
            SDA2.UpdateCommand.CommandText = "update tbl_posts set post_like = post_like +1 where post_id = @p1 ";

            SDA2.UpdateCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(postID));
            SDA2.UpdateCommand.ExecuteNonQuery();


            Factorized("Likes");
            SC.Close();


            if (Request.QueryString["uID"] != null) // Someone else ID --> that I want to load data for !
            {
                Load_Posts(Request.QueryString["uID"].ToString());
            }
            else // Load My Info
            {
                Load_Posts("-1");
            }
        }

        public bool SetVisibility()
        {
            if (Request.QueryString["uID"] != null) //some1else page
                return false;
            else
                return true;
        }

        protected void LinkButton3_Click(Object o, EventArgs e)
        {

            string postID = ((o as LinkButton).Parent.FindControl("lbl_postID") as Label).Text;

            //Step 1 Create a connection to Database
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString(); // to connect where ? what ? how ?
            SC.Open();

            //Step 2 -- Create Command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.DeleteCommand = new SqlCommand();
            SDA.DeleteCommand.Connection = SC;
            SDA.DeleteCommand.CommandType = CommandType.Text;
            SDA.DeleteCommand.CommandText = "DELETE FROM tbl_posts where post_id=@p1 and users_id=@p2";


            Int32 ID = Convert.ToInt32(Session["UserID"].ToString());
            SDA.DeleteCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(postID));
            SDA.DeleteCommand.Parameters.AddWithValue("@p2", ID);

            SDA.DeleteCommand.ExecuteNonQuery();

            SC.Close();

            if (Request.QueryString["uID"] != null) //someone else id I want load data for !
            {
                //Load_Data(Request.QueryString["uID"].ToString());
                Load_Posts(Request.QueryString["uID"].ToString());
            }
            else //load my Info
            {
              //  Load_Data("-1");
                Load_Posts("-1");
            }


            

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string postID = ((sender as Button).Parent.FindControl("lbl_postID2") as Label).Text;
            string comentText = ((sender as Button).Parent.FindControl("txt_comment_text") as TextBox).Text;

            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // STep 2 -- Create the command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.Connection = SC;
            SDA.InsertCommand.CommandText = "insert into tbl_comments values (@p1,@p2,@p3)";

            Int32 postIDX = Convert.ToInt32(postID);
            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            SDA.InsertCommand.Parameters.AddWithValue("@p1", postIDX);
            SDA.InsertCommand.Parameters.AddWithValue("@p2",ID);
            SDA.InsertCommand.Parameters.AddWithValue("@p3", comentText);

            Factorized("comments");
            SDA.InsertCommand.ExecuteNonQuery();
            SC.Close();

            //Response.Redirect("TimeLine.aspx");
        }

        protected void Factorized(string type)
        {

            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.InsertCommand = new SqlCommand();
            SDA.InsertCommand.Connection = SC;
            SDA.InsertCommand.CommandType = CommandType.Text;
            SDA.InsertCommand.CommandText = "insert into tbl_activity values (@p1,@p4,@p5)";
            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            SDA.InsertCommand.Parameters.AddWithValue("@p1", ID);
            SDA.InsertCommand.Parameters.AddWithValue("@p4", DateTime.Now.Ticks);
            SDA.InsertCommand.Parameters.AddWithValue("@p5", type);
            SDA.InsertCommand.ExecuteNonQuery();
            SC.Close();
        }

    }
}