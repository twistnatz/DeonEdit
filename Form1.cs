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
    //public class AddObjectEventArgs
    //{
    //    string object
    //}
    public partial class Form_Main : Form
    {
        Form_NewFile nf = new Form_NewFile();

        public Form_Main()
        {
            InitializeComponent();
            nf.AddObject += new EventHandler<AddEventArgs>(nf_AddObject);
        }

        void nf_AddObject(object sender, AddEventArgs e)
        {
            MessageBox.Show(e.name);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            nf.Show();
        }

        #region events

        

        #endregion
    }
}
