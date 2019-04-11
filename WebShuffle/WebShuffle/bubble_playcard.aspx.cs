using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShuffle
{
    public partial class bubble_playcard : System.Web.UI.Page
    {       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class PlaycardContent
        {
            string[] cards = { "A", "5", "2", "9", "8", "7", "12", "13", "3" };
            
        }
    }
}