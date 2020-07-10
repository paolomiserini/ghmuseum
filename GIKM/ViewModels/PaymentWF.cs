using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GIKM.ViewModels
{
    public class SBOrderResponse
    {
        public string orderId { get; set; }
        public string formUrl { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
    }
    public class PaymentInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Amount { get; set; }
    }

    public class PaymentData : BindableObject
    {
        private PaymentInfo _paymentinfo;

        public PaymentData(PaymentInfo _paymentinfo)
        {
            singleDataInfo = new PaymentInfo();
            LoadPayInfo(_paymentinfo);
        }

        public PaymentInfo singleDataInfo
        {
            get { return _paymentinfo; }
            set
            {
                _paymentinfo = value;
                OnPropertyChanged();
            }
        }
        private void LoadPayInfo(PaymentInfo _info)
        {
            singleDataInfo.Amount = _info.Amount;
            singleDataInfo.Name = _info.Name;
            singleDataInfo.Surname = _info.Surname;
        }

    }
}
