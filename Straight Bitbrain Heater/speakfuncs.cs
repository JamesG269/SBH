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
        public void StopE10E()
        {
            PlayingE10E = false;
            PlayingE10ESentence = false;
        }
        public async Task E10EBackGroundThread()
        {
            int i;
            while (true)
            {
                while (Interlocked.Exchange(ref MakingWav, 1) == 1)
                {
                    await Task.Delay(100);
                    continue;
                }
                while (PlayingE10E == true)
                {
                    if (Reload)
                    {
                        reloadSBH();
                        PlayingE10E = true;
                    }
                    i = 0;
                    string E10Ereturn = "";
                    if (PlayingE10ESentence)
                    {
                        E10Ereturn = E10ESentence;
                        E10Ereturn = replace_func(E10Ereturn);
                    }
                    else
                    {
                        while (i < 100)
                        {
                            i++;
                            E10Ereturn += start3(SBHTemplate);
                        }
                    }
                    await play_E10Eworker(E10Ereturn);
                    await Task.Delay(100);
                }
                MakingWav = 0;
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
        public async Task SpeakE10E(string E10Ereturn)
        {
            FarThought.Volume = Volume;
            FarThought.Rate = Rate;
            speaking = true;

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
    }
}