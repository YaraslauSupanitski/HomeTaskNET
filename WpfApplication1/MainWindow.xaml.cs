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
        public delegate void Clearer();

        private Clearer clearer = null;
        private List<System.Windows.Controls.CheckBox> CheckBoxs = new List<System.Windows.Controls.CheckBox>();

        public MainWindow()
        {
            InitializeComponent();

            CheckBoxs.Add(CBFields);
            CheckBoxs.Add(CBMethods);
            CheckBoxs.Add(CBProperty);
        }

        private void BSelectFolder_Click(object sender, RoutedEventArgs e)
        {
            DelegateWorker(LBmethods, LBclasses, LBdll);
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TBXFolderName.Text = fbd.SelectedPath;
                var dllFiles = Directory.GetFiles(fbd.SelectedPath, "*.dll");
                foreach (var strDll in dllFiles)
                {
                    this.LBdll.Items.Add(strDll);
                }
            }
        }

        private void LBdll_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DelegateWorker(LBmethods, LBclasses);
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
            DelegateWorker(LBmethods);
            if (this.LBclasses.SelectedItem != null)
            {
                var type = (Type)this.LBclasses.SelectedItem;
                FillLBmethods(type);
            }
        }
        
        private void FillLBmethods(Type type)
        {
            if (this.CBAll.IsChecked == true)
            {
                this.CBMethods.IsChecked = true;
                this.CBProperty.IsChecked = true;
                this.CBFields.IsChecked = true;
            }
            List<MemberInfo> listInfo = new List<MemberInfo>();
            var enableChechBoxs = CheckBoxs.Where(cb => cb.IsChecked == true).Select(cb=>cb).ToList();
            foreach (var cb in enableChechBoxs)
            {
                if (cb == CBFields) { listInfo.AddRange(type.GetFields()); }
                if (cb == CBMethods) { listInfo.AddRange(type.GetMethods()); }
                if (cb == CBProperty) { listInfo.AddRange(type.GetProperties()); }
            }
            foreach (var item in listInfo)
            {
                this.LBmethods.Items.Add(item.Name);
            }
            
        }

        private void DelegateWorker(params  System.Windows.Controls.ListBox[] listBox)
        {
            clearer = null;
            listBox.ToList().ForEach(LB => clearer += LB.Items.Clear);
            clearer.Invoke();
        }
    }
}
