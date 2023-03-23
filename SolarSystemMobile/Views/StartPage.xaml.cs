namespace SolarSystemMobile.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();

		if (this.AnimationIsRunning("TransitionAnimation"))
		{
			return; 
		}
		var parentAnimation = new Animation();

		//Planets Animation

		parentAnimation.Add(0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimation.Add(0.4, 0.6, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
	}
}