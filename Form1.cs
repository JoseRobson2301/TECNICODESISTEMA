using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmApplicationMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
           if(txtCod.Text.Trim() == "" || txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
           {
               MessageBox.Show("Peço desculpas, mas os campos fornecidos são inválidos. Por favor, forneça as informações corretas :(");

               return;
           }

           FrmControleUser frm = new FrmControleUser();
           frm.ShowDialog();
        }
    }
}
