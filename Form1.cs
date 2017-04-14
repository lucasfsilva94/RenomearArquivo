using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenomearArquivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        string Nome = string.Empty;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            while (dlgAbrirArquivo.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                if (MessageBox.Show("Tem certeza que deseja encerrar o programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    Application.Exit();
            }
            FileInfo fi = new FileInfo(dlgAbrirArquivo.FileName);
            lblArquivo.Text += fi.Name;

            cboAno.SelectedIndex = 0;
            cboMes.SelectedIndex = 0;
            cboDia.SelectedIndex = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            FileInfo fi = new FileInfo(dlgAbrirArquivo.FileName);
            string ArquivoOrigem = dlgAbrirArquivo.FileName;
            string ArquivoDestino = string.Concat(fi.DirectoryName, "\\", lblResultado.Text, fi.Extension);

            File.Move(ArquivoOrigem, ArquivoDestino);

            MessageBox.Show("Arquivo renomeado com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizarResultado()
        {
            string Mes = "";

            if ((cboMes.SelectedIndex + 1).ToString().Length == 1)
                Mes = string.Concat("0", (cboMes.SelectedIndex + 1).ToString());
            else
                Mes = (cboMes.SelectedIndex + 1).ToString();

            string evento = "";

            if (txtOutroEvento.TextLength > 0)
            {
                evento = txtOutroEvento.Text;                
            }
            else
            {
                evento = string.Concat(cboLocal.SelectedItem);
            }

            if (txtOutroFuncionario.TextLength > 0)
            {
                Nome = txtOutroFuncionario.Text;
                MudaCor(string.Empty);
            }

            lblResultado.Text = string.Concat(cboDia.SelectedItem, ".", Mes, ".", cboAno.SelectedItem.ToString().Substring(2, 2), "_", txtEvento.Text, "_", evento, "_", Nome);
        }

        private void MudaCor(string Botao)
        {
            if (Botao != string.Empty)
            {
                txtOutroFuncionario.Text = string.Empty;
            }

            if (Botao == btnCarlos.Name)
            {
                btnCarlos.BackColor = Color.Blue;
                btnCarlos.ForeColor = Color.White;
            }
            else
            {
                btnCarlos.BackColor = Color.Transparent;
                btnCarlos.ForeColor = Color.Black;
            }

            if (Botao == btnFrancisco.Name)
            {
                btnFrancisco.BackColor = Color.Blue;
                btnFrancisco.ForeColor = Color.White;
            }
            else
            {
                btnFrancisco.BackColor = Color.Transparent;
                btnFrancisco.ForeColor = Color.Black;
            }
            if (Botao == btnHumberto.Name)
            {
                btnHumberto.BackColor = Color.Blue;
                btnHumberto.ForeColor = Color.White;
            }
            else
            {
                btnHumberto.BackColor = Color.Transparent;
                btnHumberto.ForeColor = Color.Black;
            }
            if (Botao == btnJeffersonB.Name)
            {
                btnJeffersonB.BackColor = Color.Blue;
                btnJeffersonB.ForeColor = Color.White;
            }
            else
            {
                btnJeffersonB.BackColor = Color.Transparent;
                btnJeffersonB.ForeColor = Color.Black;
            }
            if (Botao == btnJoab.Name)
            {
                btnJoab.BackColor = Color.Blue;
                btnJoab.ForeColor = Color.White;
            }
            else
            {
                btnJoab.BackColor = Color.Transparent;
                btnJoab.ForeColor = Color.Black;
            }
            if (Botao == btnKelson.Name)
            {
                btnKelson.BackColor = Color.Blue;
                btnKelson.ForeColor = Color.White;
            }
            else
            {
                btnKelson.BackColor = Color.Transparent;
                btnKelson.ForeColor = Color.Black;
            }
            if (Botao == btnLuiz.Name)
            {
                btnLuiz.BackColor = Color.Blue;
                btnLuiz.ForeColor = Color.White;
            }
            else
            {
                btnLuiz.BackColor = Color.Transparent;
                btnLuiz.ForeColor = Color.Black;
            }

            if (Botao == btnRafael.Name)
            {
                btnRafael.BackColor = Color.Blue;
                btnRafael.ForeColor = Color.White;
            }
            else
            {
                btnRafael.BackColor = Color.Transparent;
                btnRafael.ForeColor = Color.Black;
            }

            if (Botao == btnFabiano.Name)
            {
                btnFabiano.BackColor = Color.Blue;
                btnFabiano.ForeColor = Color.White;
            }
            else
            {
                btnFabiano.BackColor = Color.Transparent;
                btnFabiano.ForeColor = Color.Black;
            }

            if (Botao == btnDaniel.Name)
            {
                btnDaniel.BackColor = Color.Blue;
                btnDaniel.ForeColor = Color.White;
            }
            else
            {
                btnDaniel.BackColor = Color.Transparent;
                btnDaniel.ForeColor = Color.Black;
            }

            if (Botao == btnCharles.Name)
            {
                btnCharles.BackColor = Color.Blue;
                btnCharles.ForeColor = Color.White;
            }
            else
            {
                btnCharles.BackColor = Color.Transparent;
                btnCharles.ForeColor = Color.Black;
            }

            if (Botao == btnLucasF.Name)
            {
                btnLucasF.BackColor = Color.Blue;
                btnLucasF.ForeColor = Color.White;
            }
            else
            {
                btnLucasF.BackColor = Color.Transparent;
                btnLucasF.ForeColor = Color.Black;
            }

            if (Botao == btnLucasM.Name)
            {
                btnLucasM.BackColor = Color.Blue;
                btnLucasM.ForeColor = Color.White;
            }
            else
            {
                btnLucasM.BackColor = Color.Transparent;
                btnLucasM.ForeColor = Color.Black;
            }

            if (Botao == btnJeffersonE.Name)
            {
                btnJeffersonE.BackColor = Color.Blue;
                btnJeffersonE.ForeColor = Color.White;
            }
            else
            {
                btnJeffersonE.BackColor = Color.Transparent;
                btnJeffersonE.ForeColor = Color.Black;
            }

            if (Botao == btnLeandro.Name)
            {
                btnLeandro.BackColor = Color.Blue;
                btnLeandro.ForeColor = Color.White;
            }
            else
            {
                btnLeandro.BackColor = Color.Transparent;
                btnLeandro.ForeColor = Color.Black;
            }
        }

        private void cboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void txtEvento_TextChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void cboLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void btnFabiano_Click(object sender, EventArgs e)
        {
            Nome = btnFabiano.Text;
            MudaCor(btnFabiano.Name);
            AtualizarResultado();
        }

        private void btnCarlos_Click(object sender, EventArgs e)
        {
            Nome = btnCarlos.Text;
            MudaCor(btnCarlos.Name);
            AtualizarResultado();
        }

        private void btnFrancisco_Click(object sender, EventArgs e)
        {
            Nome = btnFrancisco.Text;
            MudaCor(btnFrancisco.Name);
            AtualizarResultado();
        }

        private void btnHumberto_Click(object sender, EventArgs e)
        {
            Nome = btnHumberto.Text;
            MudaCor(btnHumberto.Name);
            AtualizarResultado();
        }

        private void btnJeffersonB_Click(object sender, EventArgs e)
        {
            Nome = btnJeffersonB.Text;
            MudaCor(btnJeffersonB.Name);
            AtualizarResultado();
        }

        private void btnJoab_Click(object sender, EventArgs e)
        {
            Nome = btnJoab.Text;
            MudaCor(btnJoab.Name);
            AtualizarResultado();
        }

        private void btnKelson_Click(object sender, EventArgs e)
        {
            Nome = btnKelson.Text;
            MudaCor(btnKelson.Name);
            AtualizarResultado();
        }

        private void btnLuiz_Click(object sender, EventArgs e)
        {
            Nome = btnLuiz.Text;
            MudaCor(btnLuiz.Name);
            AtualizarResultado();
        }

        private void btnRafael_Click(object sender, EventArgs e)
        {
            Nome = btnRafael.Text;
            MudaCor(btnRafael.Name);
            AtualizarResultado();
        }

        private void btnDaniel_Click(object sender, EventArgs e)
        {
            Nome = btnDaniel.Text;
            MudaCor(btnDaniel.Name);
            AtualizarResultado();
        }

        private void btnCharles_Click(object sender, EventArgs e)
        {
            Nome = btnCharles.Text;
            MudaCor(btnCharles.Name);
            AtualizarResultado();
        }

        private void btnLucasF_Click(object sender, EventArgs e)
        {
            Nome = btnLucasF.Text;
            MudaCor(btnLucasF.Name);
            AtualizarResultado();
        }

        private void btnLucasM_Click(object sender, EventArgs e)
        {
            Nome = btnLucasM.Text;
            MudaCor(btnLucasM.Name);
            AtualizarResultado();
        }

        private void btnJeffersonE_Click(object sender, EventArgs e)
        {
            Nome = btnJeffersonE.Text;
            MudaCor(btnJeffersonE.Name);
            AtualizarResultado();
        }

        private void btnLeandro_Click(object sender, EventArgs e)
        {
            Nome = btnLeandro.Text;
            MudaCor(btnLeandro.Name);
            AtualizarResultado();
        }

        private void txtOutroEvento_TextChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }

        private void txtOutroFuncionario_TextChanged(object sender, EventArgs e)
        {
            AtualizarResultado();
        }
    }
}
