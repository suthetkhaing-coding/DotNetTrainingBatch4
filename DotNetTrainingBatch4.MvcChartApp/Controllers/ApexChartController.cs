﻿using DotNetTrainingBatch4.MvcChartApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch4.MvcChartApp.Controllers
{
    public class ApexChartController : Controller
    {
        public IActionResult SimplePieChart()
        {
            PieChartModel model = new PieChartModel();
            model.Lables = new List<string>() { "Team A", "Team B", "Team C", "Team D", "Team E" };
            model.Series = new List<int> { 44, 55, 13, 43, 22 };

            return View(model);
        }

        public IActionResult MultiSeriesTimelineChart()
        {
            var responseList = new List<MultiSeriesTimelineChartModel>
        {
            new()
            {
                Name = "Bob",
                Timelines = new List<Timelines>
                {
                    new () { Title = "Design", DateTimes = new List<DateTime> { new (2019, 3, 5), new DateTime(2019, 3, 8) } },
                    new () { Title = "Code", DateTimes = new List<DateTime> { new (2019, 3, 8), new DateTime(2019, 3, 11) } },
                    new () { Title = "Test", DateTimes = new List<DateTime> { new (2019, 3, 11), new DateTime(2019, 3, 16) } }
                }
            },
            new() {
                Name = "Joe",
                Timelines = new List<Timelines>
                {
                    new () { Title = "Design", DateTimes = new List<DateTime> { new (2019, 3, 2), new DateTime(2019, 3, 5) } },
                    new () { Title = "Code", DateTimes = new List<DateTime> { new (2019, 3, 6), new DateTime(2019, 3, 9) } },
                    new () { Title = "Test", DateTimes = new List<DateTime> { new (2019, 3, 10), new DateTime(2019, 3, 19) } }
                }
            }
        };
            return View(responseList);
        }
        
        public IActionResult RadialBarCustomAngleCircleChart() 
        {
            RadialBarCustomAngleCircleChartModel model = new RadialBarCustomAngleCircleChartModel();
            model.Series = new List<int> { 76, 67, 61, 90 };
            model.Labels = new List<string> { "Vimeo", "Messenger", "Facebook", "LinkedIn" };
            model.Colors = new List<string> { "#1ab7ea", "#0084ff", "#39539E", "#0077B5" };
        }
        
        public IActionResult SPLineChart()
        {
            SPLineChartModel model = new SPLineChartModel();
            model.Series1 = new List<int>() { 31, 40, 28, 51, 42, 109, 100 };
            model.Series2 = new List<int>() { 11, 32, 45, 32, 34, 52, 41 };
            model.Categories = new List<string>() { "2018-09-19T00:00:00.000Z", "2018-09-19T01:30:00.000Z", "2018-09-19T02:30:00.000Z", "2018-09-19T03:30:00.000Z", "2018-09-19T04:30:00.000Z", "2018-09-19T05:30:00.000Z", "2018-09-19T06:30:00.000Z" };
            return View(model);
        }

        [ActionName("Stepline")]
        public IActionResult SteplineChart()
        {
            SteplineChartModel model = new SteplineChartModel();
            model.Data = new List<int>() { 34, 44, 54, 21, 12, 43, 33, 23, 66, 66, 58 };
            return View("SteplineChart",model);
        }
        
        public IActionResult BarChart()
        {
            BarChartModel model = new BarChartModel();
            model.Labels = new List<string>()
            {
                "South Korea",
                "Canada",
                "United Kingdom",
                "Netherlands",
                "Italy",
                "France",
                "Japan",
                "United States",
                "China",
                "Germany"
            };
            model.Series = new List<int> { 400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380 };
            return View(model);
        }

        public IActionResult BasicColumnChart()
        {
            ColumnChartModel model = new ColumnChartModel();
            model.Series = new List<Series>
            {
                new Series { Name = "Net Profit", Data = new List<int> { 44, 55, 57, 56, 61, 58, 63, 60, 66 } },
                new Series { Name = "Revenue", Data = new List<int> { 76, 85, 101, 98, 87, 105, 91, 114, 94 } },
                new Series { Name = "Free Cash Flow", Data = new List<int> { 35, 41, 36, 26, 45, 48, 52, 53, 41 } }
            };
            model.Categories = new List<string> { "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" };
            return View(model);
        }

        public IActionResult PolarAreaChart() 
        { 
            PolarAreaChartModel polarAreaChartModel = new PolarAreaChartModel();
            polarAreaChartModel.Series = new List<int> { 14, 23, 21, 17, 15, 10, 12, 17, 21 };

            return View(polarAreaChartModel);
        }
        
        public IActionResult ColumnChartWithDataLables()
        {
            ColumnChartWithDataLablesModel model = new ColumnChartWithDataLablesModel();
            model.Categories = new List<string>()
            {
                "Jan",
                "Feb",
                "Mar",
                "Apr",
                "May",
                "Jun",
                "Jul",
                "Aug",
                "Sep",
                "Oct",
                "Nov",
                "Dec"
            };
            model.Inflation = new List<double>
            {
                2.3,
                3.1,
                4.0,
                10.1,
                4.0,
                3.6,
                3.2,
                2.3,
                1.4,
                0.8,
                0.5,
                0.2
            };
            return View(model);
        }

        public IActionResult BasicSlopeChart()
        {
            BasicSlopeChartModel model = new BasicSlopeChartModel
            {
                Categories = new List<string> { "Jan", "Feb" },
                Series = new List<SeriesData>
                {
                    new SeriesData
                    {
                        Name = "Blue",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 43 },
                            new DataPoint { Jan = "Feb", Feb = 58 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Green",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 33 },
                            new DataPoint { Jan = "Feb", Feb = 38 }
                        }
                    },
                    new SeriesData
                    {
                        Name = "Red",
                        Data = new List<DataPoint>
                        {
                            new DataPoint { Jan = "Jan", Feb = 55 },
                            new DataPoint { Jan= "Feb", Feb = 21 }
                        }
                    }
                }
            };

            return View(model);
        }

        public IActionResult LineColumnArea()
        {
            LineColumnAreaModel model = new LineColumnAreaModel
            {
                Series = new List<LineColumnAreaSeriesModel>()
                {
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team A",
                        Type = "column",
                        Data = new List<int> { 23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30 }
                    },
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team B",
                        Type = "area",
                        Data = new List<int> { 44, 55, 41, 67, 22, 43, 21, 41, 56, 27, 43 }
                    },
                    new LineColumnAreaSeriesModel()
                    {
                        Name = "Team C",
                        Type = "line",
                        Data = new List<int> { 30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39 }
                    }
                },
                Labels = new List<DateOnly>
                {
                    new DateOnly(2024, 7, 1),
                    new DateOnly(2024, 7, 2),
                    new DateOnly(2024, 7, 3),
                    new DateOnly(2024, 7, 4),
                    new DateOnly(2024, 7, 5),
                    new DateOnly(2024, 7, 6),
                    new DateOnly(2024, 7, 7),
                    new DateOnly(2024, 7, 8),
                    new DateOnly(2024, 7, 9),
                    new DateOnly(2024, 7, 10),
                    new DateOnly(2024, 7, 11)
                }
            };
            return View(model);
        }

        public IActionResult BasicLineChart()
        {
            BasicLineChartModel model = new BasicLineChartModel();
            model.ProductName = "Desktops";
            model.Datas = new List<int>() { 10, 41, 35, 51, 49, 62, 69, 91, 148 };
            model.Categories = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };
            return View(model);
        }
        
        public IActionResult LineWithDataLabelsChart() { 

            LineWithDataLabelsChartModel FirstDataModel = new LineWithDataLabelsChartModel();
            FirstDataModel.Name = "High - 2013";
            FirstDataModel.dataList = new List<int> { 28, 29, 33, 36, 32, 32, 33};

            LineWithDataLabelsChartModel SecondDataModel = new LineWithDataLabelsChartModel();
            SecondDataModel.Name = "Low - 2013";
            SecondDataModel.dataList = new List<int> { 12, 11, 14, 18, 17, 13, 13 };

            LineWithDataLabelsChartRespondModel respondModel = new LineWithDataLabelsChartRespondModel();
            respondModel.FirstRecord = FirstDataModel;
            respondModel.SecondRecord = SecondDataModel;

            return View(respondModel);
        }
    }
}
