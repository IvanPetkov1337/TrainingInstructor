namespace TrainingInstructor;

internal class SitCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Sit Down!");
    }
}
