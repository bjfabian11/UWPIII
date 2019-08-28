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
using Windows.Security.Authentication.Web;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GoogleAuth : Page
    {
        public GoogleAuth()
        {
            this.InitializeComponent();
            GetGoogleAuth();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public async void GetGoogleAuth()
        { 
            //using Windows.Security.Authentication.Web;
            var googleUrl = new System.Text.StringBuilder();
            googleUrl.Append("https://accounts.google.com/o/oauth2/auth?client_id=");
            googleUrl.Append(Uri.EscapeDataString("960919841378-usr76hbavemtf6ired4c6j40nre7ag3d.apps.googleusercontent.com"));
            googleUrl.Append("&scope=openid%20email%20profile");
            googleUrl.Append("&redirect_uri=");
            googleUrl.Append(Uri.EscapeDataString("urn:ietf:wg:oauth:2.0:oob:auto"));
            googleUrl.Append("&response_type=code");
            googleUrl.Append("&include_granted_scopes=true");

            string endURL = "https://accounts.google.com/o/oauth2/approval";

            Uri startURI = new Uri(googleUrl.ToString());
            Uri endURI = new Uri(endURL);
            string result = string.Empty;
            try
            {
                WebAuthenticationResult webAuthenticationResult = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, startURI, endURI);
                switch (webAuthenticationResult.ResponseStatus)
                {
                    //Successful authentication
                    case Windows.Security.Authentication.Web.WebAuthenticationStatus.Success:
                        wbVewPostAuthentication.Navigate(new Uri("https://msdn.microsoft.com/en-us/dn308572"));
                        break;
                    //HTTP error.
                    case Windows.Security.Authentication.Web.WebAuthenticationStatus.ErrorHttp:
                        result = webAuthenticationResult.ResponseErrorDetail.ToString();
                        break;
                    default:
                        result = webAuthenticationResult.ResponseData.ToString();
                        break;
                }
                if (!string.IsNullOrWhiteSpace(result)) wbVewPostAuthentication.NavigateToString(result);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
        }
    }
}
