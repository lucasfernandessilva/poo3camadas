using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3c1lucasfernandes23.Code.DTO;
using _3c1lucasfernandes23.Code.BLL;

namespace _3c1lucasfernandes23.Ui
{
    public partial class Frmlogin : Form
    {
        LoginBLL loginprodutoBBL = new LoginBLL();
        LoginDTO loginprodutoDTO = new LoginDTO();

        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginprodutoDTO.Nome = txtnome.Text;
            loginprodutoDTO.Palavrachave = txtpalavrachave.Text;


            //Chamada do método para verificar o acesso: 
            if (loginprodutoBBL.RealizarLogin(loginprodutoDTO) == true)
            {

                Frmlojasrede frm_rede = new Frmlojasrede();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
