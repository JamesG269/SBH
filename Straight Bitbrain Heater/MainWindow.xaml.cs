using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using sentence_generator;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Windows.Interop;
using System.Windows.Media;
using Microsoft.VisualBasic;
using System.Windows.Automation;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using DeepSpeechClient;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

// OnSourceInitialized has buttons, first 4 key handlers = across second row of 4 buttons in order....

namespace Straight_Bitbrain_Heater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("Text2SpeechConsole.dll")]
        private static extern int text2speechspeak(string c, int vol, int rate);
        [DllImport("Text2SpeechConsole.dll")]
        private static extern void text2speechstop();
        [DllImport("Text2SpeechConsole.dll")]
        private static extern void text2speechinit();
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool turnOn);
        [DllImport("user32.dll")]
        static extern IntPtr SetFocus(HandleRef hWnd);

        public static SpeechSynthesizer FarThought = new SpeechSynthesizer();
        private const uint MOD_NONE = 0x0000; //(none)
        private const uint MOD_ALT = 0x0001; //ALT
        private const uint MOD_CONTROL = 0x0002; //CTRL
        private const uint MOD_SHIFT = 0x0004; //SHIFT
        private const uint MOD_WIN = 0x0008; //WINDOWS

        private const int HOTKEY_ID = 9000;
        private const int HOTKEY_ID2 = 9001;
        private const int HOTKEY_ID3 = 9002;
        private const int HOTKEY_ID4 = 9003;
        private const int HOTKEY_ID5 = 9004;
        private const int HOTKEY_ID6 = 9005;
        private const uint VK_CAPITAL = 0x14;
        private const uint VK_CHANNELUP = 79;
        private const uint VK_CHANNELDOWN = 71;

        private IntPtr _windowHandle;
        private HwndSource _source;

        public static int Volume = 100;
        public static int Rate = 0;
        public static Boolean enableSave = false;
        public static Boolean PlayingE10E = false;
        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
        System.Windows.Forms.ContextMenu contextMenu1 = new System.Windows.Forms.ContextMenu();
        public Boolean windowhidden = false;
        private Boolean needToSave = false;
        string[] dict;
        //public string PathToSlideShow;
        [StructLayout(LayoutKind.Sequential)]
        
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        Process myProcess;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            await Task.Run(() => InitLouisianaBrainDeath());
            WindowState = WindowState.Minimized;
            VolumeSlider.Value = Volume;
            RateSlider.Value = Rate;
            VolumeLabel.Content = "Volume: " + Volume.ToString();
            RateLabel.Content = "Rate: " + Rate.ToString();
            this.Title = "Straight Bitbrain Heater v2 by James Gentile";

            contextMenu1.MenuItems.Add(0, new System.Windows.Forms.MenuItem("Play", new System.EventHandler(PlayNI)));
            contextMenu1.MenuItems.Add(1, new System.Windows.Forms.MenuItem("Stop", new System.EventHandler(StopNI)));
            contextMenu1.MenuItems.Add(2, new System.Windows.Forms.MenuItem("Exit", new System.EventHandler(ExitNI)));

            ni.ContextMenu = contextMenu1;
            ni.Icon = new System.Drawing.Icon(@"c:\users\" + Environment.UserName + @"\source\repos\Straight Bitbrain Heater\Straight Bitbrain Heater\Rade8-Minium-2-Device-CD.ico");

            ni.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpNI);
            ni.Visible = true;
            ni.Text = "Straight Bitbrain Heater";

            BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
            //Topmost = true;
            start_E10E();
            dict = File.ReadAllLines(@"C:\Users\jgentile\Documents\PowerShell\dict3.txt");
            


            enableSave = true;
            FarThought.SpeakCompleted += FarThought_SpeakCompleted;
            adjustVolume = false;
            await Task.Factory.StartNew(() => play_E10E(), TaskCreationOptions.LongRunning);
            
            
        }

        private void InitLouisianaBrainDeath()
        {
            Process[] pname = Process.GetProcesses();
            myProcess = Process.GetCurrentProcess();
            var myID = myProcess.Id;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Idle;
            var MyName = "Straight Bitbrain Heater";

            foreach (var p in pname)
            {
                if (p.ProcessName == MyName)
                {
                    if (p.Id == -1) // != myID) - removed to run multiple instances.
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

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\StraightBitbrainHeater");
            Volume = key != null ? Convert.ToInt32(key.GetValue("volume", RegistryValueKind.DWord)) : 100;
            Rate = key != null ? Convert.ToInt32(key.GetValue("rate", RegistryValueKind.DWord)) : 0;
            //PathToSlideShow = key != null ? key.GetValue("SlideShowPath", RegistryValueKind.String).ToString() : "";

            if (key != null)
            {
                key.Close();
            }

            text2speechinit();
            Task.Factory.StartNew(() => WaitForEvent(), TaskCreationOptions.LongRunning);
        }

        private async void WaitForEvent()
        {
            string evtName = "SBHExitRequest" + Process.GetCurrentProcess().Id.ToString();
            EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
            evt.WaitOne();
            evt.Close();
            await Stop_E10E();
            await this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { Close(); }));
        }
        public void MouseUpNI(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (windowhidden == false)
                {
                    this.Hide();
                    windowhidden = true;
                }
                else
                {
                    ShowOnDesktop();
                }
            }
        }

        private void ShowOnDesktop()
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            Activate();
            windowhidden = false;
        }

        public async void ExitNI(Object sender, System.EventArgs e)
        {
            await Stop_E10E();
            Close();
        }
        public void PlayNI(Object sender, System.EventArgs e)
        {
            start_E10E();
        }
        public async void StopNI(Object sender, System.EventArgs e)
        {
            await Stop_E10E();
        }
        private void Start_Click(Object sender, RoutedEventArgs e)
        {
            start_E10E();
        }
        private async void StopButton_Click(object sender, RoutedEventArgs e)
        {
            await Stop_E10E();
        }
        public int BinaryLabelCounter = 0;
        public static bool adjustVolume = false;
        public List<string> binaryList = new List<string>();
        private void start_E10E()
        {
            getnewE10E = true;
            PlayingE10E = true;            
        }

        public async void play_E10E()
        {
            //int t2sreturn = text2speechspeak("straight bitbrain heater started.", Volume, Rate);
            int tempReload = reload;
            int pscount = 0;
            string E10Ereturn = genE10E(out pscount);
            dict.Append(nanoshit3.get_far_thought_list());
            dict.Append(nanoshit3.get_bit_modify());
            while (true)
            {               
                while (PlayingE10E == false)
                {                    
                    await Task.Delay(100);                    
                }
                while (adjustVolume)
                {
                    adjustVolume = false;
                    await Task.Delay(1000);
                    getnewE10E = true;
                }                
                if (getnewE10E)
                {
                    getnewE10E = false;
                    E10Ereturn = genE10E(out pscount);
                }
                //E10Ereturn = nanoshit3.RemoveExtraWhitespace(E10Ereturn);
                int i = nanoshit3.RandomNumber.Rand4(5)+5;
                //E10Ereturn = "";
               /* while (i > 0)
                {
                    if (nanoshit3.RandomNumber.Rand4(2) == 0)
                    {
                        E10Ereturn += nanoshit3.get_far_thought_list() + " ";
                    }
                    {
                        E10Ereturn += nanoshit3.get_bit_modify() + " ";
                    }
                    i--;
                }*/
                i = nanoshit3.RandomNumber.Rand4(2);
                if (i == 0)
                {
                    //E10Ereturn += nanoshit3.get_far_thought_list();
                }
                else
                {
                    //E10Ereturn += nanoshit3.get_bit_modify();
                }
                System.Windows.Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    if (BHTextBox.Text.Length > 10000)
                    {
                        BHTextBox.Text = BHTextBox.Text.Substring(BHTextBox.Text.Length - 10000);
                    }
                    BHTextBox.AppendText(E10Ereturn + Environment.NewLine + Environment.NewLine + "reload = " + tempReload.ToString() + Environment.NewLine + pscount.ToString() + " " + "PureSenseFile Count" + Environment.NewLine + Environment.NewLine);
                    BHTextBox.ScrollToEnd();

                    BinaryLabelWorker(E10Ereturn);
                }));
                if (E10Ereturn.Contains("@"))
                {
                    E10Ereturn = E10Ereturn.Substring(0, E10Ereturn.IndexOf("@"));
                }
                //E10Ereturn = ToBinary(ConvertToByteArray(E10Ereturn, Encoding.ASCII));
                //E10Ereturn = "700 megabytes style";
                //int t = text2speechspeak(E10Ereturn, Volume, -10);
                FarThought.SelectVoiceByHints(VoiceGender.Female);
                FarThought.Volume = Volume;
                FarThought.Rate = Rate;
                speaking = true;
                //E10Ereturn = "una cero una cero una cero una cero";
                //E10Ereturn = "{eastside jail bitch,buy a house for pussy sucker, fights like bitch} has a bit in his head, and james is twice the effect without the meaning";

                //E10Ereturn = nanoshit3.replace_functions(E10Ereturn);               
                FarThought.SpeakAsync(E10Ereturn);
                string newE10E = "";
                i = 1;
                
                while (speaking)
                {
                    if (adjustVolume || !PlayingE10E || restartE10E)                    
                    {                        
                        //FarThought.SpeakAsyncCancelAll();
                        restartE10E = false;
                        speaking = false;                        
                        break;
                    }
                    if (i > 0)
                    {
                        //newE10E = genE10E(out pscount); //+ " Pure Sense End ";
                        i--;
                    }
                    await Task.Delay(400);
                }
                int r;
                E10Ereturn = genE10E(out pscount);
                //E10Ereturn = newE10E;
                tempReload = reload;
                SaveShit();
                if (myProcess.WorkingSet64 > 500000000)
                {
                    System.Windows.Forms.Application.Restart();
                }
                Thread.Sleep(2000);
            }
        }
        public string genE10E(out int pscount)
        {
            string E10Ereturn = "";
            if (reload == 1)
            {
                reload = 2;
                E10Ereturn += nanoshit3.start3(out pscount, false, 1) + " ";
            }
            else
            {
                E10Ereturn += nanoshit3.start3(out pscount, false, reload) + " ";
            }
            return E10Ereturn;
        }

        public bool speaking = false;
        public void FarThought_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            speaking = false;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void BinaryLabelWorker(string str)
        {
            string s = "1";
            if (str.Length % 2 == 0)
            {
                s = "0";
            }
            if (BinaryLabel.Foreground == System.Windows.Media.Brushes.Red)
            {
                BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
            }
            else
            {
                BinaryLabel.Foreground = System.Windows.Media.Brushes.Red;
            }
            BinaryLabel.Content = s + " - Count: " + BinaryLabelCounter.ToString();
            BinaryLabelCounter++;
        }
        private void SaveShit()
        {
            if (enableSave == true && needToSave == true)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\StraightBitbrainHeater");
                key.SetValue("rate", Rate, RegistryValueKind.DWord);
                key.SetValue("volume", Volume, RegistryValueKind.DWord);
                key.Close();
                needToSave = false;
            }
        }
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Volume = Convert.ToInt32(value);
            needToSave = true;
            ChangeVolume(Volume);
        }

        private void RateSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Rate = Convert.ToInt32(value);
            needToSave = true;
            RateLabel.Content = "Rate: " + Rate.ToString();
            ChangeRate(Rate);
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                this.Hide();
                windowhidden = true;
            }
            base.OnStateChanged(e);
        }
        protected override async void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            await Stop_E10E();
            base.OnClosing(e);
            if (ni != null)
            {
                ni.Dispose();
            }
            SaveShit();
            return;
        }

        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            const int WM_HOTKEY = 0x0312;
            if (msg == WM_HOTKEY)
            {
                int vkey = (((int)lParam >> 16) & 0xFFFF);
                switch (wParam.ToInt32())
                {
                    case HOTKEY_ID:
                        if (vkey == VK_CHANNELUP)
                        {
                            VolumeUp();
                        }
                        handled = true;
                        break;
                    case HOTKEY_ID2:
                        if (vkey == VK_CHANNELDOWN)
                        {
                            VolumeDown();
                        }
                        handled = true;
                        break;
                    case HOTKEY_ID3:
                        if (vkey == 84)
                        {
                            if (PlayingE10E == true)
                            {
                                Stop_E10E();
                                this.Title = "Bitbrain Heater Stopped.";
                            }
                            else
                            {
                                start_E10E();
                                this.Title = "Bitbrain Heater Started.";
                            }
                        }
                        handled = true;
                        break;
                    case HOTKEY_ID4:
                        if (vkey == 77)
                        {
                            this.Title = "Open SlideShow pressed.";
                            handled = true;
                            Boolean AlreadyRunning = false;
                            foreach (var p in Process.GetProcesses())
                            {
                                if (p.ProcessName == "JRGSlideShowWPF")
                                {
                                    p.Kill();
                                    this.Title = "SlideShow Closed.";
                                    AlreadyRunning = true;
                                }
                            }
                            if (AlreadyRunning == false)
                            {
                                StartSlideShowWorker();
                            }
                        }
                        break;
                    case HOTKEY_ID5:
                        if (vkey == 49)
                        {
                            handled = true;
                            this.Title = "49 pressed";
                        }
                        break;
                    case HOTKEY_ID6:
                        if (vkey == 13) // Start button on remote.
                        {
                            handled = true;
                            StartMusicBee();
                        }
                        break;
                }
            }
            return IntPtr.Zero;
        }

        private void StartMusicBee()
        {
            Boolean AlreadyRunning = false;
            foreach (var p in Process.GetProcesses())
            {
                if (p.ProcessName == "MusicBee")
                {
                    p.Kill();
                    this.Title = "MusicBee Closed.";
                    AlreadyRunning = true;
                }
            }

            if (AlreadyRunning == false)
            {
                string fn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"software\MusicBee\MusicBee.exe");
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = fn
                };
                try
                {
                    Process.Start(start);
                    this.Title = "MusicBee Started.";
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
            }
        }
        private void ChangeVolume(int vol)
        {           
            VolumeSlider.Value = vol;
            needToSave = true;
            VolumeLabel.Content = "Volume: " + vol.ToString();
            this.Title = "Volume changed.";
            adjustVolume = true;            
        }
        private void ChangeRate(int rate)
        {            
            RateSlider.Value = rate;
            needToSave = true;
            RateLabel.Content = "Rate: " + rate.ToString();
            this.Title = "Rate changed.";
            adjustVolume = true;
        }
        private void VolumeDown()
        {
            if (Volume > 0)
            {
                Volume--;
                ChangeVolume(Volume);
            }
        }

        private async Task Stop_E10E()
        {
            if (PlayingE10E)
            {
                PlayingE10E = false;                               
            }
            while (speaking)
            {
                await Task.Delay(10);
            }
        }

        private void VolumeUp()
        {
            if (Volume < 100)
            {
                Volume++;
                ChangeVolume(Volume);
            }
        }

        private void StartSlideShow(Object sender, RoutedEventArgs e)
        {
            StartSlideShowWorker();
        }
        private void StartSlideShowWorker()
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                Arguments = "/Fullscreen",
                FileName = @"C:\Users\jrg269\source\repos\JRGSlideShowWPF\JRGSlideShowWPF\bin\x64\Release\JRGSlideShowWPF.exe",
                WindowStyle = ProcessWindowStyle.Normal
            };
            try
            {
                Process.Start(start);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void Button_VolumeUp(object sender, RoutedEventArgs e)
        {
            VolumeUp();
        }

        private void Button_VolumeDown(object sender, RoutedEventArgs e)
        {
            VolumeDown();
        }
        private void Button_ExitRDP(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo
            {
                Arguments = "1 /dest:console",
                FileName = @"c:\windows\system32\tscon.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Verb = "runas"

            };
            try
            {
                Process.Start(start);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Music(object sender, RoutedEventArgs e)
        {
            StartMusicBee();
        }

        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                string str = ToBinary(ConvertToByteArray(TB.Text, Encoding.ASCII));
                char c = str[0];
                for (int i = 1; i < str.Length; i++)
                {
                    c ^= str[i];
                }
                if (c < 48)
                {
                    c += (char)48;
                }
                BHTextBox.Text = c.ToString();
                TB.Text = "";
            }
        }
        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }
        public static String ToBinary(Byte[] data)
        {
            string str = string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(1, ' ')));
            return str;
        }

        int reload = 1;
        bool getnewE10E = true;
        bool restartE10E = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reload = 1;
            getnewE10E = true;
            restartE10E = true;
            
        }
    }

}
