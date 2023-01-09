
using MDT_part1_App;
using MDT_part1_App.Data;
using Microsoft.Extensions.Configuration;




string rootAddress = Directory.GetCurrentDirectory();
var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile($"appsettings.json").Build();
DataModelRepo  dadataModelRepo = new DataModelRepo(config, rootAddress);

