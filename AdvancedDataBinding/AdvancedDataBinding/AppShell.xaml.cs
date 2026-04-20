namespace AdvancedDataBinding;

public partial class AppShell : Shell
{
    public AppShell(ConverterPage converterPage)
    {
        InitializeComponent();
        converterShellContent.Content = converterPage;
    }
}