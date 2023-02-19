
using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "I";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            string boxtext= box.Text;

            Assert.Equal(boxtext, ct);
        }

        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "IM";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(boxtext, ct);
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(boxtext, ct);
        }
    }
}