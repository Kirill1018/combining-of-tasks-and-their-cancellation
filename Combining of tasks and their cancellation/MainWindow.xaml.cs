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
using System.Xaml;
using System.Threading;
namespace Combining_of_tasks_and_their_cancellation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static object bar = (ProgressBar)bar;
        public static Task task1 = new Task(new MainWindow().Completion), task2 = new Task(new MainWindow().Completion), task3 = new Task(new MainWindow().Completion), task4 = new Task(new MainWindow().Completion), task5 = new Task(Message1.Message3);
        public MainWindow()
        {
            InitializeComponent();
            Bar_completion();
        }
        public void Bar_completion()
        {
            bar = bar1;
            task1.Start();
            bar = bar2;
            task2.Start();
            bar = bar3;
            task3.Start();
            bar = bar4;
            task4.Start();
            Task.WhenAll().Wait();
            task5.Start();
        }
        public void Completion()
        {
            if (bar == bar1) for (double i = 0.00; i < 100.00; i++) bar1.Value += i;
            else if (bar == bar2) for (double i = 0.00; i < 100.00; i++) bar2.Value += i;
            else if (bar == bar3) for (double i = 0.00; i < 100.00; i++) bar3.Value += i;
            else for (double i = 0.00; i < 100.00; i++) bar4.Value += i;
        }

        private void button_Click(object sender, RoutedEventArgs e) { new CancellationTokenSource().Cancel(); }
    }
}