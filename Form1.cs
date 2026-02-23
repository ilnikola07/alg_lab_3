using System;
using System.Windows.Forms;
using PowerLogic; 
namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Устанавливаем текстовое поле результата в режим "только чтение" 
            // и разрешаем перенос строк, так как число может быть огромным
            txtResult.ReadOnly = true;
            txtResult.Multiline = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считываем данные. Если в полях не числа, int.Parse выкинет FormatException
                int baseNum = int.Parse(txtBase.Text);
                int exponent = int.Parse(txtExp.Text);

                // 2. Вызываем методы из библиотеки. 
                // Если значения вне диапазона, библиотека выкинет ArgumentOutOfRangeException
                var naive = Calculator.Naive(baseNum, exponent);
                var fast = Calculator.Fast(baseNum, exponent);

                // 3. Вывод основного результата
                txtResult.Text = fast.Value.ToString();

                // 4. Вывод сравнительной статистики
                lblNaiveOps.Text = $"Операций: {naive.Ops}";
                lblNaiveTime.Text = $"Тиков: {naive.Ticks}";

                lblFastOps.Text = $"Операций: {fast.Ops}";
                lblFastTime.Text = $"Тиков: {fast.Ticks}";

                // Подсветка эффективности (опционально)
                lblFastOps.ForeColor = (fast.Ops < naive.Ops) ? System.Drawing.Color.Green : System.Drawing.Color.Black;
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа в поля ввода.", "Ошибка формата");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Подхватываем сообщение об ошибке прямо из библиотеки
                MessageBox.Show(ex.ParamName + ": " + ex.Message, "Ошибка диапазона");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}");
            }
        }
    }
}
