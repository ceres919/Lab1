
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
            string ct = "IM";
            await Task.Delay(100);

            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);

            await Task.Delay(50);

            string boxtext= box.Text;

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "MMD";
            await Task.Delay(100);


            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Mul");
            var button5 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var button6 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button4.Command.Execute(button4.CommandParameter);
            button5.Command.Execute(button5.CommandParameter);
            button6.Command.Execute(button6.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
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

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "CDXL";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var button5 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var button6 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button4.Command.Execute(button4.CommandParameter);
            button5.Command.Execute(button5.CommandParameter);
            button6.Command.Execute(button6.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "II";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Div");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button4.Command.Execute(button4.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "CLV";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Add");
            var button5 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var button6 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button4.Command.Execute(button4.CommandParameter);
            button5.Command.Execute(button5.CommandParameter);
            button6.Command.Execute(button6.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test7()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "#ERROR";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button4.Command.Execute(button4.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
        }

        [Fact]
        public async void Test8()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            string ct = "";
            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");
            var button1 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "D");
            var button2 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Sub");
            var button3 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var button4 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Result");
            var button5 = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "Reset");

            var box = mainWindow.GetVisualDescendants().OfType<TextBox>().First();

            button.Command.Execute(button.CommandParameter);
            button1.Command.Execute(button1.CommandParameter);
            button2.Command.Execute(button2.CommandParameter);
            button3.Command.Execute(button3.CommandParameter);
            button5.Command.Execute(button5.CommandParameter);

            await Task.Delay(50);

            string boxtext = box.Text;

            Assert.Equal(ct, boxtext);
        }
    }
}