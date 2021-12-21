using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mysicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mysicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zakupka". При необходимости она может быть перемещена или удалена.
            this.zakupkaTableAdapter.Fill(this.dataSet1.Zakupka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.dataSet1.Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.dataSet1.Proizvoditel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this.dataSet1.Prodazha);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavhick". При необходимости она может быть перемещена или удалена.
            this.postavhickTableAdapter.Fill(this.dataSet1.Postavhick);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Mysic". При необходимости она может быть перемещена или удалена.
            this.mysicTableAdapter.Fill(this.dataSet1.Mysic);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysicBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mysicBindingSource.EndEdit();
            mysicTableAdapter.Update(dataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            postavhickBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            postavhickBindingSource.EndEdit();
            postavhickTableAdapter.Update(dataSet1);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            prodazhaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prodazhaBindingSource.EndEdit();
            prodazhaTableAdapter.Update(dataSet1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.EndEdit();
            proizvoditelTableAdapter.Update(dataSet1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            skladBindingSource.AddNew();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            skladBindingSource.EndEdit();
            skladTableAdapter.Update(dataSet1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            zakupkaBindingSource.AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            zakupkaBindingSource.EndEdit();
            zakupkaTableAdapter.Update(dataSet1);
        }

        private void postavhickBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
