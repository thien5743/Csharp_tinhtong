namespace Csharp_tinhtong
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
            this.lblso1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.lblso2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblso1
            // 
            this.lblso1.AutoSize = true;
            this.lblso1.Location = new System.Drawing.Point(112, 74);
            this.lblso1.Name = "lblso1";
            this.lblso1.Size = new System.Drawing.Size(31, 13);
            this.lblso1.TabIndex = 0;
            this.lblso1.Text = "SỐ 1";
            this.lblso1.Click += new System.EventHandler(this.so_Click);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(227, 67);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            this.txtso1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(350, 303);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(90, 48);
            this.btntinhtong.TabIndex = 6;
            this.btntinhtong.Text = "TÍNH TỔNG";
            this.btntinhtong.UseVisualStyleBackColor = true;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(227, 175);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 8;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(246, 229);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(54, 13);
            this.lblkq.TabIndex = 7;
            this.lblkq.Text = "KẾT QUẢ";
            this.lblkq.Click += new System.EventHandler(this.lblkq_Click);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(227, 117);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 10;
            // 
            // lblso2
            // 
            this.lblso2.AutoSize = true;
            this.lblso2.Location = new System.Drawing.Point(112, 124);
            this.lblso2.Name = "lblso2";
            this.lblso2.Size = new System.Drawing.Size(31, 13);
            this.lblso2.TabIndex = 9;
            this.lblso2.Text = "SỐ 2";
            this.lblso2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.lblso2);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.lblso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblso1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label lblso2;
    }
}

