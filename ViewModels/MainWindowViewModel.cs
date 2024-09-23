using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace Tasks.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _taskName;
        public string TaskName
        {
            get => _taskName;
            set => this.RaiseAndSetIfChanged(ref _taskName, value);
        }

        private string _taskDescription;
        public string TaskDescription
        {
            get => _taskDescription;
            set => this.RaiseAndSetIfChanged(ref _taskDescription, value);
        }

        private string _taskPriority;
        public string TaskPriority
        {
            get => _taskPriority;
            set => this.RaiseAndSetIfChanged(ref _taskPriority, value);
        }

        public ObservableCollection<string> TaskList { get; } = new ObservableCollection<string>();

        public ReactiveCommand<Unit, Unit> AddTaskCommand { get; }

        public MainWindowViewModel()
        {
            AddTaskCommand = ReactiveCommand.Create(AddTask);
        }

        private void AddTask()
        {
            TaskList.Add($"{TaskName} (Priority: {TaskPriority}) - {TaskDescription}");
            TaskName = string.Empty;
            TaskDescription = string.Empty;
            TaskPriority = string.Empty;
        }
    }
}
