namespace MauiBugDemoApp2
{
    public partial class MainPage : ContentPage
    {
        int enabledCount = 0;
        int disabledCount = 0;

        public MainPage()
        {
            InitializeComponent();

            var enabledTgr = new TapGestureRecognizer();
            enabledTgr.Tapped += (s, e) =>
            {
                enabledCount++;
                lblEnabledCount.Text = $"Enabled label taps: {enabledCount}";
            };
            lblEnabled.GestureRecognizers.Add(enabledTgr);

            var disabledTgr = new TapGestureRecognizer();
            disabledTgr.Tapped += (s, e) =>
            {
                disabledCount++;
                lblDisabledCount.Text = $"Disabled label taps: {disabledCount}";
            };
            lblDisabled.GestureRecognizers.Add(disabledTgr);
        }
    }
}
