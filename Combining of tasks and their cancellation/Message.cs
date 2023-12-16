using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Combining_of_tasks_and_their_cancellation
{
    internal class Message1
    {
        public static string Message2 { get; } = "копирование завершено";
        public static void Message3() { MessageBox.Show($"{Message2}"); }
    }
}