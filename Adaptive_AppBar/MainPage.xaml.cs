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

namespace Adaptive_AppBar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            AppBar_DisplayOption.IsOn = true;
            AppBar_StickOption.IsOn = false;
        }

        private void Stick_Toggled(object sender, RoutedEventArgs e)
        {
            if (AppBar_StickOption.IsOn == true)
            {
                Phone_AppBar.IsSticky = true;
                PC_AppBar.IsSticky = true;
            }
            else if (AppBar_StickOption.IsOn == false)
            {
                Phone_AppBar.IsSticky = false;
                PC_AppBar.IsSticky = false;
            }
        }

        private void Display_Toggled(object sender, RoutedEventArgs e)
        {
            if (AppBar_DisplayOption.IsOn == true)
            {
                Phone_AppBar.ClosedDisplayMode = AppBarClosedDisplayMode.Compact;
            }
            else if (AppBar_DisplayOption.IsOn == false)
            {
                Phone_AppBar.ClosedDisplayMode = AppBarClosedDisplayMode.Minimal;
            }
        }
    }
}
