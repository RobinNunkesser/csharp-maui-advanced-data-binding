using AdvancedDataBinding.ViewModels;

namespace AdvancedDataBinding;

public partial class ConverterPage : ContentPage
{
    public ConverterPage(ConverterViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}