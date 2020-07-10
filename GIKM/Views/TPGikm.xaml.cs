using GIKM.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GIKM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TPGikm : TabbedPage
    {
        public TPGikm()
        {
            InitializeComponent();
            BindingContext = new EventsList(AppConstants.GIKM);
        }
        // prova di chiamata al servizio SOAP

        //private static string webservicecall()
        //{

        //    WebRequest req = WebRequest.Create("http://77.238.249.141:7474/TLMuseumGate/wsdl/ISoldService");
        //    HttpWebRequest httpreq = (HttpWebRequest)req;
        //    httpreq.Method = "POST";
        //    httpreq.ContentType = "text/xml; charset=utf-8";
        //    httpreq.Headers.Add("SOAPAction:http://tempuri.org/SoldServiceIntf-ISoldService#GetSeances");
        //    httpreq.ProtocolVersion = HttpVersion.Version11;
        //    httpreq.Credentials = CredentialCache.DefaultCredentials;
        //    Stream str = httpreq.GetRequestStream();
        //    StreamWriter strwriter = new StreamWriter(str, Encoding.ASCII);
        //    StringBuilder soaprequest = new StringBuilder("<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
        //    soaprequest.Append("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ");
        //    soaprequest.Append("xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body>");
        //    soaprequest.Append("<GetSeances xmlns=\"http://schemas.xmlsoap.org/wsdl/soap/\">");
        //    soaprequest.Append("<Login>MuseumTestGate</Login>");
        //    soaprequest.Append("<Password>MuseumTestGate</Password>");
        //    soaprequest.Append("<SessionName>session1</SessionName>");
        //    soaprequest.Append("<IsRaiseError>true</IsRaiseError>");
        //    soaprequest.Append("<Request><Request dtBegin=\"20180101\" dtEnd=\"20181231\"/></Request></GetSeances17Request>");
        //    soaprequest.Append("</soap:Body></soap:Envelope>");

        //    strwriter.Write(soaprequest.ToString());
        //    strwriter.Close();
        //    HttpWebResponse res = (HttpWebResponse)httpreq.GetResponse();
        //    StreamReader rdr = new StreamReader(res.GetResponseStream());
        //    string result = rdr.ReadToEnd();
        //    return result;
        //}
    }
}