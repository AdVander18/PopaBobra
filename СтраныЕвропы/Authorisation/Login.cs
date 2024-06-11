using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace СтраныЕвропы
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        private string captchaText;
        private Label lblCaptcha;
        private PictureBox pictureBoxCaptcha;
        private TextBox txtCaptcha;
        private bool isCaptchaDisplayed = false;
        private PrivateFontCollection privateFonts;

        private System.Timers.Timer timer;
        private bool isLocked = false;

        public Login()
        {
            InitializeComponent();
            LoadCustomFont();
            ConfigureForm();
            timer = new System.Timers.Timer(10000);
            timer.Elapsed += UnlockForm;
        }

        private void LoadCustomFont()
        {
            privateFonts = new PrivateFontCollection();

            using (Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("СтраныЕвропы.Resources.Bee_Honey_Regular.ttf"))
            {
                if (fontStream == null)
                {
                    throw new FileNotFoundException("Custom font not found in embedded resources.");
                }

                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, (int)fontStream.Length);

                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        private void ConfigureForm()
        {
            this.Text = "Авторизация";
            this.Size = new Size(200, 200);
            StartPosition = FormStartPosition.CenterScreen;

            lblCaptcha = new Label() { Text = "Введите CAPTCHA:", Location = new Point(10, 130), Visible = false };
            pictureBoxCaptcha = new PictureBox() { Location = new Point(10, 160), Size = new Size(120, 40), Visible = false };
            txtCaptcha = new TextBox() { Location = new Point(10, 210), Visible = false };

            Controls.Add(lblCaptcha);
            Controls.Add(pictureBoxCaptcha);
            Controls.Add(txtCaptcha);
        }

        private void ShowCaptcha()
        {
            Random random = new Random();
            captchaText = random.Next(1000, 9999).ToString();
            Bitmap bmp = new Bitmap(120, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Font captchaFont = new Font(privateFonts.Families[0], 20, FontStyle.Bold);
                g.DrawString(captchaText, captchaFont, Brushes.Black, new PointF(10, 5));

                for (int i = 0; i < 500; i++)
                {
                    int x = random.Next(0, bmp.Width);
                    int y = random.Next(0, bmp.Height);
                    bmp.SetPixel(x, y, Color.Gray);
                }

                for (int i = 0; i < 5; i++)
                {
                    int x1 = random.Next(0, bmp.Width);
                    int y1 = random.Next(0, bmp.Height);
                    int x2 = random.Next(0, bmp.Width);
                    int y2 = random.Next(0, bmp.Height);
                    g.DrawLine(Pens.Gray, x1, y1, x2, y2);
                }
            }
            pictureBoxCaptcha.Image = bmp;

            lblCaptcha.Visible = true;
            pictureBoxCaptcha.Visible = true;
            txtCaptcha.Visible = true;

            isCaptchaDisplayed = true;
            this.Size = new Size(200, 300);
        }

        private void linklb_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (isLocked)
            {
                MessageBox.Show("Попробуйте снова через 10 секунд.");
                return;
            }

            var login = tb_Login.Text;
            var password = tb_Password.Text;

            if (isCaptchaDisplayed && txtCaptcha.Text != captchaText)
            {
                MessageBox.Show("Неверная CAPTCHA. Попробуйте снова.");
                ShowCaptcha();

                LockForm();
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, login_user, password_user, is_admin, Picture from register where login_user = '{login}' and password_user = '{password}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                var userId = table.Rows[0].ItemArray[0].ToString();
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Countries countries = new Countries(user);
                MainForm mainForm = new MainForm(userId);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Эхх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!isCaptchaDisplayed)
                {
                    ShowCaptcha();
                }
            }
        }

        private void LockForm()
        {
            isLocked = true;
            timer.Start();
        }

        private void UnlockForm(object sender, ElapsedEventArgs e)
        {
            isLocked = false;
            timer.Stop();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}