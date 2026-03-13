using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static giaodienwin.FamilyMember;

namespace giaodienwin
{
    public partial class Form1 : Form
    {
        private HouseholdManager householdManager;
        private List<Household> households;

        public object Helpers { get; private set; }

        public Form1()
        {
            InitializeComponent();
            householdManager = new HouseholdManager();
            households = householdManager.GetAllHouseholds();
            SetupDataGridView();
            LoadHouseholds();
            
        }

        private void SetupDataGridView()
        {
            hienthi.Columns.Clear();
            hienthi.Columns.Add("Address", "Địa chỉ");
            hienthi.Columns.Add("Type", "Loại hộ");
            hienthi.Columns.Add("HeadId", "ID Chủ hộ");
            hienthi.Columns.Add("SpecialStatus", "Trạng thái đặc biệt");
            hienthi.Columns.Add("ExpiryDate", "Ngày hết hạn (Tạm trú)");

            // Tùy chỉnh giao diện DataGridView
            hienthi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienthi.ReadOnly = true;
            hienthi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hienthi.MultiSelect = false;
            hienthi.BackgroundColor = Color.White;
            hienthi.DefaultCellStyle.Font = new Font("Arial", 10);
            hienthi.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            hienthi.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            hienthi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            hienthi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            hienthi.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            hienthi.DefaultCellStyle.SelectionForeColor = Color.Black;
            hienthi.AllowUserToAddRows = false;
        }

        private void LoadHouseholds()
        {
            hienthi.Rows.Clear();
            foreach (var household in householdManager.GetAllHouseholds())
            {
                // Replace the recursive pattern matching with a more compatible approach
                string statusDisplay;
                switch (household.SpecialStatus)
                {
                    case SpecialStatus.None:
                        statusDisplay = "Không có";
                        break;
                    case SpecialStatus.NearPoor:
                        statusDisplay = "Cận nghèo";
                        break;
                    case SpecialStatus.Poor:
                        statusDisplay = "Nghèo";
                        break;
                    default:
                        statusDisplay = "Không xác định";
                        break;
                }

                // Check if the household is of type TemporaryHousehold
                string expiryDate = household is TemporaryHousehold temp
                    ? temp.GetExpiryDate().ToString()
                    : "";

                // Determine the type of household
                string typeDisplay = household.GetType() == "Permanent" ? "Thường trú" : "Tạm trú";

                // Add the row to the DataGridView
                hienthi.Rows.Add(
                    household.Address,
                    typeDisplay,
                    household.HeadId,
                    statusDisplay,
                    expiryDate
                );
            }
        }
        public static class Person
        {
            public static HashSet<string> usedIds = new HashSet<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {
                form.Text = "Thêm hộ dân";
                form.Size = new System.Drawing.Size(300, 600);
                form.StartPosition = FormStartPosition.CenterParent;

                var typeLabel = new Label { Text = "Loại hộ:", Location = new System.Drawing.Point(10, 10), Width = 100 };
                var typeComboBox = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(110, 10), Width = 150 };
                typeComboBox.Items.AddRange(new object[] { "Thường trú", "Tạm trú" });
                typeComboBox.SelectedIndex = 0;

                var addressLabel = new Label { Text = "Địa chỉ:", Location = new System.Drawing.Point(10, 40), Width = 100 };
                var addressTextBox = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 40), Width = 150 };

