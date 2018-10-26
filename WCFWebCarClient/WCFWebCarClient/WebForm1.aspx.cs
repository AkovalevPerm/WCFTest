using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFWebCarClient.CarService;

namespace WCFWebCarClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // Передаём в конструктор биндинг из конфига.
        CarService.CarServiceClient _client = new CarServiceClient("BasicHttpBinding_ICarService");  
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(TextBox1.Text);
            var vendor = TextBox2.Text;
            var model = TextBox3.Text;
            var year = int.Parse(TextBox4.Text);

            _client.SetCar(new Car{ Id = id, Vendor = vendor, Model = model, Year = year});
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(TextBox1.Text);
            var car = _client.GetCar(id);
            TextBox2.Text = car.Vendor;
            TextBox3.Text = car.Model;
            TextBox4.Text = car.Year.ToString();
        }
    }
}