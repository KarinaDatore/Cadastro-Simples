using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Contatos \nby Karina Lima Datore", "Sobre");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroSimplesDataSet);
            clienteCheckBox.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroSimplesDataSet.Cadastros' table. You can move, or remove it, as needed.
            this.cadastrosTableAdapter.Fill(this.cadastroSimplesDataSet.Cadastros);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteCheckBox.Checked = false;
        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
