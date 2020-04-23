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
    public partial class RegisterLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove(Session.SessionID);
        }

        // Register Button
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
            SDA.InsertCommand.CommandText = "insert into tbl_users values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8 ,@p9,@p10,@p11,@p12,@p13,@p14,@p15)";

            SDA.InsertCommand.Parameters.AddWithValue("@p1", TextBox1.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p2", TextBox2.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p3", TextBox3.Text);

            string hash_pass = SocialNetProject.App_Code.UtilityClass.Hash_Me(TextBox4.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p4", hash_pass);

            string birthdate_str = DropDownList1.SelectedItem.ToString() + "/" + DropDownList2.SelectedValue.ToString() + "/" + DropDownList3.SelectedItem.ToString();
            SDA.InsertCommand.Parameters.AddWithValue("@p5", birthdate_str);

            byte g = 0;
            if (RadioButton1.Checked == true)
            {
                g = 0;
            }
            else
            {
                g = 1;
            }
            SDA.InsertCommand.Parameters.AddWithValue("@p6", g);

            SDA.InsertCommand.Parameters.AddWithValue("@p7", TextBox5.Text);
            SDA.InsertCommand.Parameters.AddWithValue("@p8", DropDownList4.SelectedValue.ToString());

            // default coulum values
            // profile image
            SDA.InsertCommand.Parameters.AddWithValue("@p9", "~/images/profile_image.png");
            // background image
            SDA.InsertCommand.Parameters.AddWithValue("@p10", "~/images/covers/1.jpg");
            // short bio
            SDA.InsertCommand.Parameters.AddWithValue("@p11", "this is me!!");
            // about me
            SDA.InsertCommand.Parameters.AddWithValue("@p12", "about me!!");
            // online status
            SDA.InsertCommand.Parameters.AddWithValue("@p13", 0);
            // account date
            SDA.InsertCommand.Parameters.AddWithValue("@p14", DateTime.Now.ToShortDateString());
            // profile views
            SDA.InsertCommand.Parameters.AddWithValue("@p15", 0);

            // Step 3 -- exectute ( send ) command to sql to run
            SDA.InsertCommand.ExecuteNonQuery();


            SC.Close();


        }


        // Login Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Remove(Session.SessionID);
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.Connection = SC;
            SDA2.SelectCommand.CommandType = CommandType.Text;
            SDA2.SelectCommand.CommandText = "select * from tbl_users where users_email=@p1 and users_password=@p2";

            SDA2.SelectCommand.Parameters.AddWithValue("@p1", txtEmail.Text);
            string hash_pass = SocialNetProject.App_Code.UtilityClass.Hash_Me(txtPass.Text);
            SDA2.SelectCommand.Parameters.AddWithValue("@p2", hash_pass);

            // Step 3 -- Run and store results
            DataSet DS = new DataSet();
            SDA2.Fill(DS);

            // Step 4 -- Check incomming
            if ( DS.Tables[0].Rows.Count != 0)
            {
                // User/Pass is correct
                Session["UserID"] = DS.Tables[0].Rows[0]["users_id"].ToString();

                Session["FullName"] = DS.Tables[0].Rows[0]["first_name"].ToString() + " " + DS.Tables[0].Rows[0]["last_name"].ToString();

                Session["ProfileImage"] = DS.Tables[0].Rows[0]["profile_image"].ToString().Replace("~", "..");

                Session["CoverImage"] = DS.Tables[0].Rows[0]["background_image"].ToString().Replace("~","..");

                Session["ShortBio"] = DS.Tables[0].Rows[0]["short_bio"].ToString();

                Response.Redirect("TimeLine.aspx?me=1");

            }
            else
            {
                // User/Pass is Incorrect
                lblNote.ForeColor = System.Drawing.Color.Red;
                lblNote.Text = "Email or Password is incorrect!";
            }


        }
    }
}