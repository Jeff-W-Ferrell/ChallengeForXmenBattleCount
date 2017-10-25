using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Max())
                {
                    int most = numbers[i];
                    string topBattles = names[i];
                    result = String.Format("Most battles belong to: {0} (Value: {1})<br/>", topBattles, most);
                }

                if (numbers[i] == numbers.Min())
                {
                    int least = numbers[i];
                    string bottomBattles = names[i];
                    result += String.Format("Least battles belong to: {0} (Value: {1})", bottomBattles, least);
                }

                resultLabel.Text = result;
            }         
        }
    }
}