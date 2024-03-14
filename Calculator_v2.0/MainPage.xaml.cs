namespace Calculator_v2._0
{
    public partial class MainPage : ContentPage
    {

        double result;
        double num1;
        double num2;
        string selectedOperation;
        bool twoNumbersSelected;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click de botones de operacion y que asigna el valor a la variable selectedOperation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operations(object sender, EventArgs e) {
            Button buttonName = (Button)sender;
            switch (buttonName.Text)
            {
                case "+":
                    result = result + num1;
                    break;
                case "-":
                    result = result - num1;
                    break;
                case "*":
                    result = result * num1;
                    break;
                case "/":
                    result = result / num1;
                    break;
                case "=":
                    break;
                case "C":
                    result = 0;
                    num1 = 0;
                    num2 = 0;
                    calc_display.Text = "0";
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numbers(object sender, EventArgs e) {
            Button buttonName = (Button)sender;
            //double.TryParse(num, out string numTxt);
            
        }

        private void cancelOperation() { }

    }
}