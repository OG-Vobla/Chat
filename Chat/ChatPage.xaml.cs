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

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для ChatPage.xaml
    /// </summary>
    public partial class ChatPage : Page
    {
        bool leverPosition;
        public ChatPage()
        {
            
            InitializeComponent();
            leverPosition = true;
            ChangePosition();
        }
        public void ChangePosition()
        {
            if (leverPosition)
            {
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource =
                    new BitmapImage(new Uri("/red.jpg"));
                LeverImg = myBrush;
            }
        }
    }
}
