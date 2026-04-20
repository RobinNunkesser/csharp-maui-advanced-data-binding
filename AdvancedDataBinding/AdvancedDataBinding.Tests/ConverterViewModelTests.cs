using AdvancedDataBinding.ViewModels;

namespace AdvancedDataBinding.Tests;

public class ConverterViewModelTests
{
    [Fact]
    public void Text_IsEmptyByDefault()
    {
        var vm = new ConverterViewModel();
        Assert.Equal(string.Empty, vm.Text);
    }

    [Fact]
    public void SendCommand_ClearsText()
    {
        var vm = new ConverterViewModel();
        vm.Text = "Hello, World!";

        vm.SendCommand.Execute(null);

        Assert.Equal(string.Empty, vm.Text);
    }

    [Fact]
    public void Text_RaisesPropertyChanged()
    {
        var vm = new ConverterViewModel();
        var raised = false;
        vm.PropertyChanged += (_, e) =>
        {
            if (e.PropertyName == nameof(vm.Text)) raised = true;
        };

        vm.Text = "test";

        Assert.True(raised);
    }
}
