﻿namespace Vektorel.Windows.KacanButonApp
{
    partial class frmOyun
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
            this.btnKac = new System.Windows.Forms.Button();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnKac
            // 
            this.btnKac.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnKac.Location = new System.Drawing.Point(108, 83);
            this.btnKac.Name = "btnKac";
            this.btnKac.Size = new System.Drawing.Size(86, 79);
            this.btnKac.TabIndex = 0;
            this.btnKac.Text = "0";
            this.btnKac.UseVisualStyleBackColor = true;
            this.btnKac.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.TmrSure_Tick);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnKac);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKac;
        private System.Windows.Forms.Timer tmrSure;
    }
}