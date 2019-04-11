using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebShuffle
{
    public partial class bubble : System.Web.UI.Page
    {
        int[] numbers = { 1, 5, 2, 9, 11, 12, 10, 3 ,13};


        protected void Page_Load(object sender, EventArgs e)
        {
            bubbleSort(numbers);
            foreach (int n in numbers)
            {
                Response.Write(n + "\t");
            }
        }

        public int[] bubbleSort(int[] noarr)
        {
            int i,j,temp;
            

            for(i=0;i<noarr.Length;i++)
            {
                for(j=i+1;j<noarr.Length;j++)
                {
                    if (noarr[i] > noarr[j] || noarr[i]==1 )
                    {                       
                            temp = noarr[i];
                            noarr[i] = noarr[j];
                            noarr[j] = temp;                        
                    }
                }
            }

            return noarr;
        }        
    }
}