namespace TrainingInstructor;

internal class Viewer : IViewer
{
    public void Mimic(ICommand command)
    {
        command.Execute();
    }
}
