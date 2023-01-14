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
        private string GetPublishedVersion()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.
                    CurrentVersion.ToString();
            }
            return "Not network deployed";
        }

        public string RegKeyName = "";
        public RegistryKey RegKeyCurrent;
        public ReadOnlyCollection<InstalledVoice> voices;
        private void InitLouisianaBrainDeath()
        {
            Task.Factory.StartNew(() => WaitForEvent(), TaskCreationOptions.LongRunning);
            InitRNGKeys();
            myProcess = Process.GetCurrentProcess();
            ClosePreviousInstance();
            FindRegKey();
            FarThought.SpeakCompleted += FarThought_SpeakCompleted;
            voices = FarThought.GetInstalledVoices();            
            enableStoreSettings = true;
            ReloadSBH();
        }


        public List<int> pids = new List<int>();
        public int myID;
        private void ClosePreviousInstance()
        {
            Process[] pname = Process.GetProcesses();
            myID = myProcess.Id;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.AboveNormal;
            var MyName = "Straight Bitbrain Heater";
            foreach (var p in pname)
            {
                if (p.ProcessName == MyName)
                {
                    pids.Add(p.Id);
                    if (p.Id == -1) // != myID) - removed to run multiple instances.
                    {
                        if (!System.Diagnostics.Debugger.IsAttached)
                        {
                            string evtName = "SBHExitRequest" + p.Id.ToString();
                            EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
                            evt.Set();
                            evt.Reset();
                            evt.Close();
                            p.WaitForExit();
                        }
                    }
                }
            }
        }
        private async void WaitForEvent()
        {
            string evtName = "SBHExitRequest" + Process.GetCurrentProcess().Id.ToString();
            EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
            evt.WaitOne();
            evt.Close();
            await StopE10E();
            await this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { Close(); }));
        }
        private async Task InitUI()
        {
            VolumeSlider.Value = Volume;
            RateSlider.Value = Rate;
            VolumeLabel.Content = "Volume: " + Volume.ToString();
            RateLabel.Content = "Rate: " + Rate.ToString();
            this.Title = "Straight Bitbrain Heater by James Gentile version: " + GetPublishedVersion() + " Number " + AppNumber.ToString();
            string BHTextStr = "Voices installed: " + Environment.NewLine;
            foreach (var v in voices)
            {
                BHTextStr += v.VoiceInfo.Name + Environment.NewLine;
            }
            BHTextStr += Environment.NewLine;
            await BHTextOutput(BHTextStr);
            BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
        }
    }
}