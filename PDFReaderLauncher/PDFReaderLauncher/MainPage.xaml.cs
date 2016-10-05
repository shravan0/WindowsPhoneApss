using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PDFReaderLauncher.Resources;
using Windows.Storage;
using Windows.Foundation;
using System.IO.IsolatedStorage;
using System.IO;
using Microsoft.Phone.Tasks;
namespace PDFReaderLauncher
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

        }
        async void launchPDF()
        {
            string fileURL = @"Assets\file.pdf";
            try
            {
                StorageFile pdfFile = await
                             Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(fileURL);
                if (pdfFile != null)
                {
                    IAsyncOperation<bool> success =
                            Windows.System.Launcher.LaunchFileAsync(pdfFile);

                    if (await success)
                    {
                        // File launched
                    }
                    else
                    {
                        // File launch failed
                    }
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("hello")
            }
        }
        public async void launchPDFFromDownloads()
        {
            StorageFile storageFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(@"Assets\file.pdf");
            Button b = new Button();
            b.Click += b_Click;
            b.Content = "CLose";
            b.Width = "200";
            b.Height = 80;
            hello.Children.Add(b);
        
          
        }

        void b_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public async void launchPDFFromStorage()
        {
            string root = "/myfile.pdf,application/pdf,FileOpener214282312";
            var para = root.Split(',');
             para = para[0].Split( '/' );
           
           //var test = temp.Split("/");
            MessageBox.Show("hello"+ para[1]);

            using (IsolatedStorageFile file = IsolatedStorageFile.GetUserStoreForApplication())
            {
                string [] files;
                files=file.GetFileNames();
                var pdfFile = files[0];
                StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
                StorageFile pdffile = await local.GetFileAsync(para[1]);
                await Windows.System.Launcher.LaunchFileAsync(pdffile);
            }
        }
        private void resourceButton_Click(object sender, RoutedEventArgs e)
        {
            launchPDF();
        }

        private void downloadsFolder_Click(object sender, RoutedEventArgs e)
        {
            launchPDFFromDownloads();
        }

        private void storageFolder_Click(object sender, RoutedEventArgs e)
        {
            launchPDFFromStorage();
        }

        private void downloadButton_Click(object sender, RoutedEventArgs e)
        {

            DownloadFileVerySimle(new Uri(@"https://dev.mobileservices.fmglobal.com/Proxy/GET?svc=RideSharePDF&uuid=testing123&safe=on", UriKind.Absolute), "myfile.pdf");
                   
        }
        public void DownloadFileVerySimle(Uri fileAdress,string fileName){
            try
            {
                var url = "https://dev.mobileservices.fmglobal.com/Proxy/GET?svc=RideSharePDF&uuid=testing123&safe=on";
                WebClient client = new WebClient();
                Console.Write("hello");
                client.DownloadStringCompleted += (s, ev) =>
                {
                    MessageBox.Show(messageBoxText: "download COmplteted.",
                      caption: "Your custom caption.",
                      button: MessageBoxButton.OK);
                    using (IsolatedStorageFile ISF = IsolatedStorageFile.GetUserStoreForApplication())
                    using (StreamWriter writeToFile = new StreamWriter(ISF.CreateFile(fileName)))
                        writeToFile.Write(ev.Result);
                };
                client.DownloadStringAsync(fileAdress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void emailComposer_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            List<string> l = new List<string>();
            l.Add("email1@email1.com");
            l.Add("email2@email1.com");
            l.Add("email3@email1.com");
            l.Add("email4@email1.com");
            l.Add("email5@email1.com");
            l.Add("email6@email1.com");
            l.Add("email7@email1.com");

            emailComposeTask.Subject = "message subject";
            emailComposeTask.Body = "message body";
            emailComposeTask.To = "recipient@example.com,recipient2@example.com";
            emailComposeTask.Cc = "cc@example.com";
            emailComposeTask.Bcc = "bcc@example.com";

            emailComposeTask.Show();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
    
}