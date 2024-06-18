using System.Diagnostics;
using System.IO;
using System.Windows;

namespace TingenCommander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GetModeStatuses();
            LabelDiskFreeSpaceValue.Content= GetFreeSpace();

            long exportSize = GetDirectorySizeFast(@"T:\UAT\Exports");
            long alertSize = GetDirectorySizeFast(@"T:\UAT\Messages\Alerts");
            long errorSize = GetDirectorySizeFast(@"T:\UAT\Messages\Errors");
            long warningSize = GetDirectorySizeFast(@"T:\UAT\Messages\Warnings");

            ButtonViewExportedData.Content = $"View exported data ({exportSize / (1024 * 1024)} MB)";
            ButtonViewAlertMessages.Content = $"View alert messages ({alertSize / (1024 * 1024)} MB)";
            ButtonViewErrorMessages.Content = $"View error messages data ({errorSize / (1024 * 1024)} MB)";
            ButtonViewWarningMessages.Content = $"View warning messages data ({warningSize / (1024 * 1024)} MB)";
        }

        private void ButtonRefreshModeStatuses_Click(object sender, RoutedEventArgs e)
        {
            GetModeStatuses();
        }


        private string GetFreeSpace()
        {
            DriveInfo driveInfo = new DriveInfo(@"T:\");
            long freeSpace = driveInfo.AvailableFreeSpace;

            return $"{freeSpace / (1024 * 1024 * 1024)} GB";
        }

        public static long GetDirectorySizeFast(string directoryPath)
        {
            long size = 0;
            FileSystemInfo[] fileSystemInfos = new DirectoryInfo(directoryPath).GetFileSystemInfos();

            foreach (FileSystemInfo fileSystemInfo in fileSystemInfos)
            {
                if (fileSystemInfo is FileInfo)
                {
                    size += (fileSystemInfo as FileInfo).Length;
                }
                else
                {
                    size += GetDirectorySizeFast((fileSystemInfo as DirectoryInfo).FullName);
                }
            }

            return size;
        }


        private void GetTingenMode()
        {
            if (File.Exists(@"T:\Remote\Tingen LIVE Mode - Enabled"))
            {
                TabItemTingen.Foreground = System.Windows.Media.Brushes.Green;
                TabItemTingen.FontWeight = FontWeights.Bold;
                ButtonTingenMode.Content = "Enabled";
                ButtonTingenMode.Background = System.Windows.Media.Brushes.LightGreen;
                ButtonTingenMode.Foreground = System.Windows.Media.Brushes.Black;
                ButtonTingenMode.BorderBrush = System.Windows.Media.Brushes.Green;

            }
            else if (File.Exists(@"T:\Remote\Tingen LIVE Mode - Disabled"))
            {
                TabItemTingen.Foreground = System.Windows.Media.Brushes.DarkGray;
            }
            else
            {
                TabItemTingen.Foreground = System.Windows.Media.Brushes.Red;
                TabItemTingen.FontWeight = FontWeights.Bold;
                ButtonTingenMode.Content = "Unknown";
                ButtonTingenMode.Background = System.Windows.Media.Brushes.IndianRed;
                ButtonTingenMode.Foreground = System.Windows.Media.Brushes.White;
                ButtonTingenMode.BorderBrush = System.Windows.Media.Brushes.DarkRed;
            }


        }

        public void GetModeStatuses()
        {
            GetTingenMode();
        }

        private void ButtonDeleteAllTraceLogs_Click(object sender, RoutedEventArgs e)
        {
            string[] files = Directory.GetFiles(@"T:\UAT\Sessions\", "*.trace", SearchOption.AllDirectories).ToArray();


            foreach (string file in files)
            {
                File.Delete(file);
            }

            MessageBox.Show("All trace logs have been deleted.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonViewExportedData_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"T:\UAT\Exports");

        }

        private void ButtonViewAlertMessages_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"T:\UAT\Messages\Alerts");
        }

        private void ButtonViewErrorMessages_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"T:\UAT\Messages\Errors");
        }

        private void ButtonViewWarningMessages_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", @"T:\UAT\Messages\Warnings");
        }
    }
}