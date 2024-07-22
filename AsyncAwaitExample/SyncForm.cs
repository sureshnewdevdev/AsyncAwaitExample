using System;
using System.Net.Http;
using System.Windows.Forms;

namespace AsyncAwaitExample
{
    public partial class SyncForm : Form
    {
        public SyncForm()
        {
            InitializeComponent();
        }

        private void fetchDataButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "Fetching data...";
            var data = FetchData();
            resultTextBox.Text = data;
        }

        private string FetchData()
        {
            using (HttpClient client = new HttpClient())
            {
                // Simulating a delay
                System.Threading.Thread.Sleep(5000);

                // Replace this with an actual URL to fetch data from
                string url = "https://jsonplaceholder.typicode.com/posts";
                var response = client.GetStringAsync(url).Result;
                return response;
            }
        }
    }
}
