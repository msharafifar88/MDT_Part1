using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MDT_part1_App.Data;
using MDT_part1_App.Data.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace MDT_part1_App
{
    public class Tasks
    {
        private Datasets dataSet1;

        public Tasks(Datasets dataSet1)

        {
            Parallel.ForEach(dataSet1.generators.AsParallel().AsOrdered().Reverse(), genitem =>
                {
                    foreach (List<double> dataSet_ in dataSet1.datasets)
                    {
                        Console.WriteLine($@"{DateTime.Now.ToString("HH:mm:ss")} {genitem.name} {Math.Round(getResult(dataSet_, genitem.operation), 2)}");
                        Thread.Sleep(genitem.interval * 1000);
                    }

                });

        }


        private double getResult(List<double> list_, string operationType = null)
        {
            if (operationType == null)
                throw new Exception("Invalid Operation Type");
            switch (operationType.ToLower())
            {
                case "sum":
                    return list_.Sum();
                case "min":
                    return list_.Min();
                case "max":
                    return list_.Max();
                case "average":
                    return list_.Average();
                default:
                    throw new Exception("Invalid Operation Type");
            }

        }


    }
}
       