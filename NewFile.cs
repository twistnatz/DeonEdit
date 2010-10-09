using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeonEdit
{
    public class AddEventArgs : EventArgs
    {
        public string name;
    }
    public partial class Form_NewFile : Form
    {
        public Form_NewFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEventArgs ea = new AddEventArgs();
            ea.name = this.listBox1.SelectedItem.ToString();
            AddObject(this, ea);
            this.Hide();
        }

        public event EventHandler<AddEventArgs> AddObject;
    }
}
