namespace DataTesting2
{
    partial class Media
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SignOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Upload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.StopBT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 269);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // SignOut
            // 
            this.SignOut.Location = new System.Drawing.Point(277, 296);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(95, 38);
            this.SignOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignOut.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.SignOut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignOut.StateCommon.Border.Rounding = 20;
            this.SignOut.TabIndex = 13;
            this.SignOut.Values.Text = "Sign Out";
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(12, 296);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(95, 38);
            this.Upload.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Upload.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.Upload.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Upload.StateCommon.Border.Rounding = 20;
            this.Upload.TabIndex = 14;
            this.Upload.Values.Text = "Upload";
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(378, 296);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 38);
            this.Exit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.Exit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Exit.StateCommon.Border.Rounding = 20;
            this.Exit.TabIndex = 15;
            this.Exit.Values.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(113, 296);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(95, 38);
            this.StopBT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StopBT.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.StopBT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StopBT.StateCommon.Border.Rounding = 20;
            this.StopBT.TabIndex = 16;
            this.StopBT.Values.Text = "Stop Audio";
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 346);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.SignOut);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Media";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SignOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Upload;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Exit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton StopBT;
    }
}

