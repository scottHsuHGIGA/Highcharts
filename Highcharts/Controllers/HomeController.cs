using Highcharts.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Highcharts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var result =new List<string>();
            var iNitialHighchart = SetInitialHighcharts();
            var title = new titleViewModel();
            for (var i=0;i<10;i++)
            {
                title.text = $"第{i}題";
                iNitialHighchart.title = title;
                var series = new List<seriesViewModel>();
                for(var j = 0; j < 5; j++)
                {
                    series.Add(GetSeries(j));
                }
                iNitialHighchart.series = series;
                result.Add(JsonConvert.SerializeObject(iNitialHighchart));
            }
            return View(result);
        }

        private seriesViewModel GetSeries(int item)
        {
            var serie = new seriesViewModel();
            serie.name = $"Series{item}";
            List<int> data = new List<int>();
            for (var i = 0; i < 5; i++)
            {
                data.Add(i* item);
            }
            serie.data = data;
            return serie;
        }

        private HighchartsViewModel SetInitialHighcharts()
        {
            var xAxis = new xAxisViewModel()
            {
                categories = { "Pe", "Pd", "Pc", "Pb", "Pa" }
            };

            var yAxis = new yAxisViewModel()
            {
                max = 100,
                min = 0,
                title = { text = "人數百分比" },
                plotLines = { (new plotLinesViewModel { value = 0, width = 0, color = "#808080" }) }

            };
            var tooltip = new tooltipViewModel()
            { valueSuffix = "%" };
            var legend = new legendViewModel()
            {
                layout = "vertical",
                align = "right",
                verticalAlign = "middle",
                borderWidth = 0
            };
            var result = new HighchartsViewModel()
            {
                xAxis = xAxis,
                yAxis = yAxis,
                tooltip = tooltip,
                legend = legend
            };

            return result;
        }
    }
}