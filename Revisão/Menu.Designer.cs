namespace Revisão
{
    partial class Menu
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
            this.bt_divisao = new System.Windows.Forms.Button();
            this.rdbt_feminino = new System.Windows.Forms.RadioButton();
            this.rdbt_masculino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_divisao
            // 
            this.bt_divisao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_divisao.Location = new System.Drawing.Point(52, 70);
            this.bt_divisao.Name = "bt_divisao";
            this.bt_divisao.Size = new System.Drawing.Size(171, 77);
            this.bt_divisao.TabIndex = 0;
            this.bt_divisao.Text = "Divisão";
            this.bt_divisao.UseVisualStyleBackColor = false;
            this.bt_divisao.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbt_feminino
            // 
            this.rdbt_feminino.AutoSize = true;
            this.rdbt_feminino.Location = new System.Drawing.Point(52, 12);
            this.rdbt_feminino.Name = "rdbt_feminino";
            this.rdbt_feminino.Size = new System.Drawing.Size(83, 20);
            this.rdbt_feminino.TabIndex = 1;
            this.rdbt_feminino.TabStop = true;
            this.rdbt_feminino.Text = "Feminino";
            this.rdbt_feminino.UseVisualStyleBackColor = true;
            // 
            // rdbt_masculino
            // 
            this.rdbt_masculino.AutoSize = true;
            this.rdbt_masculino.Location = new System.Drawing.Point(52, 38);
            this.rdbt_masculino.Name = "rdbt_masculino";
            this.rdbt_masculino.Size = new System.Drawing.Size(89, 20);
            this.rdbt_masculino.TabIndex = 2;
            this.rdbt_masculino.TabStop = true;
            this.rdbt_masculino.Text = "Masculino";
            this.rdbt_masculino.UseVisualStyleBackColor = true;
            this.rdbt_masculino.CheckedChanged += new System.EventHandler(this.rdbt_masculino_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "botão 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbt_masculino);
            this.Controls.Add(this.rdbt_feminino);
            this.Controls.Add(this.bt_divisao);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_divisao;
        private System.Windows.Forms.RadioButton rdbt_feminino;
        private System.Windows.Forms.RadioButton rdbt_masculino;
        private System.Windows.Forms.Button button1;
    }
}

