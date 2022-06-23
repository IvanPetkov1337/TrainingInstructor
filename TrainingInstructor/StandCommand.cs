namespace TrainingInstructor;

internal class StandCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Stand Up!");
    }
}
