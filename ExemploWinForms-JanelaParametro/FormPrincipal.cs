using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWinForms_JanelaParametro
{
    /// <summary>
    /// Form principal deste exemplo.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Cria uma instância de FormPrincipal e inicializa os controles gráficos.
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler utilizado para o evento "Click" do botäao "Escolher Produto".
        /// </summary>
        /// <param name="sender">O botão que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento Click.</param>
        private void escolherProdutoButton_Click(object sender, EventArgs e)
        {
            // Construindo uma instância do FormParametro, exibindo-o e resgatando o Produto selecionado.
            using (FormParametro formParametro = new FormParametro())
            {
                // Só continuamos caso o usuário confirme o diálogo e um caso um Produto tenha realmente sido selecionado.
                if ((formParametro.ShowDialog().Equals(System.Windows.Forms.DialogResult.OK)) &&
                    (formParametro.ProdutoSelecionado != null))
                {
                    produtoTextBox.Text = formParametro.ProdutoSelecionado.Descricao;
                }
            }
        }
    }
}
