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

        public event Action SendData;
        public void Recolor()
        {
            var t = new Random();
            button1.BackColor = Color.FromArgb(
                100, 
                t.Next(0, 255),
                t.Next(0, 255), 
                t.Next(0, 255));
        }

        public void OutputData(int value)
        {
            textBox1.Text = value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendData?.Invoke();
        }
    }
}