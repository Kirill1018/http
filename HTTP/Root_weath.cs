using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HTTP
{
    internal class Root_weath
    {
        public static string city_key = "294021";
        public static void Get_api_key(Image[] images, TextBlock block)
        {
            string api_key = Us_api.Us_api_prop,
                json_url = $"http://dataservice.accuweather.com/forecasts/v1/daily/5day/{city_key}?apikey={api_key}&language=ru&metric=true";
            json_url = new WebClient().DownloadString(json_url);
            Daily_for daily_for = JsonSerializer.Deserialize<Daily_for>(json_url);
            Us_api.dictionary.Add(new Daily_for().Temperature.ToString(), new Daily_for().Day);
            if (daily_for.Day == "снег")
            {
                block.Text = $"температура={new Daily_for().Temperature}, погода: {new Daily_for().Day}";
                images[0].IsEnabled = true;
                images[1].IsEnabled = false;
                images[2].IsEnabled = false;
            }
            else if (daily_for.Day == "гололёд")
            {
                block.Text = $"температура={new Daily_for().Temperature} погода: {new Daily_for().Day}";
                images[0].IsEnabled = false;
                images[1].IsEnabled = true;
                images[2].IsEnabled = false;
            }
            else if (daily_for.Day == "изморозь")
            {
                block.Text = $"температура={new Daily_for().Temperature} погода: {new Daily_for().Day}";
                images[0].IsEnabled = false;
                images[1].IsEnabled = false;
                images[2].IsEnabled = true;
            }
        }
    }
}