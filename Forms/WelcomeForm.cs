using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Forms.UserControls;

namespace WindowsFormsApp6.Forms
{
    public partial class WelcomeForm : Form
    {
        #region Constants 
        #endregion Constants

        #region Instance Fields
        
        #endregion Instance Fields

        #region Properties

        #endregion Properties

        #region Constructor
        public WelcomeForm()
        {
            InitializeComponent();
            InitializeMenu();
        }
        #endregion Constructor

        #region Overridden Members
        #endregion Overridden Members

        #region Internal Classes
        #endregion Internal Classes

        #region Public Methods
        void InitializeMenu()
        {
           
            ToolStripMenuItem toDo = new ToolStripMenuItem("TODO LIST");
            toDo.Click += ToDoList_Click;
            toDo.Margin = new Padding(5, 5, 5, 5); // Add horizontal spacing
            menuStrip.Items.Add(toDo);

        }
        #endregion Public Methods

        #region LoadUserControl
        UserControl LoadUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;

            return userControl;
        }

        #endregion LoadUserControl

        #region Private Methods
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            string computerName = Environment.MachineName;
            string userName = Environment.UserName;

            label1.Text = $"Welcome, {userName} on {computerName}";
        } 

        #endregion  Private Methods

        #region Events
        #endregion Events
        #region MenuItemHandlers
        private void helloWorldMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HelloWorld());
        }

        private void calculatorMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Calculator());
        }
        private void ToDoList_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ToDoList());
        }


        #endregion MenuItemHandlers
    }

}
