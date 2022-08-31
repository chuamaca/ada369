
namespace Ada369Csharp.Presentacion.Prueba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.PanelUsuarios = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PdeCarga = new System.Windows.Forms.PictureBox();
            this.PanelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdeCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(379, 150);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(200, 100);
            this.guna2ShadowPanel1.TabIndex = 627;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(63, 128);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(200, 200);
            this.guna2CustomGradientPanel1.TabIndex = 630;
            // 
            // PanelUsuarios
            // 
            this.PanelUsuarios.Controls.Add(this.label3);
            this.PanelUsuarios.Controls.Add(this.flowLayoutPanel1);
            this.PanelUsuarios.Location = new System.Drawing.Point(726, 91);
            this.PanelUsuarios.Name = "PanelUsuarios";
            this.PanelUsuarios.Size = new System.Drawing.Size(259, 296);
            this.PanelUsuarios.TabIndex = 637;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 633;
            this.label3.Text = "Quien esta Iniciando Sesion";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 206);
            this.flowLayoutPanel1.TabIndex = 634;
            // 
            // PdeCarga
            // 
            this.PdeCarga.BackColor = System.Drawing.Color.White;
            this.PdeCarga.Image = ((System.Drawing.Image)(resources.GetObject("PdeCarga.Image")));
            this.PdeCarga.Location = new System.Drawing.Point(726, 408);
            this.PdeCarga.Name = "PdeCarga";
            this.PdeCarga.Size = new System.Drawing.Size(245, 200);
            this.PdeCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PdeCarga.TabIndex = 636;
            this.PdeCarga.TabStop = false;
            this.PdeCarga.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 710);
            this.Controls.Add(this.PanelUsuarios);
            this.Controls.Add(this.PdeCarga);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelUsuarios.ResumeLayout(false);
            this.PanelUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdeCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel PanelUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.PictureBox PdeCarga;
    }
}