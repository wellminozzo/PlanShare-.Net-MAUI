
namespace PlanShare.App.Views.Components.Inputs;

public partial class EntryAndLabelComponent : ContentView
{
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(
		nameof(Title),
		typeof(string),
		typeof(EntryAndLabelComponent),
		defaultValue: string.Empty);

  

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        nameof(Placeholder),
        typeof(string),
        typeof(EntryAndLabelComponent),
        defaultValue: string.Empty);

    public static readonly BindableProperty KeyboardProperty = BindableProperty.Create(
        nameof(Keyboard),
        typeof(Keyboard),
        typeof(EntryAndLabelComponent),
        defaultValue: Keyboard.Default);
    public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
	public string Placeholder { get => (string)GetValue(PlaceholderProperty); set => SetValue(PlaceholderProperty, value); }
    public Keyboard Keyboard { get => (Keyboard)GetValue(KeyboardProperty); set => SetValue(KeyboardProperty, value); }

    public EntryAndLabelComponent()
	{
		InitializeComponent();
	}
}