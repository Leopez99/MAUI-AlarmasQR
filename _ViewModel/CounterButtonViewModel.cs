using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

public partial class CounterButtonViewModel : ObservableObject
{
    private int count;

    [ObservableProperty]
    private string text = "Click me";

    [RelayCommand]
    private void Click()
    {
        count++;
        Text = $"Clicked {count} times";
    }
}
