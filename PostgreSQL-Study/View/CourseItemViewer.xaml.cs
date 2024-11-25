using System;
using System.Collections.Generic;
using System.IO;
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

namespace PostgreSQL_Study.View
{
    /// <summary>
    /// Логика взаимодействия для CourseItemViewer.xaml
    /// </summary>
    public partial class CourseItemViewer : Page
    {
        public CourseItemViewer(string file_path)
        {
            InitializeComponent();

            try
            {
                if (File.Exists(file_path))
                    CourseView.NavigateToString(File.ReadAllText(file_path, Encoding.UTF8).Replace("{% BASEDIR %}", Path.GetDirectoryName(file_path)));
            }
            catch { }
        }
    }
}
