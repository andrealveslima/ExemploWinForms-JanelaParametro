namespace ExemploWinForms_JanelaParametro
{
    partial class FormPrincipal
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
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.escolherProdutoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.Enabled = false;
            this.produtoTextBox.Location = new System.Drawing.Point(13, 13);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(259, 20);
            this.produtoTextBox.TabIndex = 0;
            // 
            // escolherProdutoButton
            // 
            this.escolherProdutoButton.Location = new System.Drawing.Point(13, 40);
            this.escolherProdutoButton.Name = "escolherProdutoButton";
            this.escolherProdutoButton.Size = new System.Drawing.Size(259, 23);
            this.escolherProdutoButton.TabIndex = 1;
            this.escolherProdutoButton.Text = "Escolher Produto";
            this.escolherProdutoButton.UseVisualStyleBackColor = true;
            this.escolherProdutoButton.Click += new System.EventHandler(this.escolherProdutoButton_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.escolherProdutoButton);
            this.Controls.Add(this.produtoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Form Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.Button escolherProdutoButton;
    }
}

