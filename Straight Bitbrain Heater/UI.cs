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
        public void MouseUpNI(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (windowhidden == false)
                {
                    this.Hide();
                    windowhidden = true;
                }
                else
                {
                    ShowOnDesktop();
                }
            }
        }
        private void ShowOnDesktop()
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            Activate();
            windowhidden = false;
        }
        public void ExitNI(Object sender, System.EventArgs e)
        {
            Close();
        }
        public void PlayNI(Object sender, System.EventArgs e)
        {
            StartE10E();
        }
        public async void StopNI(Object sender, System.EventArgs e)
        {
            await StopE10E();
        }
        private void Start_Click(Object sender, RoutedEventArgs e)
        {
            StartE10E();
        }
        private async void StopButton_Click(object sender, RoutedEventArgs e)
        {
            await StopE10E();
        }
        public async Task<string> GetTB()
        {
            String str = "";
            await TB.Dispatcher.BeginInvoke(new Action(() =>
            {
                str = TB.Text;
            }));
            return str;
        }
        public async Task BHTextOutput(string BHText)
        {
            await BHTextBox.Dispatcher.BeginInvoke(new Action(() =>
            {
                BHTextBox.AppendText(BHText + Environment.NewLine + Environment.NewLine);
                BHTextBox.CaretIndex = BHTextBox.Text.Length;
                BHTextBox.Focus();
                BHTextBox.ScrollToEnd();
                TB.Focus();
            }));
        }
        public int BinaryLabelCounter = 0;
        private async Task BinaryLabelWorker(string str)
        {
            await BinaryLabel.Dispatcher.BeginInvoke(new Action(() =>
            {
                string s = "1";
                if (str.Length % 2 == 0)
                {
                    s = "0";
                }
                if (BinaryLabel.Foreground == System.Windows.Media.Brushes.Red)
                {
                    BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
                }
                else
                {
                    BinaryLabel.Foreground = System.Windows.Media.Brushes.Red;
                }
                BinaryLabel.Content = s + " - Count: " + BinaryLabelCounter.ToString();
                BinaryLabelCounter++;
            }));
        }
        private void RateSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Rate = Convert.ToInt32(value);
            needToStoreSettings = true;
            RateLabel.Content = "Rate: " + Rate.ToString();
            ChangeRate(Rate);
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                this.Hide();
                windowhidden = true;
            }
            base.OnStateChanged(e);
        }
        public static bool adjustVolume = false;
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Volume = Convert.ToInt32(value);
            needToStoreSettings = true;
            ChangeVolume(Volume);
        }
        private void ChangeVolume(int vol)
        {
            VolumeSlider.Value = vol;
            needToStoreSettings = true;
            VolumeLabel.Content = "Volume: " + vol.ToString();
            this.Title = "Volume changed.";
            adjustVolume = true;
        }
        private void ChangeRate(int rate)
        {
            RateSlider.Value = rate;
            needToStoreSettings = true;
            RateLabel.Content = "Rate: " + rate.ToString();
            this.Title = "Rate changed.";
            adjustVolume = true;
        }
        public async void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter)
            {
                return;
            }
            E10ESentence = TB.Text;
            await StopE10E();
            PlayingE10ESentence = true;
            PlayingE10E = true;
        }
        private void contextAndNotifyMenuInit()
        {
            contextMenu1.MenuItems.Add(0, new System.Windows.Forms.MenuItem("Play", new System.EventHandler(PlayNI)));
            contextMenu1.MenuItems.Add(1, new System.Windows.Forms.MenuItem("Stop", new System.EventHandler(StopNI)));
            contextMenu1.MenuItems.Add(2, new System.Windows.Forms.MenuItem("Exit", new System.EventHandler(ExitNI)));

            ni.ContextMenu = contextMenu1;
            ni.Icon = new System.Drawing.Icon(@"c:\users\" + Environment.UserName + @"\source\repos\SBH\Straight Bitbrain Heater\cd.ico");
            ni.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpNI);
            ni.Visible = true;
            ni.Text = "Straight Bitbrain Heater";
        }
        bool Reload = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reload = true;
        }
    }
}