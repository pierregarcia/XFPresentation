using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFPresentation
{
    public partial class Animations : ContentPage
    {
        public Animations()
        {
            InitializeComponent();
            rect.GestureRecognizers.Add(new TapGestureRecognizer(){ Command = new Command(async ()=> await Rotate(2))});
            rectFade.GestureRecognizers.Add(new TapGestureRecognizer(){ Command = new Command(async ()=> await Fade())});
            rectLayout.GestureRecognizers.Add(new TapGestureRecognizer(){ Command = new Command(async ()=> await Layout())});
        }

        private  async Task Rotate(double xRotation)
        {  
            await rect.RotateTo(xRotation);
            await Rotate(xRotation + 8);
        }

        private async Task Fade()
        {
            await rectFade.FadeTo(0, 2000).
            ContinueWith( t =>
                {
                    rectFade.FadeTo(1, 2000);
                },
                TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async Task Layout()
        {
            var bounds = rectLayout.Bounds;
            bounds.X = Bounds.Width - bounds.Right;
            await rectLayout.LayoutTo(bounds);
        }

    }
}

