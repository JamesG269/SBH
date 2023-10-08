using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
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
        public List<WavComboData> wavComboList = new List<WavComboData>();
        public List<SSVoiceData> SSVoiceList = new List<SSVoiceData>();
        public class WavComboData
        {
            public string Name { get; set; }
            public SpeechLib.SpObjectToken SpObj { get; set; }
        }
        public class SSVoiceData
        {
            public string Name { get; set; }
        }
        private void PopulateComboBox()
        {                        
            voiceComboBox.ItemsSource = SSVoiceList;
            voiceComboBox.DisplayMemberPath = "Name";
            voiceComboBox.SelectedIndex = 0;                   
            wavComboBox.ItemsSource = wavComboList;
            wavComboBox.DisplayMemberPath = "Name";
            wavComboBox.SelectedIndex = 0;            
        }
        
        private async void VoiceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await StopE10E();
            var ss = voiceComboBox.SelectedItem as SSVoiceData;
            FarThought.SelectVoice(ss.Name);
            await BHTextOutput("BH Voice changed to: " + ss.Name);
            await StartE10E();
        }

        private async void WavComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var wcb = wavComboBox.SelectedItem as WavComboData;
            objSpeech.Voice = wcb.SpObj;
            await BHTextOutput("Wav voice changed to: " + wcb.Name);            
        }
        private void InitComboBoxData()
        {
            SSVoices = FarThought.GetInstalledVoices();
            foreach (var ss in SSVoices)
            {
                SSVoiceList.Add(new SSVoiceData { Name = ss.VoiceInfo.Name });
            }
            var voices = objSpeech.GetVoices();
            string str;
            for (int i = 0; i < voices.Count; i++)
            {
                str = voices.Item(i).Id.Substring(voices.Item(i).Id.LastIndexOf('\\') + 1);
                wavComboList.Add(new WavComboData { SpObj = voices.Item(i), Name = str });
            }
        }
    }
}