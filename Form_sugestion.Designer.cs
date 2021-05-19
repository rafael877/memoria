
namespace teste_com_gunaUI
{
    partial class Form_sugestion
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
            this.btn_baixar = new Guna.UI2.WinForms.Guna2Button();
            this.memoria_Ram = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_confiavel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_virus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_fecharVirus = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fecharVirus)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_baixar
            // 
            this.btn_baixar.Animated = true;
            this.btn_baixar.AutoRoundedCorners = true;
            this.btn_baixar.BorderRadius = 22;
            this.btn_baixar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_baixar.CheckedState.Parent = this.btn_baixar;
            this.btn_baixar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_baixar.CustomImages.Parent = this.btn_baixar;
            this.btn_baixar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btn_baixar.ForeColor = System.Drawing.Color.White;
            this.btn_baixar.HoverState.Parent = this.btn_baixar;
            this.btn_baixar.Location = new System.Drawing.Point(115, 86);
            this.btn_baixar.Name = "btn_baixar";
            this.btn_baixar.ShadowDecoration.Parent = this.btn_baixar;
            this.btn_baixar.Size = new System.Drawing.Size(212, 47);
            this.btn_baixar.TabIndex = 0;
            this.btn_baixar.Text = "Baixar 20T ";
            this.btn_baixar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // memoria_Ram
            // 
            this.memoria_Ram.BackColor = System.Drawing.Color.Transparent;
            this.memoria_Ram.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoria_Ram.Location = new System.Drawing.Point(42, 37);
            this.memoria_Ram.Name = "memoria_Ram";
            this.memoria_Ram.Size = new System.Drawing.Size(365, 29);
            this.memoria_Ram.TabIndex = 1;
            this.memoria_Ram.Text = "Clique aqui para baixar memória ram  ";
            // 
            // lbl_confiavel
            // 
            this.lbl_confiavel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confiavel.Location = new System.Drawing.Point(181, 139);
            this.lbl_confiavel.Name = "lbl_confiavel";
            this.lbl_confiavel.Size = new System.Drawing.Size(78, 15);
            this.lbl_confiavel.TabIndex = 2;
            this.lbl_confiavel.Text = "99,8% confiável";
            // 
            // btn_virus
            // 
            this.btn_virus.Animated = true;
            this.btn_virus.AutoRoundedCorners = true;
            this.btn_virus.BorderRadius = 18;
            this.btn_virus.CheckedState.Parent = this.btn_virus;
            this.btn_virus.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_virus.CustomImages.Parent = this.btn_virus;
            this.btn_virus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(14)))));
            this.btn_virus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_virus.ForeColor = System.Drawing.Color.White;
            this.btn_virus.HoverState.Parent = this.btn_virus;
            this.btn_virus.IndicateFocus = true;
            this.btn_virus.Location = new System.Drawing.Point(145, 258);
            this.btn_virus.Name = "btn_virus";
            this.btn_virus.ShadowDecoration.Parent = this.btn_virus;
            this.btn_virus.Size = new System.Drawing.Size(146, 38);
            this.btn_virus.TabIndex = 3;
            this.btn_virus.Text = "Sair e pegar vírus";
            this.btn_virus.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_fecharVirus
            // 
            this.btn_fecharVirus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fecharVirus.Image = global::teste_com_gunaUI.Properties.Resources.troll2;
            this.btn_fecharVirus.Location = new System.Drawing.Point(-3, 271);
            this.btn_fecharVirus.Name = "btn_fecharVirus";
            this.btn_fecharVirus.ShadowDecoration.Parent = this.btn_fecharVirus;
            this.btn_fecharVirus.Size = new System.Drawing.Size(77, 37);
            this.btn_fecharVirus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_fecharVirus.TabIndex = 4;
            this.btn_fecharVirus.TabStop = false;
            this.btn_fecharVirus.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // Form_sugestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 308);
            this.Controls.Add(this.btn_fecharVirus);
            this.Controls.Add(this.btn_virus);
            this.Controls.Add(this.lbl_confiavel);
            this.Controls.Add(this.memoria_Ram);
            this.Controls.Add(this.btn_baixar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_sugestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btn_fecharVirus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_baixar;
        private Guna.UI2.WinForms.Guna2HtmlLabel memoria_Ram;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_confiavel;
        private Guna.UI2.WinForms.Guna2Button btn_virus;
        private Guna.UI2.WinForms.Guna2PictureBox btn_fecharVirus;
    }
}

