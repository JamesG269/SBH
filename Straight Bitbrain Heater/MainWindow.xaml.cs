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

        public static int thevolume = 100;
        public static int therate = 0;
        public static Boolean enableSave = false;
        public Boolean play_bh = true;
        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
        System.Windows.Forms.ContextMenu contextMenu1 = new System.Windows.Forms.ContextMenu();
        public Boolean windowhidden = false;
        private Boolean needToSave = false;
        //public string PathToSlideShow;
        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        string DuplicateInfo = "";
        
        public MainWindow()
        {
            InitializeComponent();

            Process[] pname = Process.GetProcesses();
            var myID = Process.GetCurrentProcess().Id;
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Idle;
            var MyName = "Straight Bitbrain Heater";

            foreach (var p in pname)
            {
                if (p.ProcessName == MyName && p.Id != myID)
                {
                    string evtName = "SBHExitRequest" + p.Id.ToString();
                    EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
                    evt.Set();
                    evt.Reset();
                    evt.Close();
                    p.WaitForExit();
                }
            }

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\StraightBitbrainHeater");
            thevolume = key != null ? Convert.ToInt32(key.GetValue("volume", RegistryValueKind.DWord)) : 100;
            therate = key != null ? Convert.ToInt32(key.GetValue("rate", RegistryValueKind.DWord)) : 0;
            //PathToSlideShow = key != null ? key.GetValue("SlideShowPath", RegistryValueKind.String).ToString() : "";

            if (key != null)
            {
                key.Close();
            }
            VolumeSlider.Value = thevolume;
            RateSlider.Value = therate;
            text2speechinit();

            VolumeLabel.Content = "Volume: " + thevolume.ToString();
            RateLabel.Content = "Rate: " + therate.ToString();
            this.Title = "Straight Bitbrain Heater v2 by James Gentile";

            contextMenu1.MenuItems.Add(0, new System.Windows.Forms.MenuItem("Play", new System.EventHandler(PlayNI)));
            contextMenu1.MenuItems.Add(1, new System.Windows.Forms.MenuItem("Stop", new System.EventHandler(StopNI)));
            contextMenu1.MenuItems.Add(2, new System.Windows.Forms.MenuItem("Exit", new System.EventHandler(ExitNI)));

            ni.ContextMenu = contextMenu1;
            ni.Icon = new System.Drawing.Icon(@"c:\users\" + Environment.UserName + @"\source\repos\Straight Bitbrain Heater\Straight Bitbrain Heater\Rade8-Minium-2-Device-CD.ico");
            
            ni.MouseUp += new System.Windows.Forms.MouseEventHandler(MouseUpNI);
            ni.Visible = true;
            ni.Text = "Straight Bitbrain Heater";
            enableSave = true;
            BinaryLabel.Foreground = System.Windows.Media.Brushes.Green;
            BHTextBox.AppendText("placesa = " + sentence_generator.nanoshit2.placesa.Length.ToString() + Environment.NewLine + "athing = " + sentence_generator.nanoshit2.athing.Length.ToString() + Environment.NewLine);

            Dictionary<string, string> place_dict = new Dictionary<string, string>();
            Dictionary<string, string> thing_dict = new Dictionary<string, string>();

            
            foreach (string s in sentence_generator.nanoshit2.placesa)
            {
                if (place_dict.ContainsKey(s))
                {
                    BHTextBox.AppendText("placesa duplicate: " + s + Environment.NewLine);                    
                }
                else
                {
                    place_dict.Add(s,s);
                }
            }

            foreach (string s in sentence_generator.nanoshit2.athing)
            {
                if (thing_dict.ContainsKey(s))
                {
                    BHTextBox.AppendText("athing duplicate: " + s + Environment.NewLine);
                }
                else
                {
                    thing_dict.Add(s, s);
                }
            }

            Topmost = true;
            int t = text2speechspeak("straight bitbrain heater started.", thevolume, therate);
            Task.Factory.StartNew(() => play_bitbrainheater(), TaskCreationOptions.LongRunning);
            Task.Factory.StartNew(() => WaitForEvent(), TaskCreationOptions.LongRunning);
        }
        
        private void WaitForEvent()
        {
            string evtName = "SBHExitRequest" + Process.GetCurrentProcess().Id.ToString();
            EventWaitHandle evt = new EventWaitHandle(false, EventResetMode.ManualReset, evtName);
            evt.WaitOne();
            evt.Close();
            play_bh = false;
            text2speechstop();
            this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () { Close(); }));
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

        public void ExitNI(Object sender, System.EventArgs e)
        {
            play_bh = false;
            text2speechstop();
            Close();
        }
        public void PlayNI(Object sender, System.EventArgs e)
        {
            play_bh = true;
        }
        public void StopNI(Object sender, System.EventArgs e)
        {
            play_bh = false;
            text2speechstop();
        }
        private void Start_Click(Object sender, RoutedEventArgs e)
        {
            play_bh = true;
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            play_bh = false;
            text2speechstop();
        }
        public int BinaryLabelCounter = 0;
        public bool adjustVolume = false;
        private async void play_bitbrainheater()
        {
            while (true)
            {
                /*if (System.Windows.Forms.SystemInformation.TerminalServerSession == true)
                {
                    if (windowhidden == true)
                    {
                        ShowOnDesktop();
                    }
                }*/
                while (play_bh == true)
                {
                    while (adjustVolume)
                    {
                        adjustVolume = false;
                        await Task.Delay(1000);
                    }

                    string str = nanoshit3.start3();
                    
                    System.Windows.Application.Current.Dispatcher.Invoke(new Action(() => {
                        if (BHTextBox.Text.Length > 10000)
                        {
                            BHTextBox.Text = BHTextBox.Text.Substring(BHTextBox.Text.Length - 10000);
                        }
                        BHTextBox.AppendText(str + Environment.NewLine + Environment.NewLine);
                        BHTextBox.ScrollToEnd();

                        BinaryLabelWorker(str);
                    }));
                    if (str.Contains("@"))
                    {
                        str = str.Substring(0, str.IndexOf("@"));
                    }
                    int t = text2speechspeak(str, thevolume, therate);
                    
                    SaveShit();
                    
                }
                Thread.Sleep(250);
            }
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
                key.SetValue("rate", therate, RegistryValueKind.DWord);
                key.SetValue("volume", thevolume, RegistryValueKind.DWord);
                key.Close();
                needToSave = false;
            }
        }
        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            thevolume = Convert.ToInt32(value);
            needToSave = true;
            VolumeLabel.Content = "Volume: " + thevolume.ToString();
        }

        private void RateSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            therate = Convert.ToInt32(value);
            needToSave = true;
            RateLabel.Content = "Rate: " + therate.ToString();
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
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            
            if (ni != null)
            {
                ni.Dispose();
            }
            play_bh = false;
            text2speechstop();
            SaveShit();
            return;
            /*
            _source.RemoveHook(HwndHook);

            UnregisterHotKey(_windowHandle, HOTKEY_ID);
            UnregisterHotKey(_windowHandle, HOTKEY_ID2);
            UnregisterHotKey(_windowHandle, HOTKEY_ID3);
            UnregisterHotKey(_windowHandle, HOTKEY_ID4);
            UnregisterHotKey(_windowHandle, HOTKEY_ID5);
            UnregisterHotKey(_windowHandle, HOTKEY_ID6);
            */
            
        }

        protected override void OnSourceInitialized(EventArgs e)
        {            
            base.OnSourceInitialized(e);
            return;
            /*
            _windowHandle = new WindowInteropHelper(this).Handle;
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);
            
            RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_CONTROL, VK_CHANNELUP); //CTRL + CAPS_LOCK           
            RegisterHotKey(_windowHandle, HOTKEY_ID2, MOD_CONTROL, VK_CHANNELDOWN); //CTRL + CAPS_LOCK
            RegisterHotKey(_windowHandle, HOTKEY_ID3, MOD_CONTROL, 84); //CTRL + E
            RegisterHotKey(_windowHandle, HOTKEY_ID4, MOD_CONTROL | MOD_SHIFT, 77); //
            RegisterHotKey(_windowHandle, HOTKEY_ID5, MOD_CONTROL, 49);
            RegisterHotKey(_windowHandle, HOTKEY_ID6, MOD_WIN | MOD_ALT, 13); // Remote Start button.
            */
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
                            if (play_bh == true)
                            {
                                play_bh = false;
                                text2speechstop();
                                this.Title = "Bitbrain Heater Stopped.";
                            }
                            else
                            {
                                play_bh = true;
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

        private void VolumeDown()
        {
            if (thevolume > 0)
            {
                play_bh = false;
                text2speechstop();                
                thevolume--;
                VolumeSlider.Value = thevolume;
                needToSave = true;
                VolumeLabel.Content = "Volume: " + thevolume.ToString();
                this.Title = "Volume decreased.";
                adjustVolume = true;
                play_bh = true;                
            }
        }

        private void VolumeUp()
        {
            if (thevolume < 100)
            {
                play_bh = false;
                text2speechstop();
                thevolume++;
                VolumeSlider.Value = thevolume;
                needToSave = true;
                VolumeLabel.Content = "Volume: " + thevolume.ToString();
                this.Title = "Volume increased.";
                adjustVolume = true;
                play_bh = true;
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
    }

}
