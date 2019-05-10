using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public delegate void OnTextBoxEventHandler(string message);
    public partial class Form1 : Form
    {
        OnTextBoxEventHandler _onTextBoxHandler;
        public Form1()
        {
            InitializeComponent();
        }

        public void Run()
        {
            _onTextBoxHandler += ChangeLabelColor;
            _onTextBoxHandler += ShowMessageBox;
            _onTextBoxHandler("This is test message");
        }

        public void ChangeLabelColor(string message)
        {
            lblheading.Text = message;
            lblheading.ForeColor = Color.Red;
        }

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}
