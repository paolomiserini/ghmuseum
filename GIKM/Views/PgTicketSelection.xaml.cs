using GIKM.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using ServiceRefSberbank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PgTicketSelection : ContentPage
    {
        private string UrlToCall;
        public MerchantServiceClient sberbankclient = new MerchantServiceClient();

        public PgTicketSelection(PaymentInfo _singlePay)
        {
            InitializeComponent();
            var _singlePayment = new PaymentData(_singlePay);
            this.BindingContext = _singlePayment;
        }

        private void On_PayButtonCLicked(object sender, EventArgs e)
        {
            try
            {
                // Ricordare di mettere la stinga dentro android manifest
                // utilizzare i due pacchetti nuget restsharp e newtonsoft.json

                var _amount2 = (PaymentData)this.BindingContext;

                var _amount = _amount2.singleDataInfo;
                _amount.Amount = _amount.Amount.Replace(",", "");

                var orderId = new Random();

                var clientrest = new RestClient("https://3dsec.sberbank.ru/");
                clientrest.Authenticator = new HttpBasicAuthenticator("gelmusey-api", "gelmusey");
                var request = new RestRequest("payment/rest/register.do", DataFormat.Json);
                request.AddParameter("userName", "gelmusey-api");
                request.AddParameter("password", "gelmusey");
                request.AddParameter("orderNumber", orderId.Next().ToString());

                request.AddParameter("amount", _amount.Amount);
                request.AddParameter("app2app", "true");
                if (Device.RuntimePlatform == Device.iOS)
                {
                    request.AddParameter("app.osType", "ios");
                    request.AddParameter("app.osType", "ios");
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    request.AddParameter("app.osType", "android");
                    request.AddParameter("app.osType", "android");
                }
                request.AddParameter("app.deepLink", "android");
                request.AddParameter("returnUrl", "http://www.gelmusey.ru");

                var response = clientrest.Get(request);

                if (response.IsSuccessful)
                {
                    var deserializzato = JsonConvert.DeserializeObject<SBOrderResponse>(response.Content);
                    UrlToCall = deserializzato.formUrl;
                    Navigation.PushAsync(new PgSberbank(UrlToCall));

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}