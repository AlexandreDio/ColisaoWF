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
            this.personagem = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMsgGameOver = new System.Windows.Forms.Panel();
            this.lblMsgGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMsgGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // personagem
            // 
            this.personagem.Image = global::Colisao.Properties.Resources.RedGhost;
            this.personagem.Location = new System.Drawing.Point(322, 250);
            this.personagem.Name = "personagem";
            this.personagem.Size = new System.Drawing.Size(100, 94);
            this.personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personagem.TabIndex = 0;
            this.personagem.TabStop = false;
            this.personagem.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(782, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 295);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "muro";
            // 
            // pnlMsgGameOver
            // 
            this.pnlMsgGameOver.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlMsgGameOver.Controls.Add(this.lblMsgGameOver);
            this.pnlMsgGameOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMsgGameOver.Location = new System.Drawing.Point(0, 0);
            this.pnlMsgGameOver.Name = "pnlMsgGameOver";
            this.pnlMsgGameOver.Size = new System.Drawing.Size(1076, 100);
            this.pnlMsgGameOver.TabIndex = 3;
            this.pnlMsgGameOver.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 752);
            this.Controls.Add(this.pnlMsgGameOver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.personagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMsgGameOver.ResumeLayout(false);
            this.pnlMsgGameOver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox personagem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMsgGameOver;
        private System.Windows.Forms.Label lblMsgGameOver;
    }
}

