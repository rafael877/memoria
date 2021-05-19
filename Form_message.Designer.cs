
namespace teste_com_gunaUI
{
    partial class Form_message
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
            this.btn_maisVirus = new Guna.UI2.WinForms.Guna2Button();
            this.pb_erro = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_erro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_maisVirus
            // 
            this.btn_maisVirus.Animated = true;
            this.btn_maisVirus.AutoRoundedCorners = true;
            this.btn_maisVirus.BorderRadius = 15;
            this.btn_maisVirus.CheckedState.Parent = this.btn_maisVirus;
            this.btn_maisVirus.CustomImages.Parent = this.btn_maisVirus;
            this.btn_maisVirus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maisVirus.ForeColor = System.Drawing.Color.White;
            this.btn_maisVirus.HoverState.Parent = this.btn_maisVirus;
            this.btn_maisVirus.Location = new System.Drawing.Point(400, 332);
            this.btn_maisVirus.Name = "btn_maisVirus";
            this.btn_maisVirus.ShadowDecoration.Parent = this.btn_maisVirus;
            this.btn_maisVirus.Size = new System.Drawing.Size(90, 33);
            this.btn_maisVirus.TabIndex = 2;
            this.btn_maisVirus.Text = "fechar guia";
            this.btn_maisVirus.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pb_erro
            // 
            this.pb_erro.Image = global::teste_com_gunaUI.Properties.Resources.erro_kk;
            this.pb_erro.Location = new System.Drawing.Point(12, 12);
            this.pb_erro.Name = "pb_erro";
            this.pb_erro.ShadowDecoration.Parent = this.pb_erro;
            this.pb_erro.Size = new System.Drawing.Size(484, 302);
            this.pb_erro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_erro.TabIndex = 1;
            this.pb_erro.TabStop = false;
            this.pb_erro.Click += new System.EventHandler(this.pb_erro_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(223, 53);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(231, 26);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "erro  852";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(172, 223);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(147, 20);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "deletando sistem32";
            // 
            // Form_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(505, 379);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_maisVirus);
            this.Controls.Add(this.pb_erro);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_message";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pb_erro;
        private Guna.UI2.WinForms.Guna2Button btn_maisVirus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}