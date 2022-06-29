namespace Calcular_a_area_do_triangulo
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
            this.imagemcalculo = new System.Windows.Forms.PictureBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtalaltura = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lalALTURA = new System.Windows.Forms.Label();
            this.laLbBASE = new System.Windows.Forms.Label();
            this.bTMCALCULAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagemcalculo)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemcalculo
            // 
            this.imagemcalculo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imagemcalculo.Image = global::Calcular_a_area_do_triangulo.Properties.Resources.como_calcular_a_area_de_um_triangulo_15787_paso_1_600__1_;
            this.imagemcalculo.Location = new System.Drawing.Point(12, 12);
            this.imagemcalculo.Name = "imagemcalculo";
            this.imagemcalculo.Size = new System.Drawing.Size(523, 326);
            this.imagemcalculo.TabIndex = 0;
            this.imagemcalculo.TabStop = false;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(318, 387);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(217, 20);
            this.txtbase.TabIndex = 1;
            // 
            // txtalaltura
            // 
            this.txtalaltura.Location = new System.Drawing.Point(318, 449);
            this.txtalaltura.Name = "txtalaltura";
            this.txtalaltura.Size = new System.Drawing.Size(217, 20);
            this.txtalaltura.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(599, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 118);
            this.textBox1.TabIndex = 3;
            // 
            // lalALTURA
            // 
            this.lalALTURA.AutoSize = true;
            this.lalALTURA.Location = new System.Drawing.Point(245, 390);
            this.lalALTURA.Name = "lalALTURA";
            this.lalALTURA.Size = new System.Drawing.Size(67, 13);
            this.lalALTURA.TabIndex = 4;
            this.lalALTURA.Text = "ALTURA(H):";
            // 
            // laLbBASE
            // 
            this.laLbBASE.AutoSize = true;
            this.laLbBASE.Location = new System.Drawing.Point(261, 449);
            this.laLbBASE.Name = "laLbBASE";
            this.laLbBASE.Size = new System.Drawing.Size(51, 13);
            this.laLbBASE.TabIndex = 5;
            this.laLbBASE.Text = "BASE(B):";
            // 
            // bTMCALCULAR
            // 
            this.bTMCALCULAR.Location = new System.Drawing.Point(333, 504);
            this.bTMCALCULAR.Name = "bTMCALCULAR";
            this.bTMCALCULAR.Size = new System.Drawing.Size(189, 23);
            this.bTMCALCULAR.TabIndex = 6;
            this.bTMCALCULAR.Text = "CALCULAR";
            this.bTMCALCULAR.UseVisualStyleBackColor = true;
            this.bTMCALCULAR.Click += new System.EventHandler(this.bTMCALCULAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 668);
            this.Controls.Add(this.bTMCALCULAR);
            this.Controls.Add(this.laLbBASE);
            this.Controls.Add(this.lalALTURA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtalaltura);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.imagemcalculo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagemcalculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagemcalculo;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtalaltura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lalALTURA;
        private System.Windows.Forms.Label laLbBASE;
        private System.Windows.Forms.Button bTMCALCULAR;
    }
}

