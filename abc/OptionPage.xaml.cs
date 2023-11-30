

using MauiApp1.Model;
using Plugin.BLE;
using System.Diagnostics;

namespace MauiApp1;

public partial class OptionPage : ContentPage
{   
	public OptionPage()
	{
		InitializeComponent();
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }

    private void onORoff(object sender, ToggledEventArgs e)
    {
        BlueToothSwitchModel blueToothSwitchModel = new BlueToothSwitchModel();
        if (bridge.IsToggled)
        {
            blueToothSwitchModel.on();
        }
        else
        {
            
        }
        MyLabel.Text = blueToothSwitchModel.a;

    }
}