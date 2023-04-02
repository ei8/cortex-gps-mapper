using CommunityToolkit.Mvvm.ComponentModel;

namespace ei8.Cortex.Gps.Mapper.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        string title;
    }
}
