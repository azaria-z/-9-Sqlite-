using SchoolBLL;
using SchoolDAL.Models;
using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public List<Teacher> Teachers { get; set; }

        public TeachersWindow()
        {
            InitializeComponent(); // חשוב! תמיד צריך להיות לפני השימוש ברכיבי XAML

            TeacherBL teacherBL = new TeacherBL();
            Teachers = teacherBL.getTeacher();

            DataContext = this; // הגדרת ה־DataContext אחרי שמילאת את הנתונים
        }
    }
}
