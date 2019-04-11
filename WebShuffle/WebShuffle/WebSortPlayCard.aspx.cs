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
        GamePlayCard gamePlayCard = new GamePlayCard();

        protected void Page_Load(object sender, EventArgs e)
        {
            gamePlayCard.newplaycard();
        }

        public class GamePlayCard
        {
            public List<string> originalCard = new List<string>();
            public List<string> tempCard = new List<string>();
            public List<string> showCard = new List<string>();
            public List<int> originalCardID = new List<int>();  //1~52
            public List<int> tempCardID = new List<int>();  //1~52
            public List<int> gameCardID = new List<int>();  //1~52

            public void newplaycard()
            {             
                for (int i = 1; i < 53; i++)
                {
                    originalCardID.Add(i);
                    originalCard.Add(cardface(i));
                }
            }

            public string cardface(int n)
            {

                int suitnum;
                string res = "";

                if (n % 13 != 0)
                {
                    suitnum = n / 13;
                }
                else
                {
                    suitnum = n / 13 - 1;
                }
                
                switch (suitnum)
                {
                    case 0:
                        res = "Club" + GetDispalyNum(n % 13);
                        break;
                    case 1:
                        res = "Diamond" + GetDispalyNum(n % 13);
                        break;
                    case 2:
                        res = "Heart" + GetDispalyNum(n % 13);
                        break;
                    default:
                        res = "Spade" + GetDispalyNum(n % 13);
                        break;
                }

                return res;
            }

            public List<int> sortCard(int gametype, List<int> cardId)
            {
                //gametype
                //1:showhand
                //2:Big two

                int temp;
            
                for (int i = 0; i < cardId.Count(); i++)
                {
                    for(int j=i; j < cardId.Count(); j++)
                    {
                        if(CardNumberForSort(gametype,cardId[i]) > CardNumberForSort(gametype,cardId[j]))
                        {
                            temp = cardId[i];
                            cardId[i] = cardId[j];
                            cardId[j] = temp;
                        }
                    }
                }

                return cardId;
            }

            public int CardNumberForSort(int cardGame, int num)
            {
                if (num % 13 <= cardGame && num % 13 != 0)
                {
                    num += 13;
                }

                return num;
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

        protected void NewPlayCard_Click(object sender, EventArgs e)
        {           
            List<string> newCard = gamePlayCard.originalCard;


            for (int i = 0; i < newCard.Count; i++)
            {
                if ((i + 1) % 13 != 0)
                {
                    Response.Write(newCard[i] + "\t");
                }
                else
                {
                    Response.Write(newCard[i] + "<br>");
                }
            }
        }

        protected void SortNewPlayCard_Click(object sender, EventArgs e)
        {
            List<int> afterSort = gamePlayCard.originalCardID;
            gamePlayCard.sortCard(2, afterSort);

            foreach (int no in afterSort)
            {
                Response.Write(gamePlayCard.cardface(no) + "\t");
            }
        }

        protected void DealOnePlayer_Click(object sender, EventArgs e)
        {
            DealSort(1);
        }

        protected void DealAllPlayers_Click(object sender, EventArgs e)
        {
            DealSort(4);
        }

        public void DealSort(int players)
        {
            int max = 51;
            Random ran = new Random();

            List<int> tempcard = gamePlayCard.tempCardID;
            List<int> gamecard = gamePlayCard.gameCardID;

            tempcard = gamePlayCard.originalCardID;

            for (int p = 0; p < players; p++)
            {
                for (int i = 0; i < 13; i++)
                {
                    int randomNum = ran.Next(0, max - i -p * 13);
                    gamecard.Add(gamePlayCard.originalCardID[randomNum]);
                    tempcard.RemoveAt(randomNum);
                }
                gamePlayCard.sortCard(2, gamecard);
                foreach (int n in gamecard)
                {
                    Response.Write(gamePlayCard.cardface(n) + "\t");
                }
                Response.Write("<br>");
                gamecard.Clear();
            }
          

            tempcard.Clear();
        }

    }
}