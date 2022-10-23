using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Figures list field's property
        /// </summary>
        private BindingList<FigureBase> _figureList ;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _figureList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newInputForm = new InputForm();

            newInputForm.Owner = this;

            newInputForm.Show();
            _figureList = new BindingList<FigureBase>()
           {
               new Parallelepiped(){Height =25}

           };
            dataGridView1.DataSource = _figureList;
        }
    }
}
