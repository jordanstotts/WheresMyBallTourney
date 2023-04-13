using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace WheresMyBallTourney.Pages
{
    public class NewPredictionModel : PageModel
    {
        public PredictionInfo predictionInfo = new PredictionInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            predictionInfo.boot = Request.Form["boot"];
            predictionInfo.playerTwo = Request.Form["playerTwo"];
            predictionInfo.playerThree = Request.Form["playerThree"];
            predictionInfo.playerFour = Request.Form["playerFour"];
            predictionInfo.playerFive = Request.Form["playerFive"];
            predictionInfo.flag = Request.Form["flag"];

            if (predictionInfo.boot == "null" || predictionInfo.playerTwo == "null" || predictionInfo.playerThree == "null" ||
                predictionInfo.playerFour == "null" || predictionInfo.playerFive == "null" || predictionInfo.flag == "null")
            {
                errorMessage = "All fields are required";
                return;
            }
            //save the new prediction to database
            try
            {

                String connectionString = "Data Source=.\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO FlagTourneyPredictions.dbo.predictions " +
                                "(boot, playerTwo, playerThree, playerFour, playerFive, flag) VALUES " +
                                "(@boot, @playerTwo, @playerThree, @playerFour, @playerFive, @flag);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@boot", predictionInfo.boot);
                        command.Parameters.AddWithValue("@playerTwo", predictionInfo.playerTwo);
                        command.Parameters.AddWithValue("@playerThree", predictionInfo.playerThree);
                        command.Parameters.AddWithValue("@playerFour", predictionInfo.playerFour);
                        command.Parameters.AddWithValue("@playerFive", predictionInfo.playerFive);
                        command.Parameters.AddWithValue("@flag", predictionInfo.flag);


                        command.ExecuteNonQuery();
                    }

                }
            }



            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            predictionInfo.boot = "null"; predictionInfo.playerTwo = "null"; predictionInfo.playerThree = "null";
            predictionInfo.playerFour = "null"; predictionInfo.playerFive = "null"; predictionInfo.flag = "null";
            successMessage = "New prediction has been added!";

            Response.Redirect("/InsightToNextYear");
        }
    }
}
