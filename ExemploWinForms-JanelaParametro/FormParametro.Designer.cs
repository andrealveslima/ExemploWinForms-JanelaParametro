namespace ExemploWinForms_JanelaParametro
{
    partial class FormParametro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.colCodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoProduto,
            this.colDescricao});
            this.produtosDataGridView.Location = new System.Drawing.Point(13, 13);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosDataGridView.Size = new System.Drawing.Size(400, 336);
            this.produtosDataGridView.TabIndex = 0;
            this.produtosDataGridView.DoubleClick += new System.EventHandler(this.produtosDataGridView_DoubleClick);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(338, 355);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 1;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(257, 355);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // colCodigoProduto
            // 
            this.colCodigoProduto.DataPropertyName = "Codigo";
            this.colCodigoProduto.HeaderText = "Cod. Produto";
            this.colCodigoProduto.Name = "colCodigoProduto";
            this.colCodigoProduto.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 200;
            // 
            // FormParametro
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(425, 390);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.produtosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormParametro";
            this.Text = "Escolha um Produto:";
            this.Load += new System.EventHandler(this.FormParametro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
    }
}