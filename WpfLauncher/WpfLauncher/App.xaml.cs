﻿using System.IO;
using System.IO.Compression;
using System.Windows;

namespace WpfLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private const string TheVenomEvent = "TheVenomEvent";
        private const string TheVenomEventCurrentVersion = "_0_0_3";
        private const string TheVenomEventAppDirectory = ".\\" + App.TheVenomEvent + App.TheVenomEventCurrentVersion + "\\";
        public const string TheVenomEventExePath = App.TheVenomEventAppDirectory + "The Venom Event 0.0.3.exe";

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            if (!Directory.Exists(App.TheVenomEventAppDirectory))
            {
                ZipFile.ExtractToDirectory("./game_files/TheVenomEvent_0_0_3.zip", App.TheVenomEventAppDirectory);
            }
        }
    }
}
