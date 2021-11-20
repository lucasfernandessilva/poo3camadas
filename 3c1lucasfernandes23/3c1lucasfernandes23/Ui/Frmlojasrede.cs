using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3c1lucasfernandes23.Code.BLL;
using _3c1lucasfernandes23.Code.DTO;

namespace _3c1lucasfernandes23.Ui
{
    public partial class Frmlojasrede : Form
    {
        LojasredeBLL medbll = new LojasredeBLL();
        LojasredeDTO meddto = new LojasredeDTO();
       
        public Frmlojasrede()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            meddto.Nomeproduto = txtnproduto.Text;
            meddto.Quantidadecomprada = txtquantcomprada.Text;


            if (txtnproduto.Text != "" || txtquantcomprada.Text != "")
            {
                medbll.Inserir(meddto);

                MessageBox.Show("Cadastrado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtid.Clear();
                txtnproduto.Clear();
                txtquantcomprada.Clear();

            }
            else
            {
                MessageBox.Show("Erro, preencha todos os campos!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Frmlojasrede_Load(object sender, EventArgs e)
        {
            dgvlojasrede.DataSource = medbll.Listar();
        }

        private void dgvlojasrede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvlojasrede.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnproduto.Text = dgvlojasrede.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtquantcomprada.Text = dgvlojasrede.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtid.Text);
            meddto.Nomeproduto = (txtnproduto.Text);
            meddto.Quantidadecomprada = (txtquantcomprada.Text);

            medbll.Editar(meddto);

            MessageBox.Show("Alterado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtid.Clear();
            txtnproduto.Clear();
            txtquantcomprada.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtid.Text);

            medbll.Excluir(meddto);

            MessageBox.Show("Excluido com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            medbll.Listar();

            txtid.Clear();
            txtnproduto.Clear();
            txtquantcomprada.Clear();
        }
    }
}
