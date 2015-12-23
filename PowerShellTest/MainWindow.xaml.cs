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
using System.Management.Automation;
using System.Collections.ObjectModel;
using Devolutions.RemoteDesktopManager.Business.PS;

namespace PowerShellTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                //PowerShellInstance.AddCommand("Add-PSSnapin");
                //PowerShellInstance.AddParameter("Name", "Remote.Desktop.Manager.*");
                //PowerShellInstance.AddCommand("Get-PSSnapin");
                //PowerShellInstance.AddParameter("Registered");
                //PowerShellInstance.AddCommand("Get-RDMSession");
                //PowerShellInstance.AddCommand("Get-RDMCurrentDataSource");
                PowerShellInstance.AddScript("")
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                string a = "test";
            }
        }
    }
}
