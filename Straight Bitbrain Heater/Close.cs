using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;


// copyright (c) 2022 James Raymond Gentile Idlewild dr. Houma LA
namespace Straight_Bitbrain_Heater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private async void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            await closeFunctions();
        }
        private async void Window_Closed(object sender, EventArgs e)
        {
            await closeFunctions();
        }
        private async Task closeFunctions()
        {          
            if (ni.Icon != null)
            {
                ni.Icon.Dispose();
                ni.Icon = null;
            }
            if (ni != null)
            {
                ni.Dispose();
                ni = null;
            }
            await StopE10E();                       
            StoreSettings();
        }
    }
}