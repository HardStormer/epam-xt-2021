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

            if (MenuGrid.Visibility == Visibility.Hidden)
                MenuGrid.Visibility = Visibility.Visible;
            else
                MenuGrid.Visibility = Visibility.Hidden;
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



        //TASKS
        // 1.2.1. AVERAGES
        private void Buttontask1Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(task1_input.Text) )
                task1_output.Text = ("Сначала введите значение");
            else
            {
                task1_output.Text = "";
                string text = task1_input.Text;
                string[] words = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string max = ""; int maxIndex = 0;
                string min = "spdodfiadsofipas"; int minIndex = 0;

                int maxLength = 0;
                int minLength = 0;

                int allLength = 0;

                int i = 0;
                int number = words.Length;
                foreach (string word in words)
                {
                    allLength += words[i].Length;

                    if (word.Length > max.Length)
                    {
                        max = word;
                        maxIndex = i;
                        maxLength = words[i].Length;
                    }

                    if (word.Length < min.Length)
                    {
                        min = word;
                        minIndex = i;
                        minLength = words[i].Length;
                    }

                    i++;
                }

                task1_output.Text += ("Самое коротокое слово: \"" + min +"\", позиция = " + minIndex + 1 + ", размер " + minLength + "\n----------------------\n").ToString();
                task1_output.Text += ("Самое длинное слово: \"" + max + "\", позиция = " + maxIndex + 1 + ", размер " + maxLength + "\n----------------------\n").ToString();
                task1_output.Text += ("Количество слов: " + number + "\n----------------------\n").ToString();
                task1_output.Text += ("Всего букв: " + allLength + "\n----------------------\n").ToString();
                task1_output.Text += ("Среднее количество букв в слове: " + allLength / number).ToString();
            }
        }
        //1.2.2. DOUBLER
        private void Buttontask2Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(task2_input1.Text) || string.IsNullOrEmpty(task2_input2.Text))
                task2_output.Text = ("Сначала введите значение");
            else
            {
                string output = "";
                string input1 = task2_input1.Text;
                string input2 = task2_input2.Text;
                foreach (char x in input1)
                    if (!input2.Contains(x))
                        output += x;
                    else
                    {
                        output += x;
                        output += x;
                    }
                task2_output.Text = output;
            }
        }
        //1.2.3. LOWERCASE
        private void Buttontask3Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(task3_input.Text))
                task1_output.Text = ("Сначала введите значение");
            else
            {
                string Text = task3_input.Text;
                string[] words = Text.Split(new char[] { ',', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                int sum = 0;

                foreach (var lower in words)
                {
                    if (char.IsLower(lower[0]))
                    {
                        sum++;
                    }

                }
                task3_output.Text = "Ответ: " + sum.ToString();
            }
        }
        //1.2.4. VALIDATOR *
        private void Buttontask4Calc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(task4_input.Text))
                task4_output.Text = ("Сначала введите значение");
            else
            {

                string MyText = task4_input.Text;

                StringBuilder Text = new StringBuilder(MyText);

                bool done = false;

                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text[i] == '.' || Text[i] == '?' || Text[i] == '!' || i == 0)
                    {
                        while (done == false)
                        {
                            if (i >= Text.Length)
                                done = true;
                            else if (char.IsLetter(Text[i]))
                            {
                                char NowUpper = char.ToUpper(Text[i]);
                                Text.Remove(i, 1);
                                Text.Insert(i, NowUpper);
                                done = true;
                            }
                            i++;
                        }

                    }
                    done = false;
                }

                task4_output.Text = Text.ToString();
            }

        }
   
    }
}
