using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShuffle
{
    public partial class WebSortPlayCard : System.Web.UI.Page
    {
        List<string> tempCard;
        List<string> showCard;
        List<int> CardID = new List<int>();  //1~52

        protected void Page_Load(object sender, EventArgs e)
        {
            for(int i=1;i<53;i++)
            {
                //CardID.Add(i);
          

                int suitnum;
                if(i%13!=0)
                {
                    suitnum = i / 13;
                }
                else
                {
                    suitnum = i / 13 - 1;
                }

                switch(suitnum)
                {
                    case 0:
                        Response.Write("Club" + GetDispalyNum(i % 13) + "\t");
                     break;
                    case 1:
                        Response.Write("Diamond" + GetDispalyNum(i % 13) + "\t");
                        break;
                    case 2:
                        Response.Write("Heart" + GetDispalyNum(i % 13) + "\t");
                        break;
                    default:
                        Response.Write("Spade" + GetDispalyNum(i % 13) + "\t");
                        break;
                }      
                
            }

            string GetDispalyNum(int cardno)
            {
                string show="";

                //12,13 花色錯
                switch (cardno)
                {
                    case 1:
                        show = "A";
                        break;
                    case 11:
                        show = "J";
                        break;
                    case 12:
                        show = "Q";
                        break;
                    case 0:
                        show = "K <br/>";
                        break;
                    default:
                        show = cardno.ToString();
                        break;
                }
                return show;
            }
        }
    }
}