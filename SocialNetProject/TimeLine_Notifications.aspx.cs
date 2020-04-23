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
    public partial class TimeLine_Notifications : System.Web.UI.Page
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

                    Load_Activity(Session["uID"].ToString());
                    load_FriendRequests(Session["uID"].ToString());
                }
                else // Load My Info
                {
                    Load_Activity("-1");
                    load_FriendRequests("-1");

                }

            }
        }

        public void Load_Activity(string uID)
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
            //+ all his friends ???
            SDA2.SelectCommand.CommandText = "select * from tbl_activity,tbl_users where tbl_users.users_id = @p1 and tbl_users.users_id = tbl_activity.users_id ";



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


        public void load_FriendRequests(string uID)
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
            //+ all his friends ???
            SDA2.SelectCommand.CommandText = "select * from tbl_friendships where user_id_2 = @p1 and friendship_status = 'Request'";



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
                Repeater2.DataSource = DS.Tables[0];
                Repeater2.DataBind(); // Refresh Data Source
            }
            SC.Close();

        }

        //Add the person to your friend list
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //(sender as LinkButton).Text = "Delete";

            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // STep 2 -- Create the command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.Connection = SC;
            SDA.UpdateCommand.CommandText = "update tbl_friendships set friendship_status = 'Friends'  where user_id_1 = @p2 and user_id_2 = @p1 and friendship_status = @p4";


            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID

            //ID for the other one == button1click
            string uID = ((sender as LinkButton).Parent.FindControl("lblID") as Label).Text;
            Int32 ID2 = Int32.Parse(uID);
            SDA.UpdateCommand.Parameters.AddWithValue("@p1", ID);
            SDA.UpdateCommand.Parameters.AddWithValue("@p2", ID2);
            SDA.UpdateCommand.Parameters.AddWithValue("@p3", "Friend");
            SDA.UpdateCommand.Parameters.AddWithValue("@p4", "Request");
            SDA.UpdateCommand.ExecuteNonQuery();
            SC.Close();


            Response.Redirect("TimeLine_Notifications.aspx");

        }


        public string SetPrettyDate(object o)
        {
            Int64 dt_ticks = Convert.ToInt64(o.ToString());
            DateTime dt = new DateTime(dt_ticks);
            return dt.ToShortDateString();
        }
    }
}