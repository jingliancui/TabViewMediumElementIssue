using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp;

public partial class CustomizeListViewModel : ObservableObject
{
    [ObservableProperty]
    private string? theName;
}
