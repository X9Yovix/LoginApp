
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        public async void DisplayMessage(Object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                await DisplayAlert("Warning", "you forgot to enter you name!", "OK");
            }
            else
            {
                lblMessage.Text = "Welcome " + textName.Text;
                lblMessage.TextColor = Color.White;
                lblMessage.BackgroundColor = Color.Orange;
            }
            
        }
    }
}
