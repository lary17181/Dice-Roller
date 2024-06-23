namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int tipo_dado = Convert.ToInt32(escolha.SelectedItem);

            if (tipo_dado == 4)
            {
                int result = new Random().Next(1, 5);
                numero.Text=result.ToString();
            }
            if (tipo_dado == 6)
            {
                int result = new Random().Next(1, 7);
                numero.Text = result.ToString();
            }
            if (tipo_dado == 8)
            {
                int result = new Random().Next(1, 9);
                numero.Text = result.ToString();
            }
            if (tipo_dado == 10)
            {
                int result = new Random().Next(1, 11);
                numero.Text = result.ToString();
            }
            if (tipo_dado == 20)
            {
                int result = new Random().Next(1, 21);
                numero.Text = result.ToString();
            }
            if (tipo_dado == 100)
            {
                int result = new Random().Next(1, 101);
                numero.Text = result.ToString();
            }



        }
    }

}
