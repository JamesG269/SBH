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
        public ReadOnlyCollection<InstalledVoice> voices;// = FarThought.GetInstalledVoices();
        private int InitLouisianaBrainDeath()
        {
            Task.Factory.StartNew(() => WaitForEvent(), TaskCreationOptions.LongRunning);
            InitRNGKeys();
            myProcess = Process.GetCurrentProcess();
            ClosePreviousInstance();
            int i = FindRegKey();
            FarThought.SpeakCompleted += FarThought_SpeakCompleted;
            voices = FarThought.GetInstalledVoices();
            foreach (var v in voices)
            {
                if (v.VoiceInfo.Name.Contains("Demon"))
                {
                    FarThought.SelectVoice(v.VoiceInfo.Name);
                    break;
                }
            }
            enableStoreSettings = true;
            reloadSBH();
            return i;
        }


        List<int> pids = new List<int>();
        int myID;
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
            return;
        }
        private async void WaitForEvent()
        {
            string evtName = "SBHExitRequest" + Process.GetCurrentProcess().Id.ToString();
            EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
            evt.WaitOne();
            evt.Close();
            StopE10E();
            await this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { Close(); }));
        }
    }
}