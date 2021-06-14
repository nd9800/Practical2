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
using Practical2.Models;
using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practical2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Info c = new Info();
        public MainPage()
        {
            this.InitializeComponent();
        }
        public void exec()
        {
            
            InfoItem u1 = new InfoItem("namdoan","123456");
           c.AddInfo(u1);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            string a = Username.Text;
            string b = Passw.Text;
            for(int i =0; i< c.GetInfo().Count;i++)
            {
                if(!a.Equals(c.GetInfo()[i].name))
                {
                    var dialog = new MessageDialog("Wrong Username");
                    await dialog.ShowAsync();
                    break;
                }
                else
                {
                    if(b.Equals(c.GetInfo()[i].passw))
                    {
                        var dialog = new MessageDialog("Login successfully");
                        await dialog.ShowAsync();
                        break;
                    }
                    else
                    {
                        var dialog = new MessageDialog("Wrong Password");
                        await dialog.ShowAsync();
                        break;
                    }

                }
            }
        }
    }
}
