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
    public partial class LoadComments : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //we can use the object sender
            string postID = ((sender as LoadComments).Parent.FindControl("lbl_postID3") as Label).Text;
            Int32 pID = Convert.ToInt32(postID);
            Load_Comments(pID);
            //Load_Comments();
        }
        //load the template, propagate the repeater
        protected void Load_Comments(Int32 pID)
        {
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn1"].ToString();
            SC.Open();

            // Step 2 -- Create Command 
            SqlDataAdapter SDA2 = new SqlDataAdapter();
            SDA2.SelectCommand = new SqlCommand();
            SDA2.SelectCommand.Connection = SC;
            SDA2.SelectCommand.CommandType = CommandType.Text;
            SDA2.SelectCommand.CommandText = "select * from tbl_comments inner join tbl_users on tbl_comments.users_id = tbl_users.users_id where post_id = @p1";

            SDA2.SelectCommand.Parameters.AddWithValue("@p1", pID);


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


        //justfor your informations
        //this is how you can create a property for a user_control
      /*  public string PostID
        {
            get  //when called
            {
            }

            set //when you define it
            {

            }
        }*/

        //users1.PostID
    }

}