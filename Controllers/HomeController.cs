using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Valfardsstatistik.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Valfardsstatistik.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            GetSqlData();

            Chart pieChart = GeneratePieChart();
            ViewData["PieChart"] = pieChart;

            return View();
        }

        private Chart GeneratePieChart()
        {
            Chart chart = new Chart();
            chart.Type = Enums.ChartType.Pie;

            Data data = new Data();
            data.Labels = new List<string>() { "Red", "Blue", "Yellow" };

            PieDataset dataset = new PieDataset()
            {
                Label = "My dataset",
                BackgroundColor = new List<ChartColor>() {
                    ChartColor.FromHexString("#FF6384"),
                    ChartColor.FromHexString("#36A2EB"),
                    ChartColor.FromHexString("#FFCE56")
                },
                HoverBackgroundColor = new List<ChartColor>() {
                    ChartColor.FromHexString("#FF6384"),
                    ChartColor.FromHexString("#36A2EB"),
                    ChartColor.FromHexString("#FFCE56")
                },
                Data = new List<double?>() { 300, 50, 100 }

            };



            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            chart.Data = data;

            return chart;
        }

        public void GetSqlData()
        {
            var mssqlConnectionString = "Server=tcp:valfardsstatistik.database.windows.net,1433;Initial Catalog=valfardsstatistikdb;Persist Security Info=False;User ID=minnadb;Password=Beachsteps@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using var connection = new SqlConnection(mssqlConnectionString);
            // Dapper will open for us
            //connection.Open();
            var ToppProducenter = connection.Query<ToppProducent>("SELECT * FROM Huvudtabellen where Topp = 1").ToList();
            var Nivå1 = connection.Query<Nivå1>("SELECT * FROM Huvudtabellen where Nivå_1 = 1").ToList();
            var Nivå2 = connection.Query<Nivå2>("SELECT * FROM Huvudtabellen where Nivå_2 = 1").ToList();

            // var dog = connection.Query<MainTable>("select Age = @Age, Id = @Id", new { Age = (int?)null, Id = guid });


            // return data;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
