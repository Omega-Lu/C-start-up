using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Forms.UserControls
{
    public partial class ToDoList : UserControl
    {

        #region Constants 
        #endregion Constants

        #region Instance Fields
        List<Task> tasks = new List<Task>();
        #endregion Instance Fields

        #region Properties

        #endregion Properties

        #region Constructor
        public ToDoList()
        {
            InitializeComponent();
            InitializeBindings();
        }
        #endregion Constructor

        #region Overridden Members
        #endregion Overridden Members

        #region Internal Classes
        public class Task
        {
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public bool isCompleted { get; set; }
        }
        #endregion Internal Classes

        #region Public Methods
        
        #endregion Public Methods

        #region Private Methods
        void InitializeBindings()
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                Description = lbxToDo.Text,
                DueDate = dueDateTimePicker.Value,
                isCompleted = false
            };
            tasks.Add(newTask);
            UpdateTaskList();
        
        }

        void UpdateTaskList()
        {
            lbxToDo.Items.Clear();
            foreach (Task task in tasks)
            {
                lbxToDo.Items.Add(task.Description);
            }
        }
        #endregion  Private Methods

        #region Events

        #endregion Events

    }
}
