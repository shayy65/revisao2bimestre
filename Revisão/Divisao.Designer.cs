namespace Revisão
{
    partial class Divisao
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
            this.bt_calcular = new System.Windows.Forms.Button();
            this.tx_valor2 = new System.Windows.Forms.TextBox();
            this.tx_valor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(55, 268);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(135, 47);
            this.bt_calcular.TabIndex = 9;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // tx_valor2
            // 
            this.tx_valor2.Location = new System.Drawing.Point(36, 188);
            this.tx_valor2.Name = "tx_valor2";
            this.tx_valor2.Size = new System.Drawing.Size(189, 22);
            this.tx_valor2.TabIndex = 8;
            this.tx_valor2.TextChanged += new System.EventHandler(this.tx_valor2_TextChanged);
            // 
            // tx_valor1
            // 
            this.tx_valor1.Location = new System.Drawing.Point(36, 114);
            this.tx_valor1.Name = "tx_valor1";
            this.tx_valor1.Size = new System.Drawing.Size(189, 22);
            this.tx_valor1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Divisão";
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(146, 226);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(44, 16);
            this.lb_resultado.TabIndex = 11;
            this.lb_resultado.Text = "label2";
            this.lb_resultado.Click += new System.EventHandler(this.lb_resultado_Click);
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 336);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_valor2);
            this.Controls.Add(this.tx_valor1);
            this.Name = "Divisao";
            this.Text = "Divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.TextBox tx_valor2;
        private System.Windows.Forms.TextBox tx_valor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_resultado;
    }
}