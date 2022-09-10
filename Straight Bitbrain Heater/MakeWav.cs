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
        public int MakingWav = 0;
        private async void MakeWavButton(object sender, RoutedEventArgs e)
        {
            StopE10E();
            while (Interlocked.Exchange(ref MakingWav, 1) == 1)
            {
                await Task.Delay(10);
            }
            BHTextBox.Text = "Making .Wav ..." + Environment.NewLine;
            await Task.Run(() => MakeWavWorker());
            BHTextBox.Text = "Done Making .Wav" + Environment.NewLine;
            MessageBox.Show("Done making .WAV", "Done Making .WAV", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
            MakingWav = 0;
        }

        private void MakeWavWorker()
        {
            reloadSBH();
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();
            sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            sfd.Title = "Save to a wave file";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == true)
            {
                PlayingE10E = true;
                string E10Ereturn = "";
                string[] tempE10E = new string[1];
                foreach (var t in SBHTemplate)
                {
                    tempE10E[0] = t;
                    int i = 0;
                    while (i < 10)
                    {
                        i++;
                        E10Ereturn += start3(tempE10E);
                    }
                }
                SpeechStreamFileMode SpFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
                SpFileStream SpFileStream = new SpFileStream();
                SpFileStream.Open(sfd.FileName, SpFileMode, false);
                SpVoice objSpeech = new SpVoice();
                objSpeech.AudioOutputStream = SpFileStream;
                SpObjectToken vc2 = objSpeech.GetVoices().Item(0);
                objSpeech.Voice = vc2;
                objSpeech.Rate = Rate;
                objSpeech.Volume = 100;
                objSpeech.Speak(E10Ereturn, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                objSpeech.WaitUntilDone(Timeout.Infinite);
                SpFileStream.Close();
                PlayingE10E = false;
            }
        }
    }
}