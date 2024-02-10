using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Data;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Security.RightsManagement;
using System.Linq.Expressions;
using System.Timers;
namespace HTTP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            Program();
        }
        public void Program()
        {
            Set_tim();
            Us_api.Read_us_api_to_loc_stor();
            //Search_city.Gett_list_of_cit_on_req("moscow");
            //Search_city.Write_list_of_city_mon();
            Image[] images = { image1, image2, image3 };
            Root_weath.Get_api_key(images, block);
            timer.Stop();
            timer.Dispose();
        }
        public static void Set_tim()
        {
            timer = new Timer(60000 * 5);
            timer.Elapsed += On_time_event;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        public static void On_time_event(Object source, ElapsedEventArgs e) { new MainWindow().Program(); }
    }
}