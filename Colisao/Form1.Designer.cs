namespace Colisao
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMsgGameOver = new System.Windows.Forms.Panel();
            this.lblMsgGameOver = new System.Windows.Forms.Label();
            this.pbMoeda = new System.Windows.Forms.PictureBox();
            this.pbMuro = new System.Windows.Forms.PictureBox();
            this.pbHeroi = new System.Windows.Forms.PictureBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.pnlMsgGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroi)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMsgGameOver
            // 
            this.pnlMsgGameOver.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMsgGameOver.Controls.Add(this.lblPontos);
            this.pnlMsgGameOver.Controls.Add(this.lblMsgGameOver);
            this.pnlMsgGameOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMsgGameOver.Location = new System.Drawing.Point(0, 0);
            this.pnlMsgGameOver.Name = "pnlMsgGameOver";
            this.pnlMsgGameOver.Size = new System.Drawing.Size(1076, 100);
            this.pnlMsgGameOver.TabIndex = 3;
            // 
            // lblMsgGameOver
            // 
            this.lblMsgGameOver.AutoSize = true;
            this.lblMsgGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgGameOver.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMsgGameOver.Location = new System.Drawing.Point(413, 28);
            this.lblMsgGameOver.Name = "lblMsgGameOver";
            this.lblMsgGameOver.Size = new System.Drawing.Size(132, 48);
            this.lblMsgGameOver.TabIndex = 0;
            this.lblMsgGameOver.Text = "label1";
            this.lblMsgGameOver.Visible = false;
            // 
            // pbMoeda
            // 
            this.pbMoeda.Image = global::Colisao.Properties.Resources.Moeda;
            this.pbMoeda.Location = new System.Drawing.Point(219, 423);
            this.pbMoeda.Name = "pbMoeda";
            this.pbMoeda.Size = new System.Drawing.Size(39, 33);
            this.pbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMoeda.TabIndex = 4;
            this.pbMoeda.TabStop = false;
            this.pbMoeda.Tag = "coletaveis";
            // 
            // pbMuro
            // 
            this.pbMuro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbMuro.Location = new System.Drawing.Point(782, 175);
            this.pbMuro.Name = "pbMuro";
            this.pbMuro.Size = new System.Drawing.Size(100, 295);
            this.pbMuro.TabIndex = 2;
            this.pbMuro.TabStop = false;
            this.pbMuro.Tag = "muro";
            // 
            // pbHeroi
            // 
            this.pbHeroi.Image = global::Colisao.Properties.Resources.RedGhost;
            this.pbHeroi.Location = new System.Drawing.Point(322, 281);
            this.pbHeroi.Name = "pbHeroi";
            this.pbHeroi.Size = new System.Drawing.Size(71, 63);
            this.pbHeroi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeroi.TabIndex = 0;
            this.pbHeroi.TabStop = false;
            this.pbHeroi.Tag = "";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPontos.Location = new System.Drawing.Point(29, 28);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(132, 48);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 752);
            this.Controls.Add(this.pbMoeda);
            this.Controls.Add(this.pnlMsgGameOver);
            this.Controls.Add(this.pbMuro);
            this.Controls.Add(this.pbHeroi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlMsgGameOver.ResumeLayout(false);
            this.pnlMsgGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeroi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeroi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMuro;
        private System.Windows.Forms.Panel pnlMsgGameOver;
        private System.Windows.Forms.Label lblMsgGameOver;
        private System.Windows.Forms.PictureBox pbMoeda;
        private System.Windows.Forms.Label lblPontos;
    }
}

