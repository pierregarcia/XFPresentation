using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

namespace XFPresentation
{
    public partial class XFPresentationXaml : ContentPage
    {
        public XFPresentationXaml()
        {
            InitializeComponent();
        }

        public void OnItemSelected (object sender, SelectedItemChangedEventArgs e) {
            if (e.SelectedItem == null) {
                return;
            }

            var item = (Tuple<string, ContentPage>)e.SelectedItem;

            Navigation.PushAsync(item.Item2);

            ((ListView)sender).SelectedItem = null;
        }
    }
}

