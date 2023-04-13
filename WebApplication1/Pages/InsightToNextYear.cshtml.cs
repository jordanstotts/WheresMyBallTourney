using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace WheresMyBallTourney.Pages
{
    public class InsightToNextYearModel : PageModel
    {
        public List<PredictionInfo> predictionsList = new();
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                // ".\\SQLEXPRESS  (DESKTOP-QKA86S9\\jorda)";
                // "Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;"

                using SqlConnection connection = new(connectionString);
                connection.Open();
                String sql = "SELECT * FROM FlagTourneyPredictions.dbo.predictions";
                //String sql = "SELECT TOP (1000) [id],[boot],[playerTwo],[playerThree],[playerFour],[playerFive],[flag],[created_at] FROM [FlagTourneyPredictions].[dbo].[predictions]";
                using SqlCommand command = new(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PredictionInfo predictionInfo = new PredictionInfo();
                    predictionInfo.id = "" + reader.GetInt32(0);
                    predictionInfo.boot = reader.GetString(1);
                    predictionInfo.playerTwo = reader.GetString(2);
                    predictionInfo.playerThree = reader.GetString(3);
                    predictionInfo.playerFour = reader.GetString(4);
                    predictionInfo.playerFive = reader.GetString(5);
                    predictionInfo.flag = reader.GetString(6);
                    predictionInfo.created_at = reader.GetDateTime(7).ToString();

                    predictionsList.Add(predictionInfo);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class PredictionInfo
    {
        public String id;
        public String boot;
        public String playerTwo;
        public String playerThree;
        public String playerFour;
        public String playerFive;
        public String flag;
        public String created_at;
    }
}
