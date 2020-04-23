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
    public partial class TimeLine_EditSettings : System.Web.UI.Page
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

                    load_Settings(Session["uID"].ToString());
                }
                else // Load My Info
                {
                    load_Settings("-1");

                }

            }
        }

        public void load_Settings(string uID)
        {
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            //We display all the friend that can be add => that are not our friends already
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.Connection = SC;
            SDA2.SelectCommand.CommandType = CommandType.Text;
            SDA2.SelectCommand.CommandText = "select * from tbl_settings where users_id = @p1";



            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID
            Int32 localID = Convert.ToInt32(uID);  // Someone else ID

            if (localID == -1)
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", ID);
            else
                SDA2.SelectCommand.Parameters.AddWithValue("@p1", localID);

            if()

            // Step 3 --- Store Data
            DataSet DS = new DataSet();
            SDA2.Fill(DS);

            SC.Close();

        }


        protected void Button1_Click(object sender, EventArgs e)
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
            SDA.UpdateCommand.CommandText = "update tbl_settings set send_request = ,notifications = ,online_status =  where users_id = @p1 and user_id_2 = @p1 and friendship_status = @p4";

            SDA.UpdateCommand.CommandText = "update tbl_settings set send_request = @p2, notifications = @p3 , online_status = @p2,sounds = @p6, messages =@p4 , tagging = @p5 where users_id=@p1";
            Int32 ID = Convert.ToInt32(Session["UserID"].ToString()); // My ID

            //ID for the other one == button1click

            SDA.UpdateCommand.Parameters.AddWithValue("@p1", ID);

            byte follow = 0;
            byte notif = 0;
            byte messages = 0;
            byte tagging = 0;
            byte sounds = 0;
            if (RadioButton1.Checked)
            {
                follow = 0;
            }
            else
            {
                follow = 1;
            }



            if (RadioButton3.Checked)
            {
                notif = 0;
            }
            else
            {
                notif = 1;
            }



            if (RadioButton5.Checked)
            {
                messages = 0;
            }
            else
            {
                messages = 1;
            }


            if (RadioButton7.Checked)
            {
                tagging = 0;
            }
            else
            {
                tagging = 1;
            }


            if (RadioButton9.Checked)
            {
                sounds = 0;
            }
            else
            {
                sounds = 1;
            }

            SDA.UpdateCommand.Parameters.AddWithValue("@p2", follow);
            SDA.UpdateCommand.Parameters.AddWithValue("@p3", notif);
            SDA.UpdateCommand.Parameters.AddWithValue("@p4", messages);
            SDA.UpdateCommand.Parameters.AddWithValue("@p5", tagging);
            SDA.UpdateCommand.Parameters.AddWithValue("@p6", sounds );
            SDA.UpdateCommand.ExecuteNonQuery();
            SC.Close();


            Response.Redirect("TimeLine_Settings.aspx");
        }
    }
}