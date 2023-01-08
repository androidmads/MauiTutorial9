using ZXing.Net.Maui;

namespace MauiTutorial9;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            lbl.Text = $"{e.Results[0].Format}->{e.Results[0].Format}";
            barcodeView.IsDetecting = false;
        });
    }
}

