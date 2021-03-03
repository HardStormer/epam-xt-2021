using System;
using System.IO;
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

namespace EPAM_XT_1
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

        //BUTTONS CONTROL
        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MenuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MenuGrid.Visibility == Visibility.Hidden)
                MenuGrid.Visibility = Visibility.Visible;
            else
                MenuGrid.Visibility = Visibility.Hidden;
        }

        //MOVING WINDOW
        private void toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        //TEXTBLOCK CONTROL
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
            {
                e.Handled = true; // отклоняем ввод
            }
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true; // если пробел, отклоняем ввод
            }
        }

        //BUTTONS
        private void CloseTasks()
        {
            if (Task1Grid.Visibility == Visibility.Visible)
                Task1Grid.Visibility = Visibility.Hidden;

            if (Task2Grid.Visibility == Visibility.Visible)
                Task2Grid.Visibility = Visibility.Hidden;

            if (Task3Grid.Visibility == Visibility.Visible)
                Task3Grid.Visibility = Visibility.Hidden;

            if (Task4Grid.Visibility == Visibility.Visible)
                Task4Grid.Visibility = Visibility.Hidden;

            if (Task5Grid.Visibility == Visibility.Visible)
                Task5Grid.Visibility = Visibility.Hidden;

            if (Task6Grid.Visibility == Visibility.Visible)
                Task6Grid.Visibility = Visibility.Hidden;

            if (Task7Grid.Visibility == Visibility.Visible)
                Task7Grid.Visibility = Visibility.Hidden;

            if (Task8Grid.Visibility == Visibility.Visible)
                Task8Grid.Visibility = Visibility.Hidden;

            if (Task9Grid.Visibility == Visibility.Visible)
                Task9Grid.Visibility = Visibility.Hidden;

            if (Task10Grid.Visibility == Visibility.Visible)
                Task10Grid.Visibility = Visibility.Hidden;

            if (MenuGrid.Visibility == Visibility.Hidden)
                MenuGrid.Visibility = Visibility.Visible;
            else
                MenuGrid.Visibility = Visibility.Hidden;
        }
        private void Button_1task_Click(object sender, RoutedEventArgs e)
        {

            string consolePath = "C:/Users/betme/source/repos/EPAM-XT-1/EPAM-XT-1/Console.txt";
            string text = "тест консоли";
            try
            {
                using (StreamWriter sw = new StreamWriter(consolePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);//запись в "консоль"
                }
                System.Diagnostics.Process.Start(consolePath);//открываю "консоль"
            }
            catch (Exception)
            {

            }

        }

        private void Buttontask1_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 1";

            CloseTasks();

            if (Task1Grid.Visibility == Visibility.Hidden)
                Task1Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask2_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 2";

            CloseTasks();

            if (Task2Grid.Visibility == Visibility.Hidden)
                Task2Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask3_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 3";

            CloseTasks();

            if (Task3Grid.Visibility == Visibility.Hidden)
                Task3Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask4_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 4";

            CloseTasks();

            if (Task4Grid.Visibility == Visibility.Hidden)
                Task4Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask5_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 5";

            CloseTasks();

            if (Task5Grid.Visibility == Visibility.Hidden)
                Task5Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask6_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 6";

            CloseTasks();

            if (Task6Grid.Visibility == Visibility.Hidden)
                Task6Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask7_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 7";

            CloseTasks();

            if (Task7Grid.Visibility == Visibility.Hidden)
                Task7Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask8_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 8";

            CloseTasks();

            if (Task8Grid.Visibility == Visibility.Hidden)
                Task8Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask9_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 9";

            CloseTasks();

            if (Task9Grid.Visibility == Visibility.Hidden)
                Task9Grid.Visibility = Visibility.Visible;
        }

        private void Buttontask10_Click(object sender, RoutedEventArgs e)
        {
            ToolBarLabel.Content = "Задание 10";

            CloseTasks();

            if (Task10Grid.Visibility == Visibility.Hidden)
                Task10Grid.Visibility = Visibility.Visible;
        }

        //TASKS
        // 1.1.1 RECTANGLE
        private void Buttontask1Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_1task_textbox.Text) || string.IsNullOrEmpty(_2task_textbox.Text))
                _3task_textbox.Text = ("Сначала введите значение");
            else
            {
                int a = Convert.ToInt32(_1task_textbox.Text);
                int b = Convert.ToInt32(_2task_textbox.Text);
                if (a <= 0 || b <= 0)
                    _3task_textbox.Text = ("Во введенных значениях присутсвуют неположительные");
                else
                _3task_textbox.Text = ("Если одна из сторон ").ToString() + a.ToString() + ", а другая ".ToString() + b.ToString() + ", то площадь равняется ".ToString() + (a * b).ToString();
            }
        }
        //1.1.2. TRIANGLE
        private void Buttontask2Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_1_2task_textbox.Text))
                _2_2task_textbox.Text = ("Сначала введите значение");
            else
            {
                int x = Convert.ToInt32(_1_2task_textbox.Text);

                _2_2task_textbox.Text = ("");
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        _2_2task_textbox.Text += ("*");
                    }
                    _2_2task_textbox.Text += ("\n");
                }
            }
        }
        //1.1.3. ANOTHER TRIANGLE
        private void Buttontask3Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_1_3task_textbox.Text))
                _2_3task_textbox.Text = ("Сначала введите значение");
            else
            {
                int x = Convert.ToInt32(_1_3task_textbox.Text);

                _2_3task_textbox.Text = ("");
                for (int i = 0; i < x; i++)
                {
                    for (int prob = x - 1; prob > i; prob--)
                    {
                        _2_3task_textbox.Text += (" ");
                    }
                    for (int j = 1; j <= i * 2 + 1; j++)
                    {
                        _2_3task_textbox.Text += ("*");
                    }
                    _2_3task_textbox.Text += ("\n");
                }
            }
        }
        //1.1.4. X-MAS TREE
        private void Buttontask4Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_1_4task_textbox.Text))
                _2_4task_textbox.Text = ("Сначала введите значение");
            else
            {
                int x = Convert.ToInt32(_1_4task_textbox.Text);

                _2_4task_textbox.Text = ("");

               
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        for (int a = x - 1; a > j; a--)
                        {
                            _2_4task_textbox.Text += (" ");
                        }
                        for (int b = 1; b <= j * 2 + 1; b++)
                        {
                            _2_4task_textbox.Text += ("*");
                        }
                        _2_4task_textbox.Text += ("\n");
                    }
                }
            }

        }
        //1.1.5. SUM OF NUMBERS
        private void Buttontask5Calc_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0) { sum += i; }
            _1_5task_textbox.Text = (sum).ToString();
        }
        //1.1.6. FONT ADJUSTMENT
        private void Buttontask6_3Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_6task_textbox.Text = ("");
            Task6(1);
        }
        private void Buttontask6_2Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_6task_textbox.Text = ("");

            Task6(2);
        }
        private void Buttontask6_1Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_6task_textbox.Text = ("");

            Task6(3);
        }

        private List<string> Font = new List<string>();
        private void Task6(int n)
        {
                switch (n)
                {
                    case 1:
                        if (!Font.Contains("Bold"))
                            Font.Add("Bold");
                        else
                            Font.Remove("Bold");
                        break;

                    case 2:
                        if (!Font.Contains("Italic"))
                            Font.Add("Italic");
                        else
                            Font.Remove("Italic");
                        break;

                    case 3:
                        if (!Font.Contains("Underline"))
                            Font.Add("Underline");
                        else
                            Font.Remove("Underline");
                        break;
                }
            _1_6task_textbox.Text += ("Параметры надписи:" + string.Join(", ", Font));

        }
        //1.1.7. ARRAY PROCESSING
        private void Buttontask7Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_7task_textbox.Text = ("");

            ArrayInin.Onedim(out double[] arr);

            _1_7task_textbox.Text += ("Выводим случайный массив:\n\n");

            foreach (double x in arr)
                _1_7task_textbox.Text += (x + " ").ToString();

            MinMax.search(arr, arr.Length, out double min, out double max);

            _1_7task_textbox.Text += ("\n\nМинимальное значение: " + min.ToString() + "\n\nМаксимальное значение: " + max.ToString());
            
            QuickSorting.sorting(arr, 0, arr.Length - 1);

            _1_7task_textbox.Text += ("\n\nПосле быстрой сортировки массив приобрел вид:\n\n");

            foreach (double x in arr)
                _1_7task_textbox.Text += (x + " ").ToString();
        }
        //1.1.8. NO POSITIVE
        private void Buttontask8Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_8task_textbox.Text = ("Ошибка, устройство визуализации 3д массивов не найдено, запуск процесса визуализации построчно...\n( ╯°□°)╯┻┻\n\nБыло:\n");

            ArrayInin.Threedim(out double[,,] arr);

            foreach (double x in arr)
                _1_8task_textbox.Text += (x + " ").ToString();

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;

            _1_8task_textbox.Text += ("\n\nСтало:\n");

            foreach (double x in arr)
                _1_8task_textbox.Text += (x + " ").ToString();
        }
        //1.1.9. NON-NEGATIVE SUM
        private void Buttontask9Calc_Click(object sender, RoutedEventArgs e)
        {
            _1_9task_textbox.Text = ("");

            double sum = 0;
            ArrayInin.Onedim(out double[] arr);

            _1_9task_textbox.Text += ("Выводим случайный массив:\n\n");

            foreach (double x in arr)
                _1_9task_textbox.Text += (x + " ").ToString();

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] >= 0)
                    sum += arr[i];


            _1_9task_textbox.Text += ("\n\nСумма искомых:\n\n" + sum.ToString());
        }
        //1.1.10. 2D ARRAY
        private void Buttontask10Calc_Click(object sender, RoutedEventArgs e)
        {

            _1_10task_textbox.Text = ("");

            double sum = 0;
            ArrayInin.Twodim(out double[,] arr);

            _1_10task_textbox.Text += ("Выводим случайный массив:\n\n");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    _1_10task_textbox.Text += arr[i, j] + "   ";

            _1_10task_textbox.Text += "\r\n";
            }


            for (int i = 0; i < arr.GetLength(0); i += 2)
                for (int j = 0; j < arr.GetLength(1); j += 2)
                    sum += arr[i, j];

            _1_10task_textbox.Text += ("\nСумма искомых: \n\n" + sum.ToString());

        }

    }
    
    

    class ArrayInin
    {
        public static void Onedim(out double[] arr)
        {
            arr = new double[10];
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = rd.Next(-10, 10);
        }
        public static void Twodim(out double[,] arr)
        {
            arr = new double[5, 5];
            Random rd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rd.Next(0, 10);
        }
        public static void Threedim(out double[,,] arr)
        {
            arr = new double[3, 3, 3];
            Random rd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    for (int k = 0; k < arr.GetLength(2); k++)
                        arr[i, j, k] = rd.Next(-11, 11);
        }
    }

    class MinMax
    {
        public static void search(double[] arr, long length, out double min, out double max)
        {
            min = arr[0];
            max = min;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max) 
                    max = arr[i];
                if (arr[i] < min) 
                    min = arr[i];
            }

        }
    }

    class QuickSorting
    {
        public static void sorting(double[] arr, long first, long last)
        {
            double p = arr[(last - first) / 2 + first];
            double temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
        }
    }
}
