using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;

namespace Views
{
    /// <summary>
    /// View Class (Form)
    /// </summary>
    public partial class MainView : Form, IMainView
    {
        /// <summary>
        /// Init form
        /// </summary>
        public MainView()
        {
            InitializeComponent();
        }

        #region Public Methods
        /// <summary>
        /// Run form
        /// </summary>
        public new void Show()
        {
            Application.Run(this);
        } 
        #endregion
    }
}