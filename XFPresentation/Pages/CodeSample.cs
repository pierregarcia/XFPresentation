using System;

using Xamarin.Forms;

namespace XFPresentation
{
    public class CodeSample : ContentPage
    {
        public CodeSample()
        {
            Content = new StackLayout
            { 
                Padding = new Thickness(0,20,0,0),
                VerticalOptions = LayoutOptions.Fill,
                Children =
                {
                    new Label 
                    { 
                        Text = "Label",
                        BackgroundColor = Color.Blue,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.Center,
                    },
                    new Button
                    {
                        Text = "Button",
                        BackgroundColor = Color.Blue,
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.Center,
                    }
                }
            };
        }
    }
}