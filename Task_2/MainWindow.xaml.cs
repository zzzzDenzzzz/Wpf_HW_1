using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Task_2
{
    enum Numbers
    {
        ZERO,
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // текущий результат
        double result;
        // записывает выражения
        Stack<string> expressions;
        // записывает результаты выражений
        Stack<double> results;

        public MainWindow()
        {
            InitializeComponent();
            result = 0;
            expressions = new Stack<string>();
            results = new Stack<double>();
        }

        /// <summary>
        /// очищает текущее число
        /// включает кнопку dot
        /// </summary>
        private void ClearCurrentNumber(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text = string.Empty;
            button_dot.IsHitTestVisible = true;
        }

        /// <summary>
        /// очищает текущее число и предыдущее выражение
        /// </summary>
        private void ClearCurrentNumberAndPreviousExpression(object sender, RoutedEventArgs e)
        {
            ClearCurrentNumber(sender, e);
            if (expressions.Count != 0)
            {
                textBox_previousOperation.Text = expressions.Pop();
                result = results.Pop();
            }
            else
            {
                textBox_previousOperation.Text = "0";
                result = 0;
            }
        }

        /// <summary>
        /// очищает последний введенный символ в текущем числе.
        /// если последний удаленный символ точка, включает кнопку dot.
        /// если в textBox остался 0, удаляет его
        /// </summary>
        private void ClearLastCharacter(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text = textBox_inputNumber.Text.Remove(textBox_inputNumber.Text.Length - 1);
            if (textBox_inputNumber.Text.EndsWith(","))
            {
                button_dot.IsHitTestVisible = true;
            }
            if (textBox_inputNumber.Text.EndsWith("0"))
            {
                textBox_inputNumber.Text = textBox_inputNumber.Text.Remove(textBox_inputNumber.Text.Length - 1);
                button_dot.IsHitTestVisible = true;
            }
        }

        /// <summary>
        /// добавляет цифру 0
        /// </summary>
        private void InputZero(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.ZERO).ToString();
        }

        /// <summary>
        /// добавляет цифру 1
        /// </summary>
        private void InputOne(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.ONE).ToString();
        }

        /// <summary>
        /// добавляет цифру 2
        /// </summary>
        private void InputTwo(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.TWO).ToString();
        }

        /// <summary>
        /// добавляет цифру 3
        /// </summary>
        private void InputThtree(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.THREE).ToString();
        }

        /// <summary>
        /// добавляет цифру 4
        /// </summary>
        private void InputFour(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.FOUR).ToString();
        }

        /// <summary>
        /// добавляет цифру 5
        /// </summary>
        private void InputFive(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.FIVE).ToString();
        }

        /// <summary>
        /// добавляет цифру 6
        /// </summary>
        private void InputSix(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.SIX).ToString();
        }

        /// <summary>
        /// добавляет цифру 7
        /// </summary>
        private void InputSeven(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.SEVEN).ToString();
        }

        /// <summary>
        /// добавляет цифру 8
        /// </summary>
        private void InputEight(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.EIGHT).ToString();
        }

        /// <summary>
        /// добавляет цифру 9
        /// </summary>
        private void InputNine(object sender, RoutedEventArgs e)
        {
            CheckingTextBoxInputZero();
            textBox_inputNumber.Text += ((double)Numbers.NINE).ToString();
        }

        /// <summary>
        /// добавляет точку.
        /// если первого символа нет, то добавляет 0.
        /// выключение кнопки после добавления символа
        /// </summary>
        private void InputDot(object sender, RoutedEventArgs e)
        {
            if (textBox_inputNumber.Text == string.Empty)
            {
                textBox_inputNumber.Text += ((double)Numbers.ZERO).ToString();
            }
            textBox_inputNumber.Text += ",";
            button_dot.IsHitTestVisible = false;
        }

        /// <summary>
        /// при попытке ввода двух 0 подряд в начале строки делает строку Empty
        /// </summary>
        void CheckingTextBoxInputZero()
        {
            if (textBox_inputNumber.Text == "0" || textBox_inputNumber.Text == "-0")
            {
                textBox_inputNumber.Text = string.Empty;
            }
        }

        /// <summary>
        /// проверяет textBoxInput на введеный текст.
        /// включает и отключает кнопки в зависимости от текста
        /// </summary>
        private void DisableButtons(object sender, TextChangedEventArgs e)
        {
            button_clearLastCharacter.IsEnabled = true;
            if (textBox_inputNumber.Text.Length != 0)
            {
                button_clearLastCharacter.IsHitTestVisible = true;
            }
            else
            {
                button_clearLastCharacter.IsHitTestVisible = false;
                button_dot.IsHitTestVisible = true;
            }
        }

        /// <summary>
        /// сложение
        /// </summary>
        private void Addition(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox_inputNumber.Text, out double number))
            {
                if (textBox_previousOperation.Text == "0")
                {
                    textBox_previousOperation.Text = $"0+{number}";
                    result += number;
                }
                else
                {
                    result += number;
                    textBox_previousOperation.Text += $"+{number}";
                }
                expressions.Push(textBox_previousOperation.Text);
                results.Push(result);
            }
        }

        /// <summary>
        /// вычитание
        /// </summary>
        private void Substraction(object sender, RoutedEventArgs e)
        {
            if (textBox_inputNumber.Text == string.Empty)
            {
                textBox_inputNumber.Text = "-";
                return;
            }
            if (double.TryParse(textBox_inputNumber.Text, out double number))
            {
                if (textBox_previousOperation.Text == "0")
                {
                    textBox_previousOperation.Text = $"0-{number}";
                    result -= number;
                }
                else
                {
                    result -= number;
                    textBox_previousOperation.Text += $"-{number}";
                }
                expressions.Push(textBox_previousOperation.Text);
                results.Push(result);
            }
        }

        /// <summary>
        /// умножение
        /// </summary>
        private void Multiplication(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox_inputNumber.Text, out double number))
            {
                if (textBox_previousOperation.Text == "0")
                {
                    textBox_previousOperation.Text = $"0*{number}";
                    result *= number;
                }
                else
                {
                    result *= number;
                    textBox_previousOperation.Text += $"*{number}";
                }
                expressions.Push(textBox_previousOperation.Text);
                results.Push(result);
            }
        }

        /// <summary>
        /// деление
        /// </summary>
        private void Division(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(textBox_inputNumber.Text, out double number))
            {
                if (number == 0)
                {
                    MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (textBox_previousOperation.Text == "0")
                {
                    textBox_previousOperation.Text = $"0/{number}";
                    result /= number;
                }
                else
                {
                    result /= number;
                    textBox_previousOperation.Text += $"/{number}";
                }
                expressions.Push(textBox_previousOperation.Text);
                results.Push(result);
            }
        }

        /// <summary>
        /// выводит результат
        /// </summary>
        private void Result(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text = result.ToString();
        }
    }
}
