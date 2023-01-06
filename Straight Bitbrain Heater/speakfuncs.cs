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
        public string[] TextBoxArray;
        public string[] SBHTemplate;
        public async Task StartE10E()
        {
            await StopE10E();
            Reload = true;            
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
                        ReloadSBH();
                        PlayingE10E = true;
                    }
                    string E10Ereturn = "";
                    if (PlayingE10ESentence)
                    {
                        int i = 0;
                        while (i < 100)
                        {
                            string str = pick(TextBoxArray, "TextBoxArray");
                            E10Ereturn += replace_func(str + " [link] ");
                            i++;
                        }
                        await play_E10Eworker(E10Ereturn);
                    }
                    else
                    {                        
                        int i = 0;
                        string str = "";
                        while (i < 100)
                        {
                            E10Ereturn = pick(SBHTemplate, "sbh");
                            str += replace_func(E10Ereturn + " [link] ");
                            i++;                                                        
                        }
                        await play_E10Eworker(str);
                    }
                    MakingWav = 0;
                }                
                await Task.Delay(100);
            }
        }
        public async Task play_E10Eworker(string E10Ereturn)
        {            
            while (adjustVolume)
            {
                needToStoreSettings = true;
                adjustVolume = false;
                await Task.Delay(1000);
            }
            StoreSettings();
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
        public static int lasti = -1;
        public async Task SpeakE10E(string E10Ereturn)
        {
            FarThought.Volume = Volume;
            FarThought.Rate = Rate;            
            int i = 0;
            var voices = FarThought.GetInstalledVoices();
            if (voices.Count > 2)
            {
                do
                {
                    i = RandomNumber.Rand4(voices.Count);
                } while (!voices[i].VoiceInfo.Name.Contains("Demon"));//(i == lasti);
                lasti = i;
            }
            string VoiceName = voices[i].VoiceInfo.Name;
            FarThought.SelectVoice(VoiceName);
            if (VoiceName.Contains("Carolyn"))
            {
                FarThought.Volume /= 2;
            }    
            FarThought.SpeakAsync(E10Ereturn);
            speaking = true;
            while (speaking)
            {
                if (adjustVolume || !PlayingE10E || Reload)
                {
                    FarThought.SpeakAsyncCancelAll();
                    while (speaking)
                    {
                        await Task.Delay(10);
                    }
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