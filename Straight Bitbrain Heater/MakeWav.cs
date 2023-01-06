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
            await StopE10E();
            while (Interlocked.Exchange(ref MakingWav, 1) == 1)
            {
                await Task.Delay(10);
            }
            BHTextBox.Text = "Making .Wav ...";
            await Task.Run(() => MakeWavWorker());
            BHTextBox.Text += "Done." + Environment.NewLine;
            MessageBox.Show("Done making .WAV", "Done Making .WAV", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
            MakingWav = 0;
        }

        private void MakeWavWorker()
        {
            ReloadSBH();
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog();
            sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            sfd.Title = "Save to a .wav file";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == true)
            {
                PlayingE10E = true;
                string E10Ereturn = "";
                int i = 0;
                while (i < 100)
                {
                    i++;
                    string str;
                    str = pick(SBHTemplate,"sbhtemplate");
                    str += " [link] ";
                    E10Ereturn += replace_func(str);
                }                
                SpeechStreamFileMode SpFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
                SpFileStream SpFileStream = new SpFileStream();
                SpFileStream.Open(sfd.FileName, SpFileMode, false);
                SpVoice objSpeech = new SpVoice();
                objSpeech.AudioOutputStream = SpFileStream;
                for (i = 0; i < objSpeech.GetVoices().Count; i++)
                {
                    string str = objSpeech.GetVoices().Item(i).Id;
                    if (str.ToLower().Contains("david"))
                    {
                        objSpeech.Voice = objSpeech.GetVoices().Item(i);
                        break;
                    }
                }
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