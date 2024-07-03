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
