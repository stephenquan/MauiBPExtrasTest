// MainPage.xaml.cs

using CommunityToolkit.Maui;
using BindablePropertyExtrasAttribute = SQuan.Helpers.Labs.BindablePropertyExtrasAttribute;

namespace MauiBPExtrasTest;

public partial class MainPage : ContentPage
{
	[BindableProperty(PropertyChangedMethodName = nameof(OnCountChanged))]
	[BindablePropertyExtras]
	public partial int Count { get; set; } = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	void OnCounterClicked(object? sender, EventArgs e)
	{
		Count++;
	}

	partial void OnCountChanged(int value)
	{
		CounterBtn.Text = $"Clicked {value} times";
		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
