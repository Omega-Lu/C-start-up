using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        #endregion Constructor

        #region Overridden Members
        #endregion Overridden Members

        #region Internal Classes
        #endregion Internal Classes

        #region Public Methods

        #endregion Public Methods

        #region Private Methods
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            string computerName = Environment.MachineName;
            string userName = Environment.UserName;

            label1.Text = $"Welcome, {userName} on {computerName}";
        }

        #endregion  Private Methods

        #region Events
        private void wELCOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }
        #endregion Events

        private void hELLOWORLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.Show();
        }
    }
}
