namespace AppGeneMotivacion
{
    public partial class MainPage : ContentPage
    {
        private List<string> _quotes = new List<string>()
        {
            "El éxito es la suma de pequeños esfuerzos repetidos día tras día.",
            "No importa lo lento que vayas, siempre y cuando no te detengas.",
            "La única forma de hacer un gran trabajo es amar lo que haces.",
            "El fracaso es solo la oportunidad de comenzar de nuevo,esta vez de forma mas inteligente.",
            "La vida es un 10% lo que me ocurre y un 90% como reacciono a ello.",
            "Si puede soñarlo, puedes hacerlo.",
        };

        public MainPage()
        {
            InitializeComponent();
            Appearing += (sender, e) => StartScrollingAnimation();
        }

        private void OnGenerateButtonClicked(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(_quotes.Count);
            quoteLabel.Text = _quotes[index];         
        }
        private void StartScrollingAnimation()
        {
            double length = scrollingLabel.Text.Length * 10;

            var animation = new Animation(callback: x => scrollingLabel.TranslationX = x, start: length, end: -length, easing: Easing.Linear);
            animation.Commit(this, "StartScrollingAnimation", length: 50000, repeat: () => true);
        }
    }

}
