namespace TrainingInstructor;

internal interface ITrainee
{
    void AddViewer(IViewer viewer);
    void MakeMove(ICommand command);
    void RemoveViewer(IViewer viewer);
}
