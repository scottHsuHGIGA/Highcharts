using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Highcharts.Models
{
    public class HighchartsViewModel
    {
        public HighchartsViewModel()
        {
            title = new titleViewModel();
            xAxis = new xAxisViewModel();
            yAxis = new yAxisViewModel();
            tooltip = new tooltipViewModel();
            legend = new legendViewModel();
            series = new List<seriesViewModel>();
        }
        public titleViewModel title { get; set; }
        public xAxisViewModel xAxis { get; set; }
        public yAxisViewModel yAxis { get; set; }
        public tooltipViewModel tooltip { get; set; }
        public legendViewModel legend { get; set; }
        public List<seriesViewModel> series { get; set; }
    }

    public class seriesViewModel
    {
        public seriesViewModel()
        {
            data = new List<int>();
        }
        public string name { get; set; }
        public List<int> data { get; set; }
    }

    public class xAxisViewModel
    {
        public xAxisViewModel()
        {
            categories = new List<string>();
        }
        public List<string> categories { get; set; }
    }

    public class yAxisViewModel
    {
        public yAxisViewModel()
        {
            title = new titleViewModel();
            plotLines = new List<plotLinesViewModel>();

        }
        public int max { get; set; }
        public int min { get; set; }
        public titleViewModel title { get; set; }
        public List<plotLinesViewModel> plotLines { get; set; }
    }

    public class titleViewModel
    {
        public string text { get; set; }
    }

    public class plotLinesViewModel
    {
        public int value { get; set; }
        public int width { get; set; }
        public string color { get; set; }

    }

    public class tooltipViewModel
    {
        public string valueSuffix { get; set; }
    }

    public class legendViewModel
    {
        public string layout { get; set; }

        public string align { get; set; }

        public string verticalAlign { get; set; }
        public int borderWidth { get; set; }


    }
}