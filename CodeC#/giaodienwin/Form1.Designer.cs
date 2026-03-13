using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace giaodienwin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_8 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.hienthi = new System.Windows.Forms.DataGridView();
            this.Btn6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bnt3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timkiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timkiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_8);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.hienthi);
            this.panel1.Controls.Add(this.Btn6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.Btn4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 433);
            this.panel1.TabIndex = 0;
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(9, 366);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(197, 38);
            this.btn_8.TabIndex = 12;
            this.btn_8.Text = "Thành viên";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(9, 363);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 41);
            this.panel8.TabIndex = 13;
            // 
            // hienthi
            // 
            this.hienthi.AutoGenerateColumns = false;
            this.hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hienthi.DataSource = this.timkiemBindingSource;
            this.hienthi.Location = new System.Drawing.Point(237, 3);
            this.hienthi.Name = "hienthi";
            this.hienthi.RowHeadersWidth = 51;
            this.hienthi.RowTemplate.Height = 24;
            this.hienthi.Size = new System.Drawing.Size(854, 397);
            this.hienthi.TabIndex = 10;
            this.hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(6, 253);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(197, 38);
            this.Btn6.TabIndex = 8;
            this.Btn6.Text = "Tìm hộ dân hết hạn tạm trú";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 250);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 41);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn5);
            this.panel6.Location = new System.Drawing.Point(6, 195);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 41);
            this.panel6.TabIndex = 7;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(3, 3);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(197, 38);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "Tìm kiếm hộ dân ";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(3, 307);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(197, 38);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "Danh sách hộ dân ";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 304);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 41);
            this.panel5.TabIndex = 5;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(9, 73);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(197, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "xóa hộ dân ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bnt3);
            this.panel4.Location = new System.Drawing.Point(6, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 41);
            this.panel4.TabIndex = 3;
            // 
            // bnt3
            // 
            this.bnt3.Location = new System.Drawing.Point(0, 3);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(197, 38);
            this.bnt3.TabIndex = 1;
            this.bnt3.Text = "chỉnh sửa hộ dân ";
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "thêm hộ dân ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timkiemBindingSource
            // 
            this.timkiemBindingSource.DataSource = typeof(giaodienwin.timkiem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 443);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timkiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var address = hienthi.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                var household = householdManager.GetAllHouseholds().FirstOrDefault(h => h.Address == address);
                var head = householdManager.GetHead(household.HeadId);

                using (var form = new Form())
                {
                    form.Text = $"Chi tiết hộ dân tại {address}";
                    form.Size = new System.Drawing.Size(400, 500);
                    form.StartPosition = FormStartPosition.CenterParent;

                    var textBox = new System.Windows.Forms.TextBox
                    {
                        Multiline = true,
                        ReadOnly = true,
                        ScrollBars = ScrollBars.Vertical,
                        Location = new System.Drawing.Point(10, 10),
                        Size = new System.Drawing.Size(360, 400),
                        Font = new Font("Arial", 10)
                    };

                    // Collect details as a string
                    var detailsBuilder = new StringBuilder();
                    detailsBuilder.AppendLine(household.Display());
                    detailsBuilder.AppendLine("\nChủ hộ:");
                    detailsBuilder.AppendLine(head.Display());
                    if (household.MemberIds.Count > 0)
                    {
                        detailsBuilder.AppendLine("\nThành viên:");
                        foreach (var memId in household.MemberIds)
                        {
                            var member = householdManager.GetMember(memId);
                            if (member != null)
                                detailsBuilder.AppendLine(member.Display());
                        }
                    }

                    textBox.Text = detailsBuilder.ToString();
                    form.Controls.Add(textBox);
                    form.ShowDialog();
                }
            }
        }
        

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Panel panel5;
        private Button btn_8;
        private Panel panel8;
        private DataGridView hienthi;
        private BindingSource timkiemBindingSource;
    }
}

