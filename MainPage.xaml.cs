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
using Windows.UI.Popups;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            txtBoxRas.Text = "My Inventory";
            txtBoxRas.FontSize = 14;
            BL_PageContent.CreatedBy = "Created By: Brandon Fabian";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;          
        }

        private void HyperlinkButton_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Todoitem));
        }

        private void HyperlinkButton_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(API));
        }

        private void GeoLoc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GeoLocation));
        }

        private void HlkGoogleAuth_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GoogleAuth));
        }
    }
}
