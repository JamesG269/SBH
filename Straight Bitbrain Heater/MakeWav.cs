using SpeechLib;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

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
            BHTextBox.Text += "Done." + System.Environment.NewLine;
            MessageBox.Show("Done making .WAV", "Done Making .WAV", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
            MakingWav = 0;
        }
        public SpVoice objSpeech = new SpVoice();

        private void MakeWavWorker()
        {
            ReloadSBH();
            Microsoft.Win32.SaveFileDialog sfd = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav",
                Title = "Save to a .wav file",
                FilterIndex = 2,
                RestoreDirectory = true
            };

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
                    E10Ereturn += replace_func(str);
                }                
                SpeechStreamFileMode SpFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
                SpFileStream SpFileStream = new SpFileStream();
                SpFileStream.Open(sfd.FileName, SpFileMode, false);                
                objSpeech.AudioOutputStream = SpFileStream;                
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