using System.Drawing;
using Color = Microsoft.Maui.Graphics.Color;

namespace Registerpagge;

public partial class NewContent1 : ContentView
{
        int count = 0;

        public NewContent1()
        {
            InitializeComponent();

            slider1.Minimum = 0;
            slider1.Maximum = 100;
            slider1.ValueChanged += Slider1_ValueChanged;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }

        public void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = $"Current Score: {e.NewValue}";

            if (e.NewValue >= 0 && e.NewValue <= 39)
            {
                label2.Text = "Failed";
            }
            else if (e.NewValue >= 40 && e.NewValue <= 79)
            {
                label2.Text = "Passed";
            }
            else if (e.NewValue >= 80 && e.NewValue <= 100)
            {
                label2.Text = "Excellent";
            }
    }


}

}


