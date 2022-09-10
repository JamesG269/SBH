﻿using Microsoft.Win32;
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
        public int FindRegKey()
        {
            int i = 0;
            int pid = 0;
            RegKeyName = @"SOFTWARE\StraightBitbrainHeater0";
            RegKeyCurrent = Registry.CurrentUser.OpenSubKey(RegKeyName);
            if (RegKeyCurrent == null)
            {
                for (i = 0; i < 10; i++)
                {
                    RegKeyName = @"SOFTWARE\StraightBitbrainHeater" + i.ToString();
                    RegKeyCurrent = Registry.CurrentUser.CreateSubKey(RegKeyName);
                    RegKeyCurrent.SetValue("pid", 0, RegistryValueKind.DWord);
                    RegKeyCurrent.SetValue("Volume", 100, RegistryValueKind.DWord);
                    RegKeyCurrent.SetValue("Rate", 0, RegistryValueKind.DWord);
                    RegKeyCurrent.Close();
                }
            }
            else
            {
                RegKeyCurrent.Close();
            }
            bool foundReg = false;
            for (i = 0; i < 10; i++)
            {
                RegKeyName = @"SOFTWARE\StraightBitbrainHeater" + i.ToString();
                RegKeyCurrent = Registry.CurrentUser.OpenSubKey(RegKeyName);
                pid = Convert.ToInt32(RegKeyCurrent.GetValue("pid", RegistryValueKind.DWord));
                RegKeyCurrent.Close();
                if (!pids.Contains(pid))
                {
                    foundReg = true;
                    RegKeyCurrent = Registry.CurrentUser.CreateSubKey(RegKeyName);
                    RegKeyCurrent.SetValue("pid", myID, RegistryValueKind.DWord);
                    Volume = Convert.ToInt32(RegKeyCurrent.GetValue("Volume", RegistryValueKind.DWord));
                    Rate = Convert.ToInt32(RegKeyCurrent.GetValue("Rate", RegistryValueKind.DWord));
                    RegKeyCurrent.Close();
                    break;
                }
            }
            if (foundReg == false)
            {
                MessageBox.Show("Found no empty registry keys");
                Close();
            }
            return i;
        }
        private void StoreSettings()
        {
            if (enableStoreSettings == true && needToStoreSettings == true)
            {
                RegKeyCurrent = Registry.CurrentUser.CreateSubKey(RegKeyName);
                RegKeyCurrent.SetValue("Rate", Rate, RegistryValueKind.DWord);
                RegKeyCurrent.SetValue("Volume", Volume, RegistryValueKind.DWord);
                RegKeyCurrent.Close();
                needToStoreSettings = false;
            }
        }
        private void reloadSBH()
        {
            Reload = false;
            string pathToSBHTxt = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\documents\SBH.txt";
            SBHTemplate = File.ReadAllLines(pathToSBHTxt).Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;
        }
    }
}