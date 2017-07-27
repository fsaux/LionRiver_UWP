using System;
using System.Collections.Generic;
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
using Windows.UI;
using Windows.UI.ViewManagement;
using MapControl;
using Windows.Storage;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LionRiver
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MapTileLayer MapLayer3 = new MapTileLayer
        {
            SourceName = "openstreetmap",
            TileSource = new TileSource
            {
                UriFormat = "http://{c}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            }
        };

        //private TileLayer layer1 = new TileLayer
        //{
        //    SourceName = "OSM",
        //    TileSource = new TileSource { UriFormat = "http://{c}.tile.openstreetmap.org/{z}/{x}/{y}.png" }
        //};

        //private TileLayer layer2 = new TileLayer
        //{
        //    SourceName = "SHN",
        //    TileSource = new TileSource { }
        //};

        //private TileLayer layer3 = new TileLayer
        //{
        //    SourceName = "Local",
        //    TileSource = new TileSource { UriFormat = "http://192.168.1.100:8080/{z}/{x}/{v}.png" }
        //};

        public MainPage()
        {
            this.InitializeComponent();

            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.Blue;
            titleBar.ForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.Blue;
            titleBar.ButtonForegroundColor = Colors.White;


            //layer2.TileSource.UriFormat = "file:///C:/SHN/{z}/{x}/{v}.png";
            //layer2.TileSource.UriFormat = "ms-appx:///Assets/Maps/{z}/{x}/{v}.png";

            map.Children.Add(MapLayer3);

        }
    }
}
