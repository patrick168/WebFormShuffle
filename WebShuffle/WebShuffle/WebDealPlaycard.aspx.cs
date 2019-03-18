using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TungSampleCode
{
    public partial class WebDealPlaycard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();
            //originalCrad();  //show card 1~52
        }

        struct PlayCard
        {

        }

        public void originalCrad()
        {
            GameCard gameCard = new GameCard();
            List<string> mycards = gameCard.playcard();
            for (int i = 0; i < mycards.Count; i++)
            {
                Response.Write(mycards[i] + "<br>");
            }
        }


        public class GameCard
        {
            public List<string> playcard()
            {
                List<string> cards=new List<string>();
                string[] cardSuit = { "spade", "heart", "diamond", "club" };
                for (int i = 0; i < 4; i++)
                {
                    for (int x = 1; x <= 13; x++)
                    {
                        string onecard = cardSuit[i] + x + "  ";
                        cards.Add(onecard);
                    }
                }
                return cards;
            }

            public void Shuffle()
            {
                List<string> tempCard = new List<string>();
                Random random = new Random();
                int cardno = 0;
                for(int i=1;i<=52;i++)
                {
                    cardno++;

                }
            }
        }

        protected void dealbtn_Click(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();
            List<string> randomCard =gameCard.playcard();
            Random r = new Random();
            List<string> ls = new List<string>();
            Response.Write(randomCard[r.Next(0, 51)] + "<br>");
        }

        protected void ShuffleBtn_Click(object sender, EventArgs e)
        {
            int max = 51;
            GameCard gameCard = new GameCard();
            List<string> NewCard = gameCard.playcard();
            Random r = new Random();
            List<string> ls = new List<string>();
            List<string> tempCard = new List<string>();
            List<string> playerCard = new List<string>();
            List<string> displayCard = new List<string>();

            for (int i = 0; i < 52; i++) 
            {                
                int ran = r.Next(0, max-i);
                tempCard.Add(NewCard[ran]);

                if ((i + 1) % 13 == 0)
                    Response.Write(NewCard[ran] + "<br>");
                else
                    Response.Write(NewCard[ran] + "， ");

                NewCard.RemoveAt(ran);
            }         
        }
    }
}