using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp;

public partial class CustomizeViewViewModel: ObservableObject
{
    public CustomizeViewViewModel()
    {
        ListItems = [new CustomizeListViewModel() { TheName = "item1" }];
    }

    [ObservableProperty]
    private ObservableCollection<CustomizeListViewModel> listItems;
}
