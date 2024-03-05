namespace DataTesting2
{
    partial class PlayerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayBT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBT)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlLabel
            // 
            this.ControlLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlLabel.Location = new System.Drawing.Point(15, 10);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(253, 70);
            this.ControlLabel.TabIndex = 2;
            this.ControlLabel.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DataTesting2.Properties.Resources.Delete;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(284, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PlayBT
            // 
            this.PlayBT.BackgroundImage = global::DataTesting2.Properties.Resources.Play1;
            this.PlayBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBT.Location = new System.Drawing.Point(369, 10);
            this.PlayBT.Name = "PlayBT";
            this.PlayBT.Size = new System.Drawing.Size(70, 70);
            this.PlayBT.TabIndex = 4;
            this.PlayBT.TabStop = false;
            this.PlayBT.Click += new System.EventHandler(this.pictureBox1_Click);
            this.PlayBT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayBT_MouseDown);
            this.PlayBT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayBT_MouseUp);
            // 
            // PlayerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PlayBT);
            this.Controls.Add(this.ControlLabel);
            this.Name = "PlayerUserControl";
            this.Size = new System.Drawing.Size(454, 91);
            this.Load += new System.EventHandler(this.PlayerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.PictureBox PlayBT;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
