namespace PlanShare.App.Views.Components.Inputs;

public partial class EntryAndLabelPassword : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(EntryAndLabelPassword),
        defaultValue: string.Empty);

    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    public EntryAndLabelPassword()
	{
		InitializeComponent();
	}

    private void ShowHidePassword(object sender, TappedEventArgs e)
    {
        if (EntryPassword.IsPassword)
        {
            EntryPassword.IsPassword = false;
            ImageEye.Source = "icon_eye.png";
        }
        else
        {
            EntryPassword.IsPassword = true;
            ImageEye.Source = "icon_eye_hidden.png";
        }
    }
}