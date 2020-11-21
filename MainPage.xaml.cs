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
using Project_Roulette.DataSets;
using Project_Roulette.Utilities;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project_Roulette
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Core.Initialize();
            Core.Roll();
            Yeet();

            if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "Play"))
            {
                Pokemon0.Play();
            }
        }

        void playButton_Click(object sender, RoutedEventArgs e)
        {
            if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsPlaying"))
            {
                refreshButton.Icon = new SymbolIcon(Symbol.Play);
                Core.Roll();
                Yeet();
            }
        }

        void Yeet()
        {
            Pokemon0.UriSource = new Uri(Core.roulette[0].sprite);
            Pokemon1.UriSource = new Uri(Core.roulette[1].sprite);
            Pokemon2.UriSource = new Uri(Core.roulette[2].sprite);
            Pokemon3.UriSource = new Uri(Core.roulette[3].sprite);
            Pokemon4.UriSource = new Uri(Core.roulette[4].sprite);
            Pokemon5.UriSource = new Uri(Core.roulette[5].sprite);
        }
    }
}
