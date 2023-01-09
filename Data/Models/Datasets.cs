namespace MDT_part1_App.Data.Models
{
    public class Datasets
    {
        public List<List<double>> datasets { get; set; }
        public List<gen> generators { get; set; }

    }


    public class gen
    {
        public string? name { get; set; }
        public int interval { get; set; }
        public string? operation { get; set; }
    }

    public class dataset
    {
        public List<double>? DataSet { get; set; }
    }
}
