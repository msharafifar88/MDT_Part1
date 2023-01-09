using MDT_part1_App.Data.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDT_part1_App.Data
{
    public class DataModelRepo
    {

        private Datasets dataset_;

        public Datasets dataSet { get => this.dataset_; set => this.dataset_ = value; }
        //Method to read Json File and return a list of tasks

        public DataModelRepo(IConfiguration configuration, string root)
        {

            var addrs = configuration.GetSection("DataAddrs")?.Get<string>();
            string path = $@"{root}\\{addrs}";
            string json = System.IO.File.ReadAllText(path);
            //Deserialize Json File to a  nested list
            // deserialize the current JSON object (e.g. {"name":"value"}) into type T


            // var data1 = Newtonsoft.Json.JsonConvert.DeserializeObject<JObject>(json);

             dataSet = Newtonsoft.Json.JsonConvert.DeserializeObject<Datasets>(json);

            doTask(dataSet);
        }
        
        public void doTask(Datasets dataSet)
        {
            Datasets dataSet1 = dataSet;
            Tasks tasks = new Tasks(dataSet1);
        }
        
    }
}
