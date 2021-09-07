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
            // Chart pieChart = GeneratePieChart();
            // ViewData["PieChart"] = pieChart;

            var MainTable = GetSqlData();
            ViewData["MainTable"] = MainTable;

            return View(MainTable);
        }

        private Chart GeneratePieChart()
        {
            // data

            var MainTable = GetSqlData();

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

                // Data = new List<double?>() { 300, 50, 100 }
                Data = MainTable.ToppProducent.Select(x => (double?)double.Parse(x.Belopp)).ToList(), //Here i want this to be filled with data from AppropriateLine variable, it works for the fixed value only

            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            chart.Data = data;

            return chart;
        }

        public MainTable GetSqlData()
        {

            var mssqlConnectionString = "Server=tcp:valfardsstatistik.database.windows.net,1433;Initial Catalog=valfardsstatistikdb;Persist Security Info=False;User ID=minnadb;Password=Beachsteps@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            using var connection = new SqlConnection(mssqlConnectionString);

            var ToppProducenter = connection.Query<ToppProducent>("SELECT * FROM Huvudtabellen where Kontogrupp = 1 order by Namn").ToList();
            var Nivå1 = connection.Query<Nivå1>("SELECT * FROM Huvudtabellen where Huvudkonto = 1 order by Belopp DESC").ToList();
            var Nivå2 = connection.Query<Nivå2>("SELECT * FROM Huvudtabellen where Underkonto = 1 order by Belopp DESC").ToList();


            var MainTable = new MainTable { ToppProducent = ToppProducenter, Nivå1 = Nivå1, Nivå2 = Nivå2 };


            return MainTable;

        }

 
        public IActionResult Bakgrund()
        {
            return View();
        }
        public IActionResult Verktyget()
        {
            return View();
        }
        public IActionResult Definitioner()
        {
            return View();
        }
        public IActionResult Tjanster()
        {
            return View();
        }
        public IActionResult Press()
        {
            return View();
        }
        public IActionResult Internationella()
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
