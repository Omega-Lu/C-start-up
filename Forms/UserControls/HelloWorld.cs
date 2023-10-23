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
    public partial class HelloWorld : UserControl
    {

        #region Constants 
        #endregion Constants

        #region Instance Fields

        #endregion Instance Fields

        #region Properties

        #endregion Properties

        #region Constructor
        public HelloWorld()
        {
            InitializeComponent();
            initializeBindings();
        }
        #endregion Constructor

        #region Overridden Members
        #endregion Overridden Members

        #region Internal Classes
        #endregion Internal Classes

        #region Public Methods

        #endregion Public Methods

        #region Private Methods

        void initializeBindings()
        {
            labelDesciption();
        }

        void labelDesciption()
        {
            lblHelloWorld.Text = "Hello World";
        }

        #endregion  Private Methods

        #region Events

        #endregion Events

    }
}
