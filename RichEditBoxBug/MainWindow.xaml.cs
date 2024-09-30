using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RichEditBoxBug;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void RichEditBox_Loaded(object sender, RoutedEventArgs e)
    {
        if (sender is not RichEditBox richEditBox)
        {
            return;
        }

        richEditBox.Document.SetText(TextSetOptions.None, "Hello, World!");
    }
}
