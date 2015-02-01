using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl.controls
{
    public partial class PageTemplate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SetPageNumber(string page)
        {
            this.liPage.Attributes.Add("data-slide-to", page);
        }

        public void SetActorName(string name)
        {
            this.actorName.InnerText = name;
        }
    }
}