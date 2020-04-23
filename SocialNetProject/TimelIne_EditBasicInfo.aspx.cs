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
    public partial class TimelIne_EditBasicInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Session["UserID"] != null)
                    Load_Data();
        }

        public void Load_Data()
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
            Int32 ID = Convert.ToInt32(Session["UserID"].ToString());
            SDA2.SelectCommand.Parameters.AddWithValue("@p1", ID);

            // Step 3 -- Run and store results
            DataSet DS = new DataSet();
            SDA2.Fill(DS);

            // Step 4 -- Check incomming
            if (DS.Tables[0].Rows.Count != 0)
            {
                // Fill the Edit Form
                TextBox1.Text = DS.Tables[0].Rows[0]["first_name"].ToString();
                TextBox2.Text = DS.Tables[0].Rows[0]["last_name"].ToString();

                string birthdate_str = DS.Tables[0].Rows[0]["birthdate"].ToString();
                string[] tmp = birthdate_str.Split('/');
                DropDownList1.Text = tmp[0];
                DropDownList2.Text = tmp[1];
                DropDownList3.Text = tmp[2];

                string gender_sw = DS.Tables[0].Rows[0]["gender"].ToString();
                RadioButton1.Checked = (gender_sw == "0");
                RadioButton2.Checked = (gender_sw == "1");

                TextBox5.Text = DS.Tables[0].Rows[0]["city"].ToString();
                DropDownList4.SelectedValue = DS.Tables[0].Rows[0]["country"].ToString();

                TextBox3.Text = DS.Tables[0].Rows[0]["short_bio"].ToString();
                TextBox4.Text = DS.Tables[0].Rows[0]["about_me"].ToString();

                Image1.ImageUrl = DS.Tables[0].Rows[0]["profile_image"].ToString();
                Image2.ImageUrl = DS.Tables[0].Rows[0]["background_image"].ToString();

                // Update Session Variables
                Session["FullName"] = DS.Tables[0].Rows[0]["first_name"].ToString() + " " + DS.Tables[0].Rows[0]["last_name"].ToString();
                Session["ProfileImage"] = DS.Tables[0].Rows[0]["profile_image"].ToString().Replace("~", "..");
                Session["CoverImage"] = DS.Tables[0].Rows[0]["background_image"].ToString().Replace("~", "..");
                Session["ShortBio"] = DS.Tables[0].Rows[0]["short_bio"].ToString();

            }
        }


        // Edit Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Step 1 -- Create a connection to Databse
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // STep 2 -- Create the command
            SqlDataAdapter SDA = new SqlDataAdapter();
            SDA.UpdateCommand = new SqlCommand();
            SDA.UpdateCommand.CommandType = CommandType.Text;
            SDA.UpdateCommand.Connection = SC;
            SDA.UpdateCommand.CommandText = "update tbl_users set first_name=@p1,last_name=@p2,birthdate=@p5,gender=@p6,city=@p7,country=@p8 ,profile_image=@p9, background_image=@p10, short_bio=@p11, about_me=@p12 where users_id=@p20";

            Int32 ID = Convert.ToInt32(Session["UserID"].ToString());
            SDA.UpdateCommand.Parameters.AddWithValue("@p20", ID);

            SDA.UpdateCommand.Parameters.AddWithValue("@p1", TextBox1.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p2", TextBox2.Text);

            string birthdate_str = DropDownList1.SelectedItem.ToString() + "/" + DropDownList2.SelectedValue.ToString() + "/" + DropDownList3.SelectedItem.ToString();
            SDA.UpdateCommand.Parameters.AddWithValue("@p5", birthdate_str);

            byte g = 0;
            if (RadioButton1.Checked)
                g = 0;
            else
                g = 1;
  
            SDA.UpdateCommand.Parameters.AddWithValue("@p6", g);

            SDA.UpdateCommand.Parameters.AddWithValue("@p7", TextBox5.Text);
            SDA.UpdateCommand.Parameters.AddWithValue("@p8", DropDownList4.SelectedValue.ToString());

            // default coulum values
            // profile image
            SDA.UpdateCommand.Parameters.AddWithValue("@p9", Image1.ImageUrl);
            // background image
            SDA.UpdateCommand.Parameters.AddWithValue("@p10", Image2.ImageUrl);
            // short bio
            SDA.UpdateCommand.Parameters.AddWithValue("@p11", TextBox3.Text);
            // about me
            SDA.UpdateCommand.Parameters.AddWithValue("@p12", TextBox4.Text);

            // Step 3 -- exectute ( send ) command to sql to run
            SDA.UpdateCommand.ExecuteNonQuery();

            SC.Close();

            // Call Load Data Function
            Load_Data();

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

        //Profile Upload Cover Photo
        protected void uploadBtn2_Click(object sender, EventArgs e)
        {
            lbl_error2.Text = ""; // Path.GetExtentiob
            if (FileUpload2.HasFiles)
            {
                string rnd_number = DateTime.Now.Ticks.ToString();
                string virtual_path = "~/images/" + FileUpload1.FileName + "_" + rnd_number + ".jpg";
                string pysical_path = Server.MapPath(virtual_path);
                FileUpload2.SaveAs(pysical_path);
                lbl_error2.Text = "file has been uploaded successfully";
                lbl_error2.ForeColor = System.Drawing.Color.Green;
                Image2.ImageUrl = virtual_path;
            }
            else
            {
                lbl_error2.Text = "please select a file";
                lbl_error2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}