namespace TrainingInstructor;

internal class Trainee : ITrainee
{
    private List<IViewer> _viewerList;

    public Trainee()
    {
        _viewerList = new List<IViewer>();
    }

    public void MakeMove(ICommand command)
    {
        _viewerList.ForEach(v => v.Mimic(command));
    }

    public void AddViewer(IViewer viewer)
    {
        _viewerList.Add(viewer);
    }

    public void RemoveViewer(IViewer viewer)
    {
        if (_viewerList.Contains(viewer)) _viewerList.Remove(viewer);
    }
}