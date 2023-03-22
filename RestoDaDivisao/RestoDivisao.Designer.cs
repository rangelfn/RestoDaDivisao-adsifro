
namespace RestoDaDivisao
{
    partial class RestoDivisao
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
            this.lblResto = new System.Windows.Forms.Label();
            this.txtRestoDaDivisao = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txBxDivisor = new System.Windows.Forms.TextBox();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.txBxDividendo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResto.Location = new System.Drawing.Point(7, 116);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(52, 20);
            this.lblResto.TabIndex = 27;
            this.lblResto.Text = "Resto";
            // 
            // txtRestoDaDivisao
            // 
            this.txtRestoDaDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoDaDivisao.Location = new System.Drawing.Point(92, 113);
            this.txtRestoDaDivisao.Name = "txtRestoDaDivisao";
            this.txtRestoDaDivisao.Size = new System.Drawing.Size(116, 26);
            this.txtRestoDaDivisao.TabIndex = 26;
            this.txtRestoDaDivisao.TextChanged += new System.EventHandler(this.txtRestoDaDivisao_TextChanged);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(10, 76);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(198, 31);
            this.btnDividir.TabIndex = 25;
            this.btnDividir.Text = "Realizar Divisão";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.Location = new System.Drawing.Point(7, 47);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(56, 20);
            this.lblDivisor.TabIndex = 24;
            this.lblDivisor.Text = "Divisor";
            // 
            // txBxDivisor
            // 
            this.txBxDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDivisor.Location = new System.Drawing.Point(92, 44);
            this.txBxDivisor.Name = "txBxDivisor";
            this.txBxDivisor.Size = new System.Drawing.Size(116, 26);
            this.txBxDivisor.TabIndex = 23;
            this.txBxDivisor.TextChanged += new System.EventHandler(this.txBxDivisor_TextChanged);
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividendo.Location = new System.Drawing.Point(7, 15);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(79, 20);
            this.lblDividendo.TabIndex = 22;
            this.lblDividendo.Text = "Dividendo";
            // 
            // txBxDividendo
            // 
            this.txBxDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBxDividendo.Location = new System.Drawing.Point(92, 12);
            this.txBxDividendo.Name = "txBxDividendo";
            this.txBxDividendo.Size = new System.Drawing.Size(116, 26);
            this.txBxDividendo.TabIndex = 21;
            this.txBxDividendo.TextChanged += new System.EventHandler(this.txBxDividendo_TextChanged);
            // 
            // RestoDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 157);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.txtRestoDaDivisao);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txBxDivisor);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.txBxDividendo);
            this.Name = "RestoDivisao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.TextBox txtRestoDaDivisao;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txBxDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.TextBox txBxDividendo;
    }
}

