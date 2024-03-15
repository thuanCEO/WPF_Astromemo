using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Astromemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawStars();
            DrawPlanets();
            DrawMoon();
        }
        private void DrawStars()
        {
            Random random = new Random();
            SolidColorBrush starColor = Brushes.White;

            for (int i = 0; i < 100; i++)
            {
                Ellipse star = new Ellipse();
                star.Fill = starColor;
                star.Width = 2;
                star.Height = 2;
                Canvas.SetLeft(star, random.Next((int)canvas.ActualWidth));
                Canvas.SetTop(star, random.Next((int)canvas.ActualHeight));
                canvas.Children.Add(star);
            }
        }

        private void DrawPlanets()
        {
            Ellipse planet = new Ellipse();
            planet.Fill = Brushes.Red; // Màu sắc của hành tinh, có thể tùy chỉnh
            planet.Width = 20; // Đường kính của hành tinh, có thể tùy chỉnh
            planet.Height = 20; // Chiều cao của hành tinh, có thể tùy chỉnh
            Canvas.SetLeft(planet, 200); // Vị trí ngang của hành tinh trên Canvas
            Canvas.SetTop(planet, 100); // Vị trí dọc của hành tinh trên Canvas
            canvas.Children.Add(planet);
        }

        private void DrawMoon()
        {
            Ellipse moon = new Ellipse();
            moon.Fill = Brushes.Gray; // Màu sắc của mặt trăng, có thể tùy chỉnh
            moon.Width = 15; // Đường kính của mặt trăng, có thể tùy chỉnh
            moon.Height = 15; // Chiều cao của mặt trăng, có thể tùy chỉnh
            Canvas.SetLeft(moon, 400); // Vị trí ngang của mặt trăng trên Canvas
            Canvas.SetTop(moon, 150); // Vị trí dọc của mặt trăng trên Canvas
            canvas.Children.Add(moon);
        }
    }
}