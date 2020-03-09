using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace aHelper
{
    public partial class aPanel : Form
    {
        bool[] cPlus = { true, true, true };
        int[] cCode = { 0x00, 0x80, 0xFE };
        float flySpeed = 0.19f;
        Memory m = new Memory();

        public aPanel()
        {
            InitializeComponent();
        }

        private void aPanel_Load(object sender, EventArgs e)
        {
            
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            for (int c = 0; c < 3; c++)
            {
                if (cCode[c] == 0xFF) cPlus[c] = false;
                if (cCode[c] == 0x00) cPlus[c] = true;
                if (cPlus[c]) cCode[c]++;
                if (!cPlus[c]) cCode[c]--;
            }
            BackColor = Color.FromArgb(cCode[0], cCode[1], cCode[2]);
            //ForeColor = Color.FromArgb(0xFF - cCode[0], 0xFF - cCode[1], 0xFF - cCode[2]);
        }

        private void aPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            whButton.Text = "Установить дальность ников: " + whTrackBar.Value;
        }

        private void whButton_Click(object sender, EventArgs e)
        {
            if (!m.CH())
                return;
            SetWH(Convert.ToSingle(whTrackBar.Value));
            log("Дальность ников: " + whTrackBar.Value, Color.Black);
        }

        private string GET(string URL)
        {
            try
            {
                var webClient = new WebClient();
                webClient.Headers.Add("user-agent", "Mozilla/5.0 (vk.com/idDrygok)");
                Random r = new Random();
                return webClient.DownloadString(URL);
            }
            catch { return ""; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            m.WriteMEM(m.dwSAMP + 0xA7DD0, new byte[] { 0xC2, 0x04, 0x00 });
            log("Изменение состояние двигателя запрещено.", Color.Black);
        }

        private void nocrashButton_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            m.WriteMEM(m.dwSAMP + 0x5A170, new byte[] { 0xC2, 0x0C, 0x00, 0x15, 0x9C });
            m.WriteMEM(m.dwSAMP + 0x5A1D9, new byte[] { 0x90 });
            m.WriteMEM(m.dwSAMP + 0x5A1E1, new byte[] { 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM(m.dwSAMP + 0x12A80, new byte[] { 0xC3, 0x90 });
            m.WriteMEM((IntPtr)0x635DA0, new byte[] { 0xB8, 0x00, 0x00, 0x00, 0x00, 0xC3, 0x90 });
            m.WriteMEM((IntPtr)0x00544CFE, new byte[] { 0xD9, 0x05, 0x24, 0x86, 0x85, 0x00, 0xD8, 0x64, 0x24, 0x04 });
            m.WriteMEM((IntPtr)0x005E91CE, new byte[] { 0xC7, 0x46, 0x4C, 0x00, 0x00, 0x80, 0x3E });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x2903DB, new byte[] { 0xE9, 0x90, 0x4E, 0xFB, 0xFF });
            m.WriteMEM((IntPtr)m.dwSAMP + 0xA16FA, new byte[] { 0xEB });
            m.WriteMEM((IntPtr)m.dwSAMP + 0xA92C7, new byte[] { 0xEB });
            m.WriteMEM((IntPtr)m.dwSAMP + 0xA9B48, new byte[] { 0xEB });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x5AD1B, new byte[] { 0xEB });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x290014, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x23EB8D, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x290028, new byte[] { 0xE9, 0xDF, 0x00, 0xFA, 0xFF });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x221968, new byte[] { 0xE9, 0x9F, 0xE7, 0x00, 0x00 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x280E78, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x6C127, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x6C122, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x6C149, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x6BFE9, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            m.WriteMEM((IntPtr)m.dwSAMP + 0x986AE, new byte[] { 0x90, 0x90 });
            m.WriteMEM((IntPtr)0x5BCD50, new byte[] { 0x90 });
            m.WriteMEM((IntPtr)0x5BCD78, new byte[] { 0x90 });
            m.WriteMEM((IntPtr)0x5B8E64, new byte[] { 0x90 });
            m.WriteMEM((IntPtr)0x74872D, new byte[] { 0x90 });
            m.WriteMEM((IntPtr)0x5BCD50, new byte[] { 0x90 });
            m.WriteMEM((IntPtr)0x406946, new byte[] { 0x00 });
            log("Антикрашер включен", Color.Black);
        }

        void SetWH(float dist)
        {
            if (!m.CH()) return;
            IntPtr addr = (IntPtr)m.ReadDWORD(m.dwSAMP + 0x20DFEC);
            addr = (IntPtr)m.ReadDWORD(addr + 0x3C6);
            m.WriteMEM((IntPtr)addr + 0x38, 1);
            m.WriteMEM((IntPtr)addr + 0x5, 0);
            m.WriteMEM((IntPtr)addr + 0x2F, dist);
        }

        private void nofallButton_Click(object sender, EventArgs e)
        {
            if (!m.CH())
                return;
            m.WriteMEM((IntPtr)0x4BA3B9, new byte[] { 0xE9, 0xA7, 0x03, 0x00, 0x00, 0x90 });
            log("Не падать с байка: включено", Color.Black);
        }

        public void log(string text, Color color)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.SelectionLength = 0;

            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text + "\n");
            richTextBox1.SelectionColor = richTextBox1.ForeColor;
        }

        private void hpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            log("Восстановление здоровья " + (hpCheckBox.Checked ? "выключено" : "включено"), Color.Black);
            if ((!globalTimer.Enabled) && (hpCheckBox.Checked)) globalTimer.Start();
        }

        private void fastconnectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            log("FastConnect: " + (fastconnectCheckBox.Checked ? "выключено" : "включено"), Color.Black);
        }

        private void tpmapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            log("ТП по метке: " + (fastconnectCheckBox.Checked ? "выключено" : "включено"), Color.Black);
            if ((!globalTimer.Enabled) && (tpmapCheckBox.Checked)) globalTimer.Start();
        }

        private void updateposButton_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            float[] pp = { m.ReadFLOAT((IntPtr)0xB6F2E4), m.ReadFLOAT((IntPtr)0xB6F2E8), m.ReadFLOAT((IntPtr)0xB6F2EC) };
            xposText.Text = "" + pp[0]; yposText.Text = "" + pp[1]; zposText.Text = "" + pp[2];
        }

        private void setposButton_Click(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            IntPtr o = (IntPtr)m.ReadDWORD((IntPtr)m.ReadDWORD(m.POINTER_CPED) + m.OFFSET_SETPOSITION);
            try { m.WriteMEM(o + 0x30, Convert.ToSingle(xposText.Text)); } catch { log("Ошибка при изменении X-координаты", Color.Black); }
            try { m.WriteMEM(o + 0x34, Convert.ToSingle(yposText.Text)); } catch { log("Ошибка при изменении Y-координаты", Color.Black); }
            try { m.WriteMEM(o + 0x38, Convert.ToSingle(zposText.Text)); } catch { log("Ошибка при изменении Z-координаты", Color.Black); }
            log("Телепорт по координатам", Color.Black);
        }

        private void flyButton_CheckedChanged(object sender, EventArgs e)
        {
            log("Fly: " + (fastconnectCheckBox.Checked ? "выключено" : "включено"), Color.Black);
            if ((!globalTimer.Enabled) && (flyButton.Checked)) globalTimer.Start();
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            if (!m.CH()) { globalTimer.Stop(); return; }
            bool[] checkBoxes = new bool[] { hpCheckBox.Checked, tpmapCheckBox.Checked, flyButton.Checked, fastconnectCheckBox.Checked };
            if ((!checkBoxes[0]) && (!checkBoxes[1]) && (!checkBoxes[2]) && (!checkBoxes[3])) { globalTimer.Stop(); return; }
            if (!(m.GetActiveWindow() == "Criminal Russia Multiplayer Ревизия G")) return;
            IntPtr currentVehicle = (IntPtr)m.ReadDWORD(m.POINTER_VEHICLE);
            IntPtr currentPED = (IntPtr)m.ReadDWORD(m.POINTER_CPED);
            //if (fastconnectCheckBox.Checked) m.WriteMEM(m.dwSAMP + 0x2A09C6, 100);
            if ((checkBoxes[2]))
            {
                if (m.IsKeyDown(Keys.RButton)) // Fly
                {
                    float[] pp = { m.ReadFLOAT((IntPtr)0xB6F2E4), m.ReadFLOAT((IntPtr)0xB6F2E8), m.ReadFLOAT((IntPtr)0xB6F2EC) };
                    float[] cc = { m.ReadFLOAT((IntPtr)0xB6F9CC), m.ReadFLOAT((IntPtr)0xB6F9D0), m.ReadFLOAT((IntPtr)0xB6F9D4) };
                    float[] k = { pp[0] - cc[0], pp[1] - cc[1], pp[2] - cc[2] };
                    if ((currentVehicle == (IntPtr)0))
                    {
                        m.WriteMEM(currentPED + 0x44, k[0] * flySpeed);
                        m.WriteMEM(currentPED + 0x48, k[1] * flySpeed);
                        m.WriteMEM(currentPED + 0x4C, k[2] * flySpeed);
                        m.WriteMEM(currentPED + 0x540, 99999999f);
                    }
                    else
                    {
                        m.WriteMEM(currentVehicle + 0x44, k[0] * flySpeed);
                        m.WriteMEM(currentVehicle + 0x48, k[1] * flySpeed);
                        m.WriteMEM(currentVehicle + 0x4C, k[2] * flySpeed);
                        m.WriteMEM((IntPtr)m.ReadDWORD(currentVehicle + 0x14) + 0x8, 0f);
                        m.WriteMEM(currentVehicle + 0x4C0, 1000f);
                        setVrot(k[0], k[1], k[2]);
                    }
                }
                if ((m.IsKeyDown(Keys.Up)) && (flySpeed < 0.99)) flySpeed += 0.01f;
                if ((m.IsKeyDown(Keys.Down)) && (flySpeed > 0.01)) flySpeed -= 0.01f;
            }
            if (checkBoxes[0])
            {
                if (m.IsKeyDown(Keys.F2)) { m.WriteMEM(currentVehicle + 0x4C0, 1000f); m.WriteMEM(currentPED + 0x540, 100f); }
            }
        }

        private void setVrot(float X, float Y, float Z)
        {
            IntPtr pointer = (IntPtr)m.ReadDWORD((IntPtr)m.ReadDWORD((IntPtr)0xB6F980) + 0x14);
            m.WriteMEM(pointer + 0x10, X);
            m.WriteMEM(pointer + 0x14, Y);
            m.WriteMEM(pointer + 0x18, Z);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            log("HUD: " + (fastconnectCheckBox.Checked ? "выключено" : "включено"), Color.Black);
            if (checkBox1.Checked)
                m.WriteMEM((IntPtr)0x866C94, "~h~P%d");
            else
                m.WriteMEM((IntPtr)0x866C94, "$%08");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/iddrygok");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!m.CH()) return;
            if (checkBox2.Checked) { m.WriteMEM((IntPtr)0x5E4110, new byte[] { 0xC2, 0x10, 0x00 }); }
            else { m.WriteMEM((IntPtr)0x5E4110, new byte[] { 0x56, 0x8B, 0xF1 }); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\www.gtasrv.ru\\CR-MP\\GenerationC", "aPlus", textBox1.Text);
        }
    }
}
