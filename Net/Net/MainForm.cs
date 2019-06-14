using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Net
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Buffer.MainForm = this;
            BatteryText.Text = (SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString();
        }

        private void Mail_Click(object sender, System.EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("SkyVeles@gmail.com", "LapTop");
            // кому отправляем
            MailAddress to = new MailAddress("SkyVelesProject@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "Уровень заряда батареи " + (SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString() + "% "
                + Ram.Text;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            // логин и пароль
            smtp.Credentials = new NetworkCredential("SkyVeles@gmail.com", "RedShuhow117");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void Reset_Click(object sender, System.EventArgs e)
        {
            PerformanceCounter ramFree = new PerformanceCounter("Memory", "Available MBytes");
            Ram.Text = 5900 - ramFree.NextValue() + " MB / 6000 MB";
            PerformanceCounter cpucounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CPU.Text = cpucounter.NextValue() + " %";

            
            foreach (Process proc in Process.GetProcesses())
            {
                using (PerformanceCounter pcProcess = new PerformanceCounter("Process", "% Processor Time", proc.ProcessName))
                {
                    pcProcess.NextValue();
                    CPU.Text = "Process: " + proc.ProcessName+ " CPU% " + pcProcess.NextValue();
                }
            }
        }
    }
}

