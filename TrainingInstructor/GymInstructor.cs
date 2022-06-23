namespace TrainingInstructor;

internal class GymInstructor : IGymInstructor
{
    private ITrainee _trainee;

    public GymInstructor(ITrainee trainee)
    {
        _trainee = trainee;
    }

    public void IssueCommand(ICommand command)
    {
        _trainee.MakeMove(command);
    }
}
