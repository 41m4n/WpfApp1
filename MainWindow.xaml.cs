using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.Json;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        private string SaveFilePath => "tasks.json";

        public MainWindow()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>();
            TaskList.ItemsSource = Tasks;
            LoadTasksFromFile(); // Load on startup
        }

        // Add Task
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskInput.Text) && TaskInput.Text != "Enter a task...")
            {
                Tasks.Add(new TaskItem
                {
                    Description = TaskInput.Text,
                    IsDone = false
                });

                TaskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }
        }

        // Remove Selected Task
        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is TaskItem selectedTask)
            {
                Tasks.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void TaskInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TaskInput.Text == "Enter a task...")
            {
                TaskInput.Text = "";
                TaskInput.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TaskInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TaskInput.Text))
            {
                TaskInput.Text = "Enter a task...";
                TaskInput.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        // Save tasks to file
        private void SaveTasksToFile()
        {
            var json = JsonSerializer.Serialize(Tasks);
            File.WriteAllText(SaveFilePath, json);
            MessageBox.Show("Tasks saved successfully.");
        }

        // Load tasks from file
        private void LoadTasksFromFile()
        {
            if (File.Exists(SaveFilePath))
            {
                string json = File.ReadAllText(SaveFilePath);
                var loadedTasks = JsonSerializer.Deserialize<ObservableCollection<TaskItem>>(json);

                if (loadedTasks != null)
                {
                    Tasks.Clear();
                    foreach (var task in loadedTasks)
                        Tasks.Add(task);
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTasksToFile();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadTasksFromFile();
        }
    }
}