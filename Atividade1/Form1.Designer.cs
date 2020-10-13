namespace Atividade1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNumeroInicial = new System.Windows.Forms.TextBox();
            this.tbNumeroFinal = new System.Windows.Forms.TextBox();
            this.jbSortear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSorteio = new System.Windows.Forms.ListBox();
            this.SORTEADOR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumeroInicial
            // 
            this.tbNumeroInicial.Location = new System.Drawing.Point(103, 116);
            this.tbNumeroInicial.Name = "tbNumeroInicial";
            this.tbNumeroInicial.Size = new System.Drawing.Size(147, 22);
            this.tbNumeroInicial.TabIndex = 0;
            this.tbNumeroInicial.TextChanged += new System.EventHandler(this.tbNumeroInicial_TextChanged);
            // 
            // tbNumeroFinal
            // 
            this.tbNumeroFinal.Location = new System.Drawing.Point(446, 116);
            this.tbNumeroFinal.Name = "tbNumeroFinal";
            this.tbNumeroFinal.Size = new System.Drawing.Size(147, 22);
            this.tbNumeroFinal.TabIndex = 1;
            this.tbNumeroFinal.TextChanged += new System.EventHandler(this.tbNumeroFinal_TextChanged);
            // 
            // jbSortear
            // 
            this.jbSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jbSortear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.jbSortear.Location = new System.Drawing.Point(285, 154);
            this.jbSortear.Name = "jbSortear";
            this.jbSortear.Size = new System.Drawing.Size(123, 45);
            this.jbSortear.TabIndex = 2;
            this.jbSortear.Text = "Sortear";
            this.jbSortear.UseVisualStyleBackColor = true;
            this.jbSortear.Click += new System.EventHandler(this.jbSortear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero Final";
            // 
            // lbSorteio
            // 
            this.lbSorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSorteio.FormattingEnabled = true;
            this.lbSorteio.ItemHeight = 42;
            this.lbSorteio.Location = new System.Drawing.Point(103, 232);
            this.lbSorteio.Name = "lbSorteio";
            this.lbSorteio.Size = new System.Drawing.Size(490, 88);
            this.lbSorteio.TabIndex = 5;
            // 
            // SORTEADOR
            // 
            this.SORTEADOR.AutoSize = true;
            this.SORTEADOR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SORTEADOR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SORTEADOR.Location = new System.Drawing.Point(198, 9);
            this.SORTEADOR.Name = "SORTEADOR";
            this.SORTEADOR.Size = new System.Drawing.Size(280, 46);
            this.SORTEADOR.TabIndex = 6;
            this.SORTEADOR.Text = "SORTEADOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 403);
            this.Controls.Add(this.SORTEADOR);
            this.Controls.Add(this.lbSorteio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jbSortear);
            this.Controls.Add(this.tbNumeroFinal);
            this.Controls.Add(this.tbNumeroInicial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeroInicial;
        private System.Windows.Forms.TextBox tbNumeroFinal;
        private System.Windows.Forms.Button jbSortear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSorteio;
        private System.Windows.Forms.Label SORTEADOR;
    }
}

