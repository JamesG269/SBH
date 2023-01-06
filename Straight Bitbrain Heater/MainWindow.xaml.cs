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
        public int AppNumber = 0;
        Process myProcess;

        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            await Task.Run(() => InitLouisianaBrainDeath());
            await InitUI();
            contextAndNotifyMenuInit();
            TB.Text = TBTemp;
            TB.CaretIndex = TB.Text.Length;
            adjustVolume = false;
            await Task.Factory.StartNew(() => E10EBackGroundThread(), TaskCreationOptions.LongRunning);
            PlayingE10E = true;
        }

    }
}
