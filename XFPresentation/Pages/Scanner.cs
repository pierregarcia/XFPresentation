using System;

using Xamarin.Forms;
using System.Diagnostics;

namespace XFPresentation
{
    public class Scanner : ContentPage
    {
        public Scanner()
        {
            var scanButton = new Button { Text = "Scan" };

            scanButton.Clicked += async (sender, e) =>
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();

                if (result != null)
                {
                    DisplayAlert ("ZXing", "Scanned Barcode: " + result.Text, "OK");
                }
            };
            
            Content = new StackLayout
            { 
                Children =
                {
                    scanButton
                }
            };

           
        }
    }
}


