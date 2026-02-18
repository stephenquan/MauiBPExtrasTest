// MainPage.xaml.cs

using CommunityToolkit.Maui;
using BPExtrasAttribute = SQuan.Helpers.Labs.BPExtrasAttribute;

namespace MauiBPExtrasTest;

#pragma warning disable IDE0011

public partial class MainPage : ContentPage
{
	[BindableProperty(PropertyChangedMethodName = nameof(OnCountChanged))]
	[BPExtras]
	public partial int Count { get; set; } = 0;

	partial void OnCountChanged(int value)
	{
		System.Diagnostics.Trace.WriteLine($"Count has changed to {value}");
	}

	partial void OnCountChanged(int oldValue, int newValue)
	{
		System.Diagnostics.Trace.WriteLine($"Count has changed from {oldValue} to {newValue}");
	}

	public MainPage()
	{
		InitializeComponent();
	}

	void OnCounterClicked(object? sender, EventArgs e)
	{
		Count++;

		if (Count == 1)
			CounterBtn.Text = $"Clicked {Count} times";
		else
			CounterBtn.Text = $"Clicked {Count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
