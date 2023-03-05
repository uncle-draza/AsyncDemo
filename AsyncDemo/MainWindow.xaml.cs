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

namespace AsyncDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeSynchronous_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            RunDownloadSync();

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $" Ukupno vreme izvrsavanja: { elapsedMs }";
        }

        private async void executeAsynchronous_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadAsync();

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $" Ukupno vreme izvrsavanja: { elapsedMs }";
        }

        private async void executeParallel_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadParallelAsync();

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            resultWindow.Text += $" Ukupno vreme izvrsavanja: { elapsedMs }";
        }

        

        private void RunDownloadSync()
        {
            List<string> websites = PrepData();
            foreach (string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private async Task RunDownloadAsync()
        {
            List<string> websites = PrepData();
            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (string site in websites)
            {
                tasks.Add(Task.Run(() => DownloadWebsite(site)));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            resultWindow.Text = "";

            output.Add("https://www.google.com/");
            output.Add("https://www.samsung.com/rs/");
            output.Add("https://www.hp.com/us-en/home.html");
            output.Add("https://edition.cnn.com/");
            output.Add("https://www.spacex.com/");
            output.Add("https://www.tesla.com/"); 

            return output;
        }

        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteURL = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL); //postoji i asinhrona verzija ove funkcije, ali radi primera, nece biti koriscena

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultWindow.Text += $" {data.WebsiteURL} downloaded: {data.WebsiteData.Length} characters long.{Environment.NewLine}";
        }
        
    }
}
