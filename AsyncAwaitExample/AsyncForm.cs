using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitExample
{
    public partial class AsyncForm : Form
    {
        public AsyncForm()
        {
            InitializeComponent();
        }

        private async void fetchDataButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "Fetching data...";
            var data = await FetchDataAsync();
            resultTextBox.Text = data;
        }

        private async Task<string> FetchDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                // Simulating a delay
                await Task.Delay(5000);

                // Replace this with an actual URL to fetch data from
                string url = "https://jsonplaceholder.typicode.com/posts";
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
    }
}
