namespace recuperaçao_2
{
    partial class btnCalculo
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
            this.rbHomem = new System.Windows.Forms.RadioButton();
            this.rbMulher = new System.Windows.Forms.RadioButton();
            this.txtAlturaH = new System.Windows.Forms.TextBox();
            this.txtAlturaM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesoH = new System.Windows.Forms.TextBox();
            this.txtPesoM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbHomem
            // 
            this.rbHomem.AutoSize = true;
            this.rbHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHomem.Location = new System.Drawing.Point(169, 67);
            this.rbHomem.Name = "rbHomem";
            this.rbHomem.Size = new System.Drawing.Size(103, 29);
            this.rbHomem.TabIndex = 0;
            this.rbHomem.TabStop = true;
            this.rbHomem.Text = "Homem";
            this.rbHomem.UseVisualStyleBackColor = true;
            // 
            // rbMulher
            // 
            this.rbMulher.AutoSize = true;
            this.rbMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMulher.Location = new System.Drawing.Point(495, 67);
            this.rbMulher.Name = "rbMulher";
            this.rbMulher.Size = new System.Drawing.Size(96, 29);
            this.rbMulher.TabIndex = 1;
            this.rbMulher.TabStop = true;
            this.rbMulher.Text = "Mulher";
            this.rbMulher.UseVisualStyleBackColor = true;
            // 
            // txtAlturaH
            // 
            this.txtAlturaH.Location = new System.Drawing.Point(169, 150);
            this.txtAlturaH.Name = "txtAlturaH";
            this.txtAlturaH.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaH.TabIndex = 2;
            // 
            // txtAlturaM
            // 
            this.txtAlturaM.Location = new System.Drawing.Point(508, 150);
            this.txtAlturaM.Name = "txtAlturaM";
            this.txtAlturaM.Size = new System.Drawing.Size(100, 20);
            this.txtAlturaM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "altura";
            // 
            // txtPesoH
            // 
            this.txtPesoH.Location = new System.Drawing.Point(169, 223);
            this.txtPesoH.Name = "txtPesoH";
            this.txtPesoH.Size = new System.Drawing.Size(100, 20);
            this.txtPesoH.TabIndex = 6;
            // 
            // txtPesoM
            // 
            this.txtPesoM.Location = new System.Drawing.Point(508, 236);
            this.txtPesoM.Name = "txtPesoM";
            this.txtPesoM.Size = new System.Drawing.Size(100, 20);
            this.txtPesoM.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "peso";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(303, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 41);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcularH_Click);
            // 
            // btnCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPesoM);
            this.Controls.Add(this.txtPesoH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlturaM);
            this.Controls.Add(this.txtAlturaH);
            this.Controls.Add(this.rbMulher);
            this.Controls.Add(this.rbHomem);
            this.Name = "btnCalculo";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbHomem;
        private System.Windows.Forms.RadioButton rbMulher;
        private System.Windows.Forms.TextBox txtAlturaH;
        private System.Windows.Forms.TextBox txtAlturaM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesoH;
        private System.Windows.Forms.TextBox txtPesoM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

