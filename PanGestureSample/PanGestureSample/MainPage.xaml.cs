using System.Diagnostics;

namespace PanGestureSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void PanGestureRecognizer_PanUpdated(System.Object sender, Microsoft.Maui.Controls.PanUpdatedEventArgs e)
    {
		Debug.WriteLine($"StatusType: {e.StatusType} TotalX: {e.TotalX} TotalY:{e.TotalY}");
    }
}


