using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace SimpleSpriteMakerUWP
{
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<MockFile> FileList { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            FileList = new ObservableCollection<MockFile>(
                new List<MockFile>(){
                    new MockFile() { Name = "adskladlaksjd.png"},
                    new MockFile() { Name = "kekrkaf.png"},
                    new MockFile() { Name = "ajj1231f.png"},
                    new MockFile() { Name = "asd128ag.png"},
                    new MockFile() { Name = "pi352u35.png"},
                    new MockFile() { Name = "81274f.png"},
                    new MockFile() { Name = "macafasza.png"},
                    new MockFile() { Name = "9ö15lasd.png"}
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ;
        }
    }
}
