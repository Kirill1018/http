using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Serialization;
using System.Text.Json;
using System.Windows;
using System.Text.Json.Serialization;
namespace HTTP
{
    public class Us_api
    {
        public static Dictionary<string, string> dictionary;
        public static string Us_api_prop { get; set; } = "7RjAxdVCGQN1nALXvvkvcJOG4WDdqo9f";
        public static void Read_us_api_to_loc_stor()
        {
            try
            {
                string file_name = "294021.json",
                    json_string = File.ReadAllText(file_name);
                dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(json_string);
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
        }
    }
}