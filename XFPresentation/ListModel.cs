using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XFPresentation
{
    public static class ListModel
    {
        public static List<Tuple<string, ContentPage>> Items{ get; set;} = new List<Tuple<string, ContentPage>>
        {
            Tuple.Create("Code Sample", (ContentPage)new CodeSample()),
            Tuple.Create("Xaml Sample", (ContentPage)new XamlSample()),
            Tuple.Create("Animations", (ContentPage)new Animations()),
            Tuple.Create("Scanner", (ContentPage)new Scanner()),
            Tuple.Create("Binding And Converters", (ContentPage)new BindingPage()),
        };

    }
}

