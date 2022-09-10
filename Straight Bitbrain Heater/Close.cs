using Microsoft.Win32;
using SpeechLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows;
using System.Windows.Controls;

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
            await StopE10E();
            while (MakingWav == 1)
            {
                await Task.Delay(10);
            }
            if (ni != null)
            {
                ni.Dispose();
                ni = null;
            }
            StoreSettings();
        }
    }
}