using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl.controls
{
    public partial class ActiveActor : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetImageUrl(string url)
        {
            this.imgActor.ImageUrl = url;
        }
    }
}