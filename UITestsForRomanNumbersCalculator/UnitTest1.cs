
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
            await Task.Delay(1000);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);

            string t = "I";

            Assert.Equal(t, ct);
        }
    }
}