using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AdvancedDataBinding.ViewModels;

public partial class ConverterViewModel : ObservableObject
{
    [ObservableProperty]
    private string _text = string.Empty;

    [RelayCommand]
    private void Send()
    {
        Text = string.Empty;
    }
}
