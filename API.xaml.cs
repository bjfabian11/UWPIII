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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class API : Page
    {
        public API()
        {
            this.InitializeComponent();

            txtBoxRas.Text = "AWS API";
            txtBoxRas.FontSize = 14;
            BL_PageContent.CreatedBy = "Created By: Brandon Fabian";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }

        private void HyperlinkButton_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Todoitem));
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(API));
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public static string AWS_Name { get; set; }

        public void GetAWS()
        {
            var Var2 = new Amazon.Auth.AccessControlPolicy.Policy();
            AWS_Name = Convert.ToString(Var2.Version);
            GetAPI.Text = "API: " + AWS_Name;
        }

        private void btnGetAPI_Click(object sender, RoutedEventArgs e)
        {
            GetAWS();
        }
    }
}
