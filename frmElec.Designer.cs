﻿namespace QLDH
{
    partial class frmElec
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCS1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCS2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính tiền điện";
            // 
            // txtCS1
            // 
            this.txtCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCS1.Location = new System.Drawing.Point(192, 74);
            this.txtCS1.Name = "txtCS1";
            this.txtCS1.Size = new System.Drawing.Size(270, 36);
            this.txtCS1.TabIndex = 1;
            this.txtCS1.TextChanged += new System.EventHandler(this.txtCS1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chỉ số đầu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCS2
            // 
            this.txtCS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCS2.Location = new System.Drawing.Point(192, 130);
            this.txtCS2.Name = "txtCS2";
            this.txtCS2.Size = new System.Drawing.Size(270, 36);
            this.txtCS2.TabIndex = 3;
            this.txtCS2.TextChanged += new System.EventHandler(this.txtCS2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chỉ số cuối:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.Color.Red;
            this.lblKQ.Location = new System.Drawing.Point(34, 234);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(38, 31);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "   ";
            this.lblKQ.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tính hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmElec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCS2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCS1);
            this.Controls.Add(this.label1);
            this.Name = "frmElec";
            this.Text = "frmElec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCS1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button button1;
    }
}