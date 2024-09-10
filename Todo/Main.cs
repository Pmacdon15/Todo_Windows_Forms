using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Todo
{
    public partial class Main : Form
    {
        private const string CSV_FILE = "todos.csv";

        public Main()
        {
            InitializeComponent();
            InitializeTableLayoutPanel();
            LoadTodos();
        }

        private void InitializeTableLayoutPanel()
        {
            // Define columns if not already set in designer
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // For CheckBox
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // For TitleLabel
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // For DescriptionLabel

            // Define an initial row style
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        }

        private void LoadTodos()
        {
            // Check if the CSV file exists
            if (File.Exists(CSV_FILE))
            {
                // Read the CSV file and create TodoItem objects
                var todos = File.ReadAllLines(CSV_FILE)
                    .Select(line => line.Split(','))
                    .Select(columns => new TodoItem
                    {
                        Title = columns[0],
                        Description = columns[1],
                        IsCompleted = columns[2] == "True"
                    })
                    .ToArray();

                // Add the TodoItems to the table layout panel
                foreach (var todo in todos)
                {
                    AddTodoToTableLayoutPanel(todo);
                }
            }
        }

        private void AddTodoToTableLayoutPanel(TodoItem todo)
        {
            // Determine the current row index
            int rowIndex = tableLayoutPanel1.RowCount;

            // Add a new row if needed
            tableLayoutPanel1.RowCount = rowIndex + 1;

            // Add controls to the new row
            CheckBox checkBox = new CheckBox();
            Label titleLabel = new Label();
            Label descriptionLabel = new Label();

            // Set properties of the controls
            checkBox.Checked = todo.IsCompleted;
            titleLabel.Text = todo.Title;
            descriptionLabel.Text = todo.Description;

            titleLabel.AutoSize = true;
            descriptionLabel.AutoSize = true;

            // Add controls to the tableLayoutPanel at the specified row and column
            tableLayoutPanel1.Controls.Add(checkBox, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(titleLabel, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 2, rowIndex);

            // Optional: Adjust row style to fit content
            if (tableLayoutPanel1.RowStyles.Count <= rowIndex)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }

        private void button_Add_Todo_Click(object sender, EventArgs e)
        {
            // Create a new TodoItem
            var newTodo = new TodoItem
            {
                Title = textBox_Title_Input.Text,
                Description = textBox_Description_Input.Text,
                IsCompleted = false
            };

            // Add the TodoItem to the CSV file
            File.AppendAllLines(CSV_FILE, new[] { $"{newTodo.Title},{newTodo.Description},{newTodo.IsCompleted}" });

            // Add the TodoItem to the table layout panel
            AddTodoToTableLayoutPanel(newTodo);

            // Clear the text boxes
            textBox_Title_Input.Clear();
            textBox_Description_Input.Clear();
        }

        public class TodoItem
        {
            public required string Title { get; set; }
            public required string Description { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}