                var headNameLabel = new Label { Text = "Tên chủ hộ:", Location = new System.Drawing.Point(10, 70), Width = 100 };
                var headNameTextBox = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 70), Width = 150 };
                var headDobLabel = new Label { Text = "Ngày sinh:", Location = new System.Drawing.Point(10, 100), Width = 100 };
                var headDobPicker = new DateTimePicker { Location = new System.Drawing.Point(110, 100), Width = 150 };
                var headIdLabel = new Label { Text = "ID Chủ hộ:", Location = new System.Drawing.Point(10, 130), Width = 100 };
                var headIdTextBox = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 130), Width = 150 };
                var headGenderLabel = new Label { Text = "Giới tính:", Location = new System.Drawing.Point(10, 160), Width = 100 };
                var headGenderComboBox = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(110, 160), Width = 150 };
                headGenderComboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
                headGenderComboBox.SelectedIndex = 0;

                var statusLabel = new Label { Text = "Trạng thái:", Location = new System.Drawing.Point(10, 190), Width = 100 };
                var statusComboBox = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(110, 190), Width = 150 };
                statusComboBox.Items.AddRange(new object[] { "None", "NearPoor", "Poor" });
                statusComboBox.SelectedIndex = 0;

                var expiryLabel = new Label { Text = "Hết hạn:", Location = new System.Drawing.Point(10, 220), Width = 100 };
                var expiryPicker = new DateTimePicker { Location = new System.Drawing.Point(110, 220), Width = 150, Enabled = false };
                typeComboBox.SelectedIndexChanged += (s, ev) =>
                {
                    expiryPicker.Enabled = typeComboBox.SelectedItem.ToString() == "Tạm trú";
                };

                var numMembersLabel = new Label { Text = "Số thành viên:", Location = new System.Drawing.Point(10, 250), Width = 100 };
                var numMembersTextBox = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(110, 250), Width = 150 };
                var membersPanel = new Panel { Location = new System.Drawing.Point(10, 280), Size = new System.Drawing.Size(260, 200), AutoScroll = true };
                var membersControls = new List<(System.Windows.Forms.TextBox id, System.Windows.Forms.ComboBox relationship)>();

                numMembersTextBox.TextChanged += (s, ev) =>
                {
                    membersPanel.Controls.Clear();
                    membersControls.Clear();
                    if (int.TryParse(numMembersTextBox.Text, out int num) && num > 0)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            var idLabel = new Label { Text = $"ID Thành viên {i + 1}:", Location = new System.Drawing.Point(0, i * 60), Width = 100 };
                            var idTextBox = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(100, i * 60), Width = 150 };
                            var relLabel = new Label { Text = "Quan hệ:", Location = new System.Drawing.Point(0, i * 60 + 30), Width = 100 };
                            var relComboBox = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(100, i * 60 + 30), Width = 150 };
                            relComboBox.Items.AddRange(new object[] { "Spouse", "Child", "Parent", "Sibling", "None" });
                            relComboBox.SelectedIndex = 0;

                            membersPanel.Controls.Add(idLabel);
                            membersPanel.Controls.Add(idTextBox);
                            membersPanel.Controls.Add(relLabel);
                            membersPanel.Controls.Add(relComboBox);
                            membersControls.Add((idTextBox, relComboBox));
                        }
                    }
                };

                var saveButton = new System.Windows.Forms.Button { Text = "Lưu", Location = new System.Drawing.Point(110, 500), Width = 100 };
                saveButton.Click += (s, ev) =>
                {
                    try
                    {
                        string errorMsg;
                        if (!Helpers.uss(headIdTextBox.Text, Person.usedIds, out errorMsg))
                            throw new Exception(errorMsg);

                        var dob = new Date(headDobPicker.Value.Day, headDobPicker.Value.Month, headDobPicker.Value.Year);
                        if (dob.IsFuture())
                            throw new Exception("Ngày sinh không được là ngày tương lai!");
                        var head = new HouseholdHead(
                            headNameTextBox.Text,
                            dob,
                            headIdTextBox.Text,
                            (Gender)Enum.Parse(typeof(Gender), headGenderComboBox.SelectedItem.ToString())
                        );

                        var members = new List<FamilyMember>();
                        foreach (var (idTextBox, relComboBox) in membersControls)
                        {
                            if (!string.IsNullOrEmpty(idTextBox.Text))
                            {
                                if (!Helpers.IsValidIdNumber(idTextBox.Text, Person.usedIds, out errorMsg))
                                    throw new Exception(errorMsg);
                                var member = new FamilyMember(
                                    $"Thành viên {idTextBox.Text}",
                                    new Date(1, 1, 1990),
                                    idTextBox.Text,
                                    Gender.Other,
                                    (Relationship)Enum.Parse(typeof(Relationship), relComboBox.SelectedItem.ToString()),
                                    head.Id
                                );
                                members.Add(member);
                            }
                        }

                        Household household;
                        if (typeComboBox.SelectedItem.ToString() == "Thường trú")
                        {
                            household = new PermanentHousehold(
                                addressTextBox.Text,
                                head.Id,
                                new List<string>(),
                                (SpecialStatus)Enum.Parse(typeof(SpecialStatus), statusComboBox.SelectedItem.ToString())
                            );
                        }
                        else
                        {
                            var expiry = new Date(expiryPicker.Value.Day, expiryPicker.Value.Month, expiryPicker.Value.Year);
                            if (!expiry.IsFuture())
                                throw new Exception("Ngày hết hạn phải sau ngày hiện tại!");
                            household = new TemporaryHousehold(
                                addressTextBox.Text,
                                head.Id,
                                new List<string>(),
                                (SpecialStatus)Enum.Parse(typeof(SpecialStatus), statusComboBox.SelectedItem.ToString()),
                                expiry
                            );
                        }

                        householdManager.AddHousehold(household, head, members);
                        MessageBox.Show("Thêm hộ dân thành công!");
                        form.Close();
                        LoadHouseholds();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };

                form.Controls.Add(typeLabel);
                form.Controls.Add(typeComboBox);
                form.Controls.Add(addressLabel);
                form.Controls.Add(addressTextBox);
                form.Controls.Add(headNameLabel);
                form.Controls.Add(headNameTextBox);
                form.Controls.Add(headDobLabel);
                form.Controls.Add(headDobPicker);
                form.Controls.Add(headIdLabel);
                form.Controls.Add(headIdTextBox);
                form.Controls.Add(headGenderLabel);
                form.Controls.Add(headGenderComboBox);
                form.Controls.Add(statusLabel);
                form.Controls.Add(statusComboBox);
                form.Controls.Add(expiryLabel);
                form.Controls.Add(expiryPicker);
                form.Controls.Add(numMembersLabel);
                form.Controls.Add(numMembersTextBox);
                form.Controls.Add(membersPanel);
                form.Controls.Add(saveButton);

                form.ShowDialog();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "csv file|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        householdManager.LoadFromCsv(ofd.FileName);
                        LoadHouseholds();
                        MessageBox.Show("Đọc file CSV thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi đọc file CSV: {ex.Message}");
                    }
                }
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
        }

        


        private void btn_8_Click(object sender, EventArgs e)
        {

        }



    }
}