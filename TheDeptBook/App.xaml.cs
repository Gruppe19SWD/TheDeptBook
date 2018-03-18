using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TheDeptBook.Model;
using TheDeptBook.ViewModel;

namespace TheDeptBook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Window win = new MainWindow();
            Window win2 = new DetailsWindow();
            DeptModel DM = new DeptModel();
            DeptViewModel dmw = new DeptViewModel(DM);
            win.DataContext = dmw;
            win2.DataContext = dmw;

            win.Show();
            win2.Show();
        }

    }
}
