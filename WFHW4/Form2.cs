using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW4
{
    public partial class Form2 : Form
    {
        public Person person = null;

        public string PesonFName
        {
            get { return textBox1.Text; }
        }
        public string PersonSName
        {
            get { return textBox2.Text; }
        }
        public DateTime PersonBirthD
        {
            get { return dateTimePicker1.Value; }
        }
        public string PersonCountry
        {
            get { return textBox3.Text; }
        }
        public string PersonCity
        {
            get { return textBox4.Text; }
        }
        public string PersonSex
        {
            get { return comboBox1.Text; }
        }

        public Form2()
        {
            InitializeComponent();;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Поля не можуть бути пустими", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime tmp = this.dateTimePicker1.Value;
            person = new Person(textBox1.Text, textBox2.Text, tmp, textBox3.Text, textBox4.Text, comboBox1.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
