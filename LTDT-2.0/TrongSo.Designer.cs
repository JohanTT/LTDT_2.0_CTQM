namespace LTDT_2._0
{
    partial class TrongSoForm
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
            this.TrongSotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DinhFrom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DinhTo = new System.Windows.Forms.Label();
            this.Taobtn = new System.Windows.Forms.Button();
            this.Huybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrongSotxt
            // 
            this.TrongSotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrongSotxt.Location = new System.Drawing.Point(115, 69);
            this.TrongSotxt.MaxLength = 4;
            this.TrongSotxt.Name = "TrongSotxt";
            this.TrongSotxt.Size = new System.Drawing.Size(83, 29);
            this.TrongSotxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trọng số từ đỉnh";
            // 
            // DinhFrom
            // 
            this.DinhFrom.AutoSize = true;
            this.DinhFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinhFrom.Location = new System.Drawing.Point(159, 11);
            this.DinhFrom.Name = "DinhFrom";
            this.DinhFrom.Size = new System.Drawing.Size(20, 24);
            this.DinhFrom.TabIndex = 2;
            this.DinhFrom.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "đến đỉnh";
            // 
            // DinhTo
            // 
            this.DinhTo.AutoSize = true;
            this.DinhTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinhTo.Location = new System.Drawing.Point(278, 11);
            this.DinhTo.Name = "DinhTo";
            this.DinhTo.Size = new System.Drawing.Size(20, 24);
            this.DinhTo.TabIndex = 2;
            this.DinhTo.Text = "0";
            // 
            // Taobtn
            // 
            this.Taobtn.Location = new System.Drawing.Point(49, 138);
            this.Taobtn.Name = "Taobtn";
            this.Taobtn.Size = new System.Drawing.Size(75, 23);
            this.Taobtn.TabIndex = 2;
            this.Taobtn.Text = "Tạo";
            this.Taobtn.UseVisualStyleBackColor = true;
            this.Taobtn.Click += new System.EventHandler(this.Taobtn_Click);
            // 
            // Huybtn
            // 
            this.Huybtn.Location = new System.Drawing.Point(198, 138);
            this.Huybtn.Name = "Huybtn";
            this.Huybtn.Size = new System.Drawing.Size(75, 23);
            this.Huybtn.TabIndex = 3;
            this.Huybtn.Text = "Huỷ";
            this.Huybtn.UseVisualStyleBackColor = true;
            this.Huybtn.Click += new System.EventHandler(this.Huybtn_Click);
            // 
            // TrongSoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 171);
            this.Controls.Add(this.Huybtn);
            this.Controls.Add(this.Taobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DinhTo);
            this.Controls.Add(this.DinhFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrongSotxt);
            this.Name = "TrongSoForm";
            this.Text = "TrongSo";
            this.Load += new System.EventHandler(this.TrongSo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TrongSotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DinhFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DinhTo;
        private System.Windows.Forms.Button Taobtn;
        private System.Windows.Forms.Button Huybtn;
    }
}