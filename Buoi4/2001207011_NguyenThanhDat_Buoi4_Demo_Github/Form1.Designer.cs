﻿namespace _2001207011_NguyenThanhDat_Buoi4_Demo_Github
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
            this.userControl_Test1 = new ChucNang.UserControl_Test();
            this.SuspendLayout();
            // 
            // userControl_Test1
            // 
            this.userControl_Test1.Location = new System.Drawing.Point(137, 43);
            this.userControl_Test1.Name = "userControl_Test1";
            this.userControl_Test1.Size = new System.Drawing.Size(420, 218);
            this.userControl_Test1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.Controls.Add(this.userControl_Test1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ChucNang.UserControl_Test userControl_Test1;
    }
}

