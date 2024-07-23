namespace toDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string task = txtTaskInput.Text;
            if (!string.IsNullOrWhiteSpace(task))
            {
                listBoxTasks.Items.Add(task);
                txtTaskInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid task.");
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                listBoxTasks.Items.Remove(listBoxTasks.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (var item in listBoxTasks.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Tasks saved successfully.");
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            if (File.Exists("tasks.txt"))
            {
                listBoxTasks.Items.Clear();
                using (StreamReader reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBoxTasks.Items.Add(line);
                    }
                }
                MessageBox.Show("Tasks loaded successfully.");
            }
            else
            {
                MessageBox.Show("No saved tasks found.");
            }
        }
    }
}