using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class FormCorrespondence : Form
    {
        public FormCorrespondence()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testdbDataSet.Korrespondenshin1". При необходимости она может быть перемещена или удалена.
            this.korrespondenshin1TableAdapter.Fill(this.testdbDataSet.Korrespondenshin1);
            this.textBox9.Text = (double.Parse(this.textBox4.Text)+double.Parse(this.textBox5.Text)+(this.textBox6.Text)).ToString();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.textBox9.Text = (double.Parse(this.textBox4.Text) + double.Parse(this.textBox5.Text) + (this.textBox6.Text)).ToString();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.textBox9.Text = (double.Parse(this.textBox4.Text) + double.Parse(this.textBox5.Text) + (this.textBox6.Text)).ToString();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            this.textBox9.Text = (double.Parse(this.textBox4.Text) + double.Parse(this.textBox5.Text) + (this.textBox6.Text)).ToString();
        }

    }
}
