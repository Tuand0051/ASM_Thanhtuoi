using Food.Model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Food
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewsItems> listItem; 

        public MainPage()
        {
            this.InitializeComponent();
            listItem = new ObservableCollection<NewsItems>();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Financial.IsSelected)
            {
                NewsManager.GetNews("Financial", listItem);
                TitleTextBlock.Text = "Finacial";
            }          
            else if (Food.IsSelected)
            {
                NewsManager.GetNews("Food", listItem);
                TitleTextBlock.Text = "Food";
            }   
        } 

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Financial.IsSelected = true;
        }
    }
}