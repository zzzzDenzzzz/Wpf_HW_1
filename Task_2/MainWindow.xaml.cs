using System.Windows;

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
        public MainWindow()
        {
            InitializeComponent();
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
        /// очищает последний введенный символ в текущем числе
        /// если последний удаленный символ точка, включает кнопку dot
        /// если в textBox остался 0, удаляет его
        /// </summary>
        private void ClearLastCharacter(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text = textBox_inputNumber.Text.Remove(textBox_inputNumber.Text.Length - 1);
            if (textBox_inputNumber.Text.EndsWith("."))
            {
                button_dot.IsHitTestVisible = true;
            }
            if (textBox_inputNumber.Text.EndsWith("0"))
            {
                textBox_inputNumber.Text = textBox_inputNumber.Text.Remove(textBox_inputNumber.Text.Length - 1);
            }
        }

        /// <summary>
        /// добавляет цифру 0
        /// </summary>
        private void InputZero(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.ZERO).ToString();
        }

        /// <summary>
        /// добавляет цифру 1
        /// </summary>
        private void InputOne(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.ONE).ToString();
        }

        /// <summary>
        /// добавляет цифру 2
        /// </summary>
        private void InputTwo(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.TWO).ToString();
        }

        /// <summary>
        /// добавляет цифру 3
        /// </summary>
        private void InputThtree(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.THREE).ToString();
        }

        /// <summary>
        /// добавляет цифру 4
        /// </summary>
        private void InputFour(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.FOUR).ToString();
        }

        /// <summary>
        /// добавляет цифру 5
        /// </summary>
        private void InputFive(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.FIVE).ToString();
        }

        /// <summary>
        /// добавляет цифру 6
        /// </summary>
        private void InputSix(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.SIX).ToString();
        }

        /// <summary>
        /// добавляет цифру 7
        /// </summary>
        private void InputSeven(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.SEVEN).ToString();
        }

        /// <summary>
        /// добавляет цифру 8
        /// </summary>
        private void InputEight(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.EIGHT).ToString();
        }

        /// <summary>
        /// добавляет цифру 9
        /// </summary>
        private void InputNine(object sender, RoutedEventArgs e)
        {
            textBox_inputNumber.Text += ((double)Numbers.NINE).ToString();
        }

        /// <summary>
        /// добавляет точку
        /// если первого символа нет, то добавляет 0
        /// выключение кнопки после добавления символа
        /// </summary>
        private void InputDot(object sender, RoutedEventArgs e)
        {
            if (textBox_inputNumber.Text == string.Empty)
            {
                InputZero(sender, e);
            }
            textBox_inputNumber.Text += ".";
            button_dot.IsHitTestVisible = false;
        }
    }
}
