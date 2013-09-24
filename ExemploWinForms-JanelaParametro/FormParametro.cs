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
    /// Exemplo de Form de parâmetro utilizado para selecionar um Produto neste exemplo.
    /// </summary>
    public partial class FormParametro : Form
    {
        /// <summary>
        /// Caso um Produto tenha sido selecionado, esta propriedade guardará o Produto que foi selecionado.
        /// </summary>
        public Produto ProdutoSelecionado { get; set; }

        /// <summary>
        /// Cria uma instância de FormParametro e inicializa os controles gráficos.
        /// </summary>
        public FormParametro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handler utilizado para o evento "Load" do Form de parâmetro.
        /// </summary>
        /// <param name="sender">O Form que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento Load.</param>
        private void FormParametro_Load(object sender, EventArgs e)
        {
            // Aqui nós criamos uma lista de Produtos fictícia. Em um cenário real você provavelmente carregaria a lista de Produtos de um banco de dados.
            List<Produto> listaProdutos = new List<Produto>();

            listaProdutos.Add(new Produto { Codigo = 1, Descricao = "Produto 1" });
            listaProdutos.Add(new Produto { Codigo = 2, Descricao = "Produto 2" });
            listaProdutos.Add(new Produto { Codigo = 3, Descricao = "Produto 3" });
            listaProdutos.Add(new Produto { Codigo = 4, Descricao = "Produto 4" });
            listaProdutos.Add(new Produto { Codigo = 5, Descricao = "Produto 5" });
            listaProdutos.Add(new Produto { Codigo = 6, Descricao = "Produto 6" });
            listaProdutos.Add(new Produto { Codigo = 7, Descricao = "Produto 7" });
            listaProdutos.Add(new Produto { Codigo = 8, Descricao = "Produto 8" });
            listaProdutos.Add(new Produto { Codigo = 9, Descricao = "Produto 9" });
            listaProdutos.Add(new Produto { Codigo = 10, Descricao = "Produto 10" });

            // O DataSource do DataGridView será a nossa lista de Produtos fictícia.
            produtosDataGridView.DataSource = listaProdutos;
        }
        /// <summary>
        /// Handler utilizado para o evento "Click" do botão "OK".
        /// </summary>
        /// <param name="sender">O botão que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento Click.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // Quando o usuário clica no botão "OK", precisamos selecionar o Produto e fechar o Form.
            SelecionarProdutoEFecharForm();
        }
        /// <summary>
        /// Handler utilizado para o evento "DoubleClick" do DataGridView de Produtos.
        /// </summary>
        /// <param name="sender">O DataGridView que disparou este evento.</param>
        /// <param name="e">Informações sobre o evento DoubleClick.</param>
        private void produtosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            // Quando o usuário efetua um duplo clique no DataGridView, precisamos selecionar o Produto e fechar o Form.
            SelecionarProdutoEFecharForm();
        }
        /// <summary>
        /// Preenche a propriedade "ProdutoSelecionado" com o Produto que está selecionado no DataGridView de Produtos e fecha o Form.
        /// </summary>
        private void SelecionarProdutoEFecharForm()
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (produtosDataGridView.SelectedRows.Count > 0)
                ProdutoSelecionado = produtosDataGridView.SelectedRows[0].DataBoundItem as Produto;

            this.Close();
        }
    }
}
