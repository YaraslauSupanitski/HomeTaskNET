using System;
using System.Windows;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BSelectFolder_Click(object sender, RoutedEventArgs e)
        {
            this.LBmethods.Items.Clear();
            this.LBclasses.Items.Clear();
            this.LBdll.Items.Clear();


            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string folderPath = fbd.SelectedPath;
                this.TBXFolderName.Text = folderPath;

                var dllFiles = Directory.GetFiles(folderPath, "*.dll");

                foreach (var strDll in dllFiles) {
                    this.LBdll.Items.Add(strDll);
                }
            }
        }

        private void LBdll_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.LBmethods.Items.Clear();
            this.LBclasses.Items.Clear();

            if (this.LBdll.SelectedItem != null)
            {
                var dllProject = Assembly.LoadFile(this.LBdll.SelectedItem.ToString());

                foreach (var type in dllProject.GetTypes())
                {
                    this.LBclasses.Items.Add(type);
                }
            }
        }

        private void LBclasses_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.LBmethods.Items.Clear();

            if (this.LBclasses.SelectedItem != null) {

                var type = (Type)this.LBclasses.SelectedItem;

                if(this.CBAll.IsChecked == true)
                {
                    this.CBMethods.IsChecked = true;
                    this.CBProperty.IsChecked = true;
                    this.CBFields.IsChecked = true;
                }

                if (this.CBMethods.IsChecked == true)
                {

                    var mthds = type.GetMethods();
                    foreach (var mthd in mthds)
                    {
                        this.LBmethods.Items.Add(mthd.ToString());
                    }
                }

                if (this.CBFields.IsChecked == true)
                {
                    var props = type.GetProperties();
                    foreach (var prop in props)
                    {
                        this.LBmethods.Items.Add(prop.Name);
                    }
                }

                if (this.CBFields.IsChecked == true)
                {
                    var fields = type.GetFields();
                    foreach (var field in fields)
                    {
                        this.LBmethods.Items.Add(field.Name);
                    }
                }
            }
        }
    }
}
