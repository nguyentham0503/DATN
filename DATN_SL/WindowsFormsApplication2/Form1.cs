using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        DataSet1 ds = null;
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HocKy' table. You can move, or remove it, as needed.
           // this.hocKyTableAdapter.Fill(this.dataSet1.HocKy);
            reportManager1.DataSources.Add("ds", ds);

        }
    }
}
