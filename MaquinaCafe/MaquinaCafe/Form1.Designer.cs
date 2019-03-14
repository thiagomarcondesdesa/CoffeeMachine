namespace MaquinaCafe
{
    partial class frmMaquinaCafe
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
            this.txtValorCafe = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdeVendida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorInserido = new System.Windows.Forms.TextBox();
            this.txtPainel = new System.Windows.Forms.TextBox();
            this.btnInserirMoeda = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnTroco = new System.Windows.Forms.Button();
            this.rtbRelatorio = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorCafe
            // 
            this.txtValorCafe.Enabled = false;
            this.txtValorCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCafe.Location = new System.Drawing.Point(12, 76);
            this.txtValorCafe.Name = "txtValorCafe";
            this.txtValorCafe.Size = new System.Drawing.Size(136, 38);
            this.txtValorCafe.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(12, 139);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(136, 40);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor do Café";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtde. Vendida";
            // 
            // txtQtdeVendida
            // 
            this.txtQtdeVendida.Enabled = false;
            this.txtQtdeVendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeVendida.Location = new System.Drawing.Point(168, 76);
            this.txtQtdeVendida.Name = "txtQtdeVendida";
            this.txtQtdeVendida.Size = new System.Drawing.Size(136, 38);
            this.txtQtdeVendida.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Inserido";
            // 
            // txtValorInserido
            // 
            this.txtValorInserido.Enabled = false;
            this.txtValorInserido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInserido.Location = new System.Drawing.Point(319, 76);
            this.txtValorInserido.Name = "txtValorInserido";
            this.txtValorInserido.Size = new System.Drawing.Size(136, 38);
            this.txtValorInserido.TabIndex = 6;
            // 
            // txtPainel
            // 
            this.txtPainel.Enabled = false;
            this.txtPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPainel.Location = new System.Drawing.Point(12, 12);
            this.txtPainel.Name = "txtPainel";
            this.txtPainel.Size = new System.Drawing.Size(443, 38);
            this.txtPainel.TabIndex = 8;
            // 
            // btnInserirMoeda
            // 
            this.btnInserirMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirMoeda.Location = new System.Drawing.Point(168, 139);
            this.btnInserirMoeda.Name = "btnInserirMoeda";
            this.btnInserirMoeda.Size = new System.Drawing.Size(136, 40);
            this.btnInserirMoeda.TabIndex = 9;
            this.btnInserirMoeda.Text = "Inserir Moeda";
            this.btnInserirMoeda.UseVisualStyleBackColor = true;
            this.btnInserirMoeda.Click += new System.EventHandler(this.btnInserirMoeda_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(319, 159);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Informe o Valor:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(12, 185);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(136, 40);
            this.btnDesligar.TabIndex = 12;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(168, 185);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(136, 40);
            this.btnComprar.TabIndex = 13;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnTroco
            // 
            this.btnTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroco.Location = new System.Drawing.Point(319, 185);
            this.btnTroco.Name = "btnTroco";
            this.btnTroco.Size = new System.Drawing.Size(136, 40);
            this.btnTroco.TabIndex = 14;
            this.btnTroco.Text = "Retirar Troco";
            this.btnTroco.UseVisualStyleBackColor = true;
            this.btnTroco.Click += new System.EventHandler(this.btnTroco_Click);
            // 
            // rtbRelatorio
            // 
            this.rtbRelatorio.Location = new System.Drawing.Point(12, 282);
            this.rtbRelatorio.Name = "rtbRelatorio";
            this.rtbRelatorio.Size = new System.Drawing.Size(443, 96);
            this.rtbRelatorio.TabIndex = 15;
            this.rtbRelatorio.Text = "";
            this.rtbRelatorio.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Relatório:";
            // 
            // frmMaquinaCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 390);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbRelatorio);
            this.Controls.Add(this.btnTroco);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnInserirMoeda);
            this.Controls.Add(this.txtPainel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorInserido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdeVendida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtValorCafe);
            this.Name = "frmMaquinaCafe";
            this.Text = "Máquina de Café";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorCafe;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdeVendida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorInserido;
        private System.Windows.Forms.TextBox txtPainel;
        private System.Windows.Forms.Button btnInserirMoeda;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnTroco;
        private System.Windows.Forms.RichTextBox rtbRelatorio;
        private System.Windows.Forms.Label label5;
    }
}

