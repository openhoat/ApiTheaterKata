using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestestTheater.WebApp.Pages
{
    public class req3242345Model : PageModel
    {
        public List<BkngData_3>? BkngData_3s
        {
            get; 
            set;
        }

        public void OnGet()
        {
            var data = new List<BkngData_3>();

            for (var i = 0; i < 10; i++)
            {
                var randomSeatSeed = new Random().Next(0, 100);

                var randSeatCount = new Random().Next(1, 5);

                var seatsAsStrings = new List<string>();
                for (var j = 0; j < randSeatCount; j++)
                {
                    int randomizedNumber = new Random().Next(randomSeatSeed, randomSeatSeed + 100);

                    seatsAsStrings.Add($"Seats {randomizedNumber.ToString("D2")}");
                }

                var details = seatsAsStrings.Aggregate((prev, next) => prev + ", " + next);

                var oneRow = new BkngData_3()
                {
                    Title = $"Title{new Random().Next(0, 100).ToString("D2")}",
                    Date = new DateTime(2024, 1, 2, 13, 16, 0, DateTimeKind.Utc),
                    Details = details
                };

                data.Add(oneRow);
            }

            BkngData_3s = data;
        }
    }
}
