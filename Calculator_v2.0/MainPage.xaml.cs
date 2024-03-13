namespace Calculator_v2._0
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void operations(object sender, EventArgs e) {
            string buttonName = add_button.Id.ToString();
            switch (buttonName)
            {
                case "add_button":
                    break;
            }
        }

        public void numbers(object sender, EventArgs e) { }

        public void display(object sender, EventArgs e) { }

    }
}