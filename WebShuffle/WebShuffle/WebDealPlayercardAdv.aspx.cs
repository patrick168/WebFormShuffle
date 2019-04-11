using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShuffle
{
    public partial class WebDealPlayercardAdv : Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();           
        }
               
     
        public class GameCard
        {
            List<string> tempCard = new List<string>();
            List<string> playerCard = new List<string>();
            List<string> displayCard = new List<string>();
                        
            public List<string> playcard()
            {
                List<string> cards = new List<string>();
                string[] cardSuit = { "C", "D", "H", "S" };              
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
                    

            public List<string> Shuffle()
            {
                int max = 51;
                Random r = new Random();

                GameCard gameCard = new GameCard();
                List<string> NewCard = gameCard.playcard();

                for (int i = 0; i < 13; i++)  
                {
                    int ran = r.Next(0, max - i);
                    tempCard.Add(NewCard[ran]);
                    NewCard.RemoveAt(ran);
                }
                return tempCard;              
            }

            public List<string> SortingCards(List<string> tempCard)
            {               
                return tempCard;
            }
        }

        protected void dealbtn_Click(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();
            List<string> randomCard = gameCard.playcard();
            Random r = new Random();
            List<string> ls = new List<string>();
            Response.Write(randomCard[r.Next(0, 51)] + "<br>");
        }

        protected void ShuffleBtn_Click(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();
            List<string> tempCard = gameCard.Shuffle();        
          
            string result = "";
            foreach (var card in tempCard)
            {
                result += card + ", ";
            }
            Response.Write(result.TrimEnd(',',' '));
        }
    }
}