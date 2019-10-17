using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Globalization;

namespace Calculator
{
    class Program
{
    static int Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // Define the 'add' command
        var addCommand = new Command("add")
        {
            Description = "Adds <first> to <second>"
        };

        var add2Command = new Command("add2");
        addCommand.AddCommand(add2Command);

        // Define the arguments for the add command
        // Please note that these argument names should match the input variables in the method
        addCommand.AddArgument(new Argument<double>("first"));
        addCommand.AddArgument(new Argument<double>("second"));

        // Define command handler for command
        // The parsed arguments are forwarded to the Add method of the ConsoleCalculator
        addCommand.Handler = CommandHandler.Create<double, double>(ConsoleCalculator.Add);

        // Add a shorthand alias
        addCommand.AddAlias("a");

        // Define the 'sub' command
        var subComamnd = new Command("sub")
        {
            Description = "Subtracts <second> from <first>"
        };

        // Define the arguments for the sub command
        // Please note that these argument names should match the input variables in the method
        subComamnd.AddArgument(new Argument<double>("first"));
        subComamnd.AddArgument(new Argument<double>("second"));

        // Define command handler for command
        // The parsed arguments are forwarded to the Subtract method of the ConsoleCalculator
        subComamnd.Handler = CommandHandler.Create<double, double>(ConsoleCalculator.Subtract);

        // Add a shorthand alias
        subComamnd.AddAlias("s");

        // Define the 'multiply' command
        var multiplyComamnd = new Command("multiply")
        {
            Description = "Multiplies <first> with <second>"
        };

        // Define the arguments for the multiply command
        // Please note that these argument names should match the input variables in the method
        multiplyComamnd.AddArgument(new Argument<double>("first"));
        multiplyComamnd.AddArgument(new Argument<double>("second"));

        // Define command handler for command
        // The parsed arguments are forwarded to the Multiply method of the ConsoleCalculator
        multiplyComamnd.Handler = CommandHandler.Create<double, double>(ConsoleCalculator.Multiply);

        // Add a shorthand alias
        multiplyComamnd.AddAlias("m");

        // Define the 'divide' command
        var divideComamnd = new Command("divide")
        {
            Description = "Divides <first> with <second>"
        };

        // Define the arguments for the divide command
        // Please note that these argument names should match the input variables in the method
        divideComamnd.AddArgument(new Argument<double>("first"));
        divideComamnd.AddArgument(new Argument<double>("second"));

        // Define command handler for command
        // The parsed arguments are forwarded to the Divide method of the ConsoleCalculator
        divideComamnd.Handler = CommandHandler.Create<double, double>(ConsoleCalculator.Divide);

        // Add a shorthand alias
        divideComamnd.AddAlias("d");

        // A RootCommand is required, we define it below and define our commands as subcommands
        var rootCommand = new RootCommand
        {
            addCommand,
            subComamnd,
            multiplyComamnd,
            divideComamnd
        };

        // Invoke the root command async and return the result
        return rootCommand.InvokeAsync(args).Result;
    }
}
}
