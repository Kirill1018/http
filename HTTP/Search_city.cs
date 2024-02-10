using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace HTTP
{
    internal class Search_city
    {
        public static ObservableCollection<Root_bas_city_info> infos;
        public static void Gett_list_of_cit_on_req(string form_city_name)
        {
            string api_key = Us_api.Us_api_prop;
            try
            {
                string json_on_web = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={api_key}&q={form_city_name}";
                WebClient client = new WebClient();
                string prep_string = client.DownloadString(json_on_web);
                infos = JsonSerializer.Deserialize<ObservableCollection<Root_bas_city_info>>(prep_string);
            }
            catch (Exception exception) { MessageBox.Show("ошибка десериализации"); }
        }
        public static void Write_list_of_city_mon()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Root_bas_city_info>));
            StreamWriter writer = new StreamWriter("root_bas_city_info.xml");
            serializer.Serialize(writer, infos);
        }
    }
}