using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Esewa
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           double amount = 100;
            double pid = 12345;
            string Failedurl = "http://merchant.com.np/page/esewa_payment_failed?q=fu";
            string successUrl = "http://merchant.com.np/page/esewa_payment_success?q=su";
            string aa = "<html> <body> <form action=\"https://uat.esewa.com.np/epay/main\" method=\"POST\" id=\"member_signup\"> <input value=\"" + amount + "\" name=\"tAmt\" type=\"hidden\"> <input value=\"" + amount + "\" name=\"amt\" type=\"hidden\"> <input value=\"0\" name=\"txAmt\" type=\"hidden\"> <input value=\"0\" name=\"psc\" type=\"hidden\"> <input value=\"0\" name=\"pdc\" type=\"hidden\"> <input value=\"epay_payment\" name=\"scd\" type=\"hidden\"> <input value=\"" + pid + "\" name=\"pid\" type=\"hidden\"> <input value=\""+successUrl+"\" type=\"hidden\" name=\"su\"> <input value=\"" + Failedurl + "\" type =\"hidden\" name=\"fu\"> </form> <script> window.onload = function(){ document.forms['member_signup'].submit(); } </script </body> </html>";

            webViewForm.Uri = aa;

            webViewForm.RegisterAction(data =>
            {

                Device.BeginInvokeOnMainThread(() =>
                {
                    String value = data.ToString();
                    //Perform your failed and Success operation here on the basis of value

                });


            });
        }
    }
}
