namespace proj
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.hienthi = new System.Windows.Forms.DataGridView();
            this.hienthi1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthi1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(551, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 92);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "hiển thị danh sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hienthi
            // 
            this.hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hienthi.Location = new System.Drawing.Point(3, 110);
            this.hienthi.Name = "hienthi";
            this.hienthi.RowHeadersWidth = 51;
            this.hienthi.RowTemplate.Height = 24;
            this.hienthi.Size = new System.Drawing.Size(1277, 205);
            this.hienthi.TabIndex = 1;
            this.hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hienthi1
            // 
            this.hienthi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hienthi1.Location = new System.Drawing.Point(3, 321);
            this.hienthi1.Name = "hienthi1";
            this.hienthi1.RowHeadersWidth = 51;
            this.hienthi1.RowTemplate.Height = 24;
            this.hienthi1.Size = new System.Drawing.Size(1277, 326);
            this.hienthi1.TabIndex = 2;
            this.hienthi1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hienthi1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 646);
            this.Controls.Add(this.hienthi1);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthi1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView hienthi;
        private System.Windows.Forms.DataGridView hienthi1;
    }
}

