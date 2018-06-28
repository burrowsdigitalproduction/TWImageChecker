using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;

namespace TWImageChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            tbSaveLocation.Text = desktoppath;
            tbAssetsLocation.Text = AssetPath;
            GetCodes fullAssetCodes = new GetCodes();
            fullAssetCodes.getAllCodes();
        }
        FindAssets fAssets = new FindAssets();

        string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string AssetPath = @"\\bcluster\burrows\digital\autorender\taylorwimpey\Production\Bathroom\Assets\V2\#Final";
        string SavePath;

        private void btnSaveTo_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

            DialogResult result = folderDlg.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)

            {

                tbSaveLocation.Text = folderDlg.SelectedPath;
                SavePath = folderDlg.SelectedPath;

                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnAssetLocation_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();

            folderDlg.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

            DialogResult result = folderDlg.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)

            {

                tbAssetsLocation.Text = folderDlg.SelectedPath;
                AssetPath = folderDlg.SelectedPath;

                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void btnCreateErrorList_Click(object sender, RoutedEventArgs e)
        {
            SavePath = tbSaveLocation.Text;


            if(rbAllAssets.IsChecked == true)
            {
                fAssets.searchAllFiles(AssetPath);
            }
            if (rbTilePackageandBasinTapAssets.IsChecked == true)
            {
                fAssets.searchMainFiles(AssetPath);
            }
            if (rbFlooringAssets.IsChecked == true)
            {
                fAssets.searchFlooringFiles(AssetPath);
            }
            if (rbBathandBathTapAssets.IsChecked == true)
            {
                fAssets.searchBathFiles(AssetPath);
            }
            fAssets.createMissingAssetsTextFile(SavePath);
            
        }

        
    }
}
