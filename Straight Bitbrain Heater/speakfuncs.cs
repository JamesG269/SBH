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
namespace Straight_Bitbrain_Heater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool PlayingE10ESentence = false;
        public static string E10ESentence = "";
        public string[] SBHTemplate;
        public static void StartE10E()
        {
            PlayingE10ESentence = false;
            PlayingE10E = true;
        }
        public async Task StopE10E()
        {
            PlayingE10E = false;
            PlayingE10ESentence = false;
            while (MakingWav == 1)
            {
                await Task.Delay(10);
            }
        }
        public async Task E10EBackGroundThread()
        {
            int i;
            while (true)
            {                
                while (PlayingE10E == true)
                {
                    if (Interlocked.Exchange(ref MakingWav, 1) == 1)
                    {
                        PlayingE10E = false;
                        break;
                    }
                    if (Reload)
                    {
                        reloadSBH();
                        PlayingE10E = true;
                    }
                    i = 0;
                    string E10Ereturn = "";
                    if (PlayingE10ESentence)
                    {     
                        E10Ereturn = replace_func(E10ESentence);
                    }
                    else
                    {
                        E10Ereturn += start3(SBHTemplate);
                    }
                    await play_E10Eworker(E10Ereturn);
                    await Task.Delay(100);
                    MakingWav = 0;
                }                
                await Task.Delay(100);
            }
        }
        public async Task play_E10Eworker(string E10Ereturn)
        {
            bool save = false;
            while (adjustVolume)
            {
                save = true;
                adjustVolume = false;
                await Task.Delay(1000);
            }
            if (save)
            {
                StoreSettings();
            }
            await BinaryLabelWorker(E10Ereturn);
            await BHTextOutput(E10Ereturn);
            await SpeakE10E(E10Ereturn);

            StoreSettings();
            if (myProcess.WorkingSet64 > 500000000)
            {
                System.Windows.Forms.Application.Restart();
            }
        }
        public bool finishedPlayingE10E = false;
        public bool speaking = false;
        List<int> voiceIdx = new List<int>();
        public static int lasti = -1;
        public async Task SpeakE10E(string E10Ereturn)
        {
            FarThought.Volume = Volume;
            FarThought.Rate = Rate;
            speaking = true;
            int i;
            var voices = FarThought.GetInstalledVoices();
            do
            {
                i = RandomNumber.Rand4(voices.Count);
            } while (i == lasti);
            lasti = i;
            FarThought.SpeakAsync(E10Ereturn);

            while (speaking)
            {
                if (adjustVolume || !PlayingE10E || Reload)
                {
                    FarThought.SpeakAsyncCancelAll();
                    if (adjustVolume)
                    {
                        await BHTextOutput("Volume or rate changed. restarting output." + Environment.NewLine);
                    }
                    else if (Reload)
                    {
                        await BHTextOutput("Reload pressed." + Environment.NewLine);
                    }
                    else
                    {
                        await BHTextOutput("Stop pressed." + Environment.NewLine);
                    }
                }
                await Task.Delay(100);
            }
        }
        public void FarThought_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            speaking = false;
        }

    }
}