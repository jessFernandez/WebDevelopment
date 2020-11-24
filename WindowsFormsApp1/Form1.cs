using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UvIndex_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient serviceClient = new ServiceReference1.ServiceClient();
            string lon = longitude.Text;
            string lat = latitude.Text;
            uvIndex.Text = serviceClient.solarIndex(lat, lon).ToString();
        }

        private void FindClosestStore_Click(object sender, EventArgs e)
        {
            ServiceReference2.ServiceClient serviceClient = new ServiceReference2.ServiceClient();
            string zc = zipCode.Text;
            string sn = storeName.Text;

            storeAddress.Text = serviceClient.closestStore(zc, sn);
        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference3.ServiceClient serviceClient = new ServiceReference3.ServiceClient();
            string kw = keyword.Text;
            newsResults.Text = serviceClient.getNews(kw);
        }

        private void BookingService_Click(object sender, EventArgs e)
        {
           using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:51021/Service.svc/locationInterest");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                var response = httpClient.GetStringAsync("?zipcode=" + ZipCodeBooking.Text + "&startingAddress=" + AddressBooking.Text);
                response.Wait();
                var result = response.Result;

                touristInfo.Text = result;

            }
        }
    }
}
