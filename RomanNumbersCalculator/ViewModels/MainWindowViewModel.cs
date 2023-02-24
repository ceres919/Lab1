using ReactiveUI;
using RomanNumbersCalculator.Models;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string currentNumberStringRepresentation = "";
        private string currentOperationStringRepresentation = "";
        private Stack<RomanNumberExtend> stackRomanNumbers = new Stack<RomanNumberExtend>();

        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }
        public ReactiveCommand<string, Unit> PlusCommand { get; }
        public ReactiveCommand<string, Unit> SubCommand { get; }
        public ReactiveCommand<string, Unit> MulCommand { get; }
        public ReactiveCommand<string, Unit> DivCommand { get; }
        public ReactiveCommand<string, Unit> CalculateCommand { get; }

        public string CurrentNumberStringRepresentation
        {
            set { this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value); }
            get { return currentNumberStringRepresentation; }
        }

        public MainWindowViewModel()
        {
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentNumberStringRepresentation == "#ERROR") return;
                if (currentOperationStringRepresentation == "=") Reset();
                CurrentNumberStringRepresentation += str;
            });
            ResetCommand = ReactiveCommand.Create(() => Reset());
            PlusCommand = ReactiveCommand.Create<string>(executeOperation);
            SubCommand = ReactiveCommand.Create<string>(executeOperation);
            MulCommand = ReactiveCommand.Create<string>(executeOperation);
            DivCommand = ReactiveCommand.Create<string>(executeOperation);
            CalculateCommand = ReactiveCommand.Create<string>( operation =>
            {
                if (stackRomanNumbers.Count != 1 || currentNumberStringRepresentation == "" || currentNumberStringRepresentation == "#ERROR") return;
                try
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);

                    calculateExecuteOperation(newNumber);
                    currentOperationStringRepresentation = "=";
                    CurrentNumberStringRepresentation = stackRomanNumbers.Peek().ToString();
                }
                catch (RomanNumberException exception)
                {
                    CurrentNumberStringRepresentation = $"{exception.Message}";
                }
            });

        }
        private void Reset()
        {
            CurrentNumberStringRepresentation = "";
            currentOperationStringRepresentation = "";
            stackRomanNumbers.Clear();
        }
        private void calculateExecuteOperation(RomanNumberExtend number)
        {
            switch (currentOperationStringRepresentation)
            {
                case "+":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() + number);
                    break;
                case "-":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() - number);
                    break;
                case "*":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() * number);
                    break;
                case "/":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() / number);
                    break;
            }
        }
        private void executeOperation(string operation)
        {
            if (currentNumberStringRepresentation == "#ERROR") return;
            if (currentNumberStringRepresentation == "" && currentOperationStringRepresentation != "")
            {
                currentOperationStringRepresentation = operation;
                return;
            }
            if (currentNumberStringRepresentation == "") return;
            if (currentOperationStringRepresentation == "=")
            {
                currentOperationStringRepresentation = operation;
                CurrentNumberStringRepresentation = "";
                return;
            }
            
            try
            {
                
                if (currentOperationStringRepresentation == "")
                {
                    currentOperationStringRepresentation = operation;
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    stackRomanNumbers.Push(newNumber);
                    CurrentNumberStringRepresentation = "";
                }
                else
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    calculateExecuteOperation(newNumber);
                    currentOperationStringRepresentation = operation;
                    CurrentNumberStringRepresentation = "";

                }
            }
            catch (RomanNumberException exception) 
            { 
                CurrentNumberStringRepresentation = $"{exception.Message}"; 
            }
        }
    }
}
