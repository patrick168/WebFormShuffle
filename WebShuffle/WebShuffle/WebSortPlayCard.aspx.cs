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
        protected void Page_Load(object sender, EventArgs e)
        {
            GamePlayCard gamePlayCard = new GamePlayCard();
            gamePlayCard.newplaycard();
            List<string> newCard = gamePlayCard.originalCard;
            for(int i=0;i<newCard.Count;i++)
            {
                if ((i+1) % 13 != 0)
                {
                    Response.Write(newCard[i] + "\t");
                }
                else
                {
                    Response.Write(newCard[i] + "<br>");
                }
            }
        }

        public class GamePlayCard
        {
            public List<string> originalCard = new List<string>();
            List<string> tempCard = new List<string>();
            List<string> showCard = new List<string>();
            List<int> CardID = new List<int>();  //1~52

            public void newplaycard()
            {
                CardID.Add(52);
                CardID.Add(53);
                for (int i = 1; i < 53; i++)
                {
                    CardID.Add(i);
                    string res = "";

                    int suitnum;
                    if (i % 13 != 0)
                    {
                        suitnum = i / 13;
                    }
                    else
                    {
                        suitnum = i / 13 - 1;
                    }

                    switch (suitnum)
                    {
                        case 0:
                            res = "Club" + GetDispalyNum(i % 13);
                            break;
                        case 1:
                            res = "Diamond" + GetDispalyNum(i % 13);
                            break;
                        case 2:
                            res = "Heart" + GetDispalyNum(i % 13);
                            break;
                        default:
                            res = "Spade" + GetDispalyNum(i % 13);
                            break;
                    }
                    originalCard.Add(res);
                }
            }

            public string cardface(int num)
            {
                return "";
            }

            public void sortCard(int gametype)
            {
                //gametype
                //1:showhand
                //2:Big two


            }

            string GetDispalyNum(int cardno)
            {
                string show = "";

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
                        show = "K";
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