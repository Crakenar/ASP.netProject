using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SocialNetProject
{
    public partial class TimeLine : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string SetFullName()
        {
            return (Session["FullName"] != null ? Session["FullName"].ToString() : "default name") ;
        }

       public string SetBio()
        {
            return (Session["ShortBio"] != null ? Session["ShortBio"].ToString() : "default bio");
        }

       public string SetCover()
        {
            return (Session["CoverImage"] != null ? Session["CoverImage"].ToString() : "../");
        }

       public string SetProfileImage()
        {
            return (Session["ProfileImage"] != null ? Session["ProfileImage"].ToString() : "../");
        }
    }
}