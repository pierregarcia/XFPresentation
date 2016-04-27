using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFPresentation
{
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
            BindingContext = new VisibilityViewModel();
        }
    }
}

