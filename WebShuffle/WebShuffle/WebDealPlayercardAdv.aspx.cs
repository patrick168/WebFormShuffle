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
        //增加排大小功能
        protected void Page_Load(object sender, EventArgs e)
        {
            GameCard gameCard = new GameCard();
            //originalCrad();  //show card 1~52
        }

        public struct PlayCard
        {
            string cardType { get; set; }
            int cardNO { get; set; }
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
            List<string> tempCard = new List<string>();
            List<string> playerCard = new List<string>();
            List<string> displayCard = new List<string>();

            List<PlayCard> newcards = new List<PlayCard>();
            List<PlayCard> tempcards = new List<PlayCard>();
            List<PlayCard> playercards = new List<PlayCard>();
            List<PlayCard> usecards = new List<PlayCard>();
                        
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

            public List<PlayCard> playCardList()
            {
                string[] cardSuit = { "spade", "heart", "diamond", "club" };
                PlayCard playCard = new PlayCard();
                List<PlayCard> cards = new List<PlayCard>();

                for (int i = 0; i < 4; i++)
                {
                    for (int x = 1; x <= 13; x++)
                    {
                        string onecard = cardSuit[i] + x + "  ";                        
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