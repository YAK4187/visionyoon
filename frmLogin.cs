using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DOT_Number_Reading
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string password = txtPassword.Text.Trim();

            Console.WriteLine($"ID: {id}, Password: {password}"); // 디버깅용

            if (id == "icon" && password == "12345")
            {
                // MetroFramework 스타일의 메시지 박스
                MetroMessageBox.Show(this, "Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Invalid ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // MetroForm 스타일 및 테마 설정
            this.Style = MetroFramework.MetroColorStyle.Blue; // 스타일 설정
            this.Theme = MetroFramework.MetroThemeStyle.Light; // 테마 설정
        }
    }
}

