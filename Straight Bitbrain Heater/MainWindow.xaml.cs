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
        public static SpeechSynthesizer FarThought = new SpeechSynthesizer();

        public static int Volume = 100;
        public static int Rate = 0;
        public static Boolean enableStoreSettings = false;
        public static Boolean PlayingE10E = false;
        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
        System.Windows.Forms.ContextMenu contextMenu1 = new System.Windows.Forms.ContextMenu();
        public Boolean windowhidden = false;
        private Boolean needToStoreSettings = false;

        Process myProcess;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            int i = await Task.Run(() => InitLouisianaBrainDeath());

            VolumeSlider.Value = Volume;
            RateSlider.Value = Rate;
            VolumeLabel.Content = "Volume: " + Volume.ToString();
            RateLabel.Content = "Rate: " + Rate.ToString();

            this.Title = "Straight Bitbrain Heater by James Gentile version: " + GetPublishedVersion() + " Number " + i.ToString();

            contextMenu1.MenuItems.Add(0, new System.Windows.Forms.MenuItem("Play", new System.EventHandler(PlayNI)));
            contextMenu1.MenuItems.Add(1, new System.Windows.Forms.MenuItem("Stop", new System.EventHandler(StopNI)));
            contextMenu1.MenuItems.Add(2, new System.Windows.Forms.MenuItem("Exit", new System.EventHandler(ExitNI)));

            ni.ContextMenu = contextMenu1;
            ni.Icon = new System.Drawing.Icon(@"c:\users\" + Environment.UserName + @"\source\repos\SBH\Straight Bitbrain Heater\cd.ico");

            ni.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpNI);
            ni.Visible = true;
            ni.Text = "Straight Bitbrain Heater";

            BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
            PlayingE10E = true;
            await Task.Factory.StartNew(() => E10EBackGroundThread(), TaskCreationOptions.LongRunning);
            WindowState = WindowState.Minimized;
        }
        
        public bool finishedPlayingE10E = false;
        public bool speaking = false;
        public void FarThought_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            speaking = false;
        }

        public void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter)
            {
                return;
            }
            E10ESentence = TB.Text;            
            StopE10E();
            PlayingE10ESentence = true;
            PlayingE10E = true;
        }

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
            StopE10E();
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

        bool Reload = false;        
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Reload = true;                        
        }
    }

}
