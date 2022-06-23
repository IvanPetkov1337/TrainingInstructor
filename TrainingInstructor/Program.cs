using TrainingInstructor;

ICommand sit = new SitCommand();
ICommand stand = new StandCommand();

IViewer viewer = new Viewer();
IViewer viewer1 = new Viewer();
IViewer viewer2 = new Viewer();

ITrainee trainee = new Trainee();

trainee.AddViewer(viewer);
trainee.AddViewer(viewer1);
trainee.AddViewer(viewer2);

IGymInstructor instructor = new GymInstructor(trainee);

instructor.IssueCommand(sit);
instructor.IssueCommand(stand);

trainee.RemoveViewer(viewer);

instructor.IssueCommand(sit);

Console.ReadKey();