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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebViewUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            myWebView.Navigate(new Uri("http://www.webtoolkitonline.com/javascript-tester.html"));

            // If I enter i = 1 / 0 and press "execute" a javascript error will occur. 
            // The link (http://www.webtoolkitonline.com/javascript-tester.html) in Edge will display an alert.

            // Question 1:
            // Are all javascript error alerts supressed? I have found pages on internet that says it so for windows 8 but not for windows 10.
            // Can you provide me with a link on internet that confirms this? It has to be UWP on windows 10.

            // Question 2:
            // I will not get an alert in my UWP app but will get an alert in Edge.
            // Can I capture this alert in my code so I can log it?
            // Please add code here on how to do it, or direct me to a working example on windows 10.
        }
    }
}
