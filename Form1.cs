using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        List<string> imecodes = new List<string>(100);
        Thread th = null;

        void ime()
        {
            char[] c1 = new char[25], c2 = new char[26], c3 = new char[26], c4 = new char[26];
            int i = 0;
            for (char ch = 'a'; ch < 'z'; ch++)
                c1[i] = c2[i] = c3[i] = c4[i++] = ch;
            c2[25] = c3[25] = c4[25] = ' ';

            bool begin = false;
            string head = "";
            if (File.Exists(@"z:\ime.txt"))
            {
                var existLines = File.ReadAllLines(@"z:\ime.txt");
                head = existLines[existLines.Length - 1].Split(':')[0].Replace("'", "");
            }
            else
                begin = true;

            foreach (char a in c1)
                foreach (char b in c2)
                    foreach (char c in c3)
                    {
                        foreach (char d in c4)
                        {
                            string keys = $"{a}{b}{c}{d}";
                            if (keys.Contains(" ")) keys = keys.Substring(0, keys.IndexOf(" "));
                            keys += " ";

                            var code = (keys.Length < 4 ? keys + " " : (keys.Length > 4 ? keys.Substring(0, 4) : keys)).Replace("  ", " ");
                            if(!begin)
                            {
                                if (code == head) begin = true;
                                continue;
                            }

                            txt.Text = "";
                            txt.Focus();
                            foreach (char k in keys)
                            {
                                SendKeys.SendWait(k.ToString());
                                Thread.Sleep(50);
                            }

                            var chinese = txt.Text.Replace(" ", "");
                            if (chinese != "")
                            {
                                imecodes.Add($"'{code}':'{chinese}',");
                            }

                            lbl.Text = $"{code}:{chinese}";

                            Thread.Sleep(50);

                            if ($"{a}{b}{c}".Contains(" ")) break;
                        }

                        File.AppendAllLines(@"z:\ime.txt", imecodes);
                        imecodes.Clear();
                        GC.Collect();

                        if ($"{a}{b}".Contains(" ")) break;
                    }

            Process.Start("shutdown.exe", "/s /t 1");
        }

        private void txt_DoubleClick(object sender, EventArgs e)
        {
            lblTip.Text = "点击这里中止操作";
            th = new Thread(ime);
            th.Start();
        }

        private void lblTip_Click(object sender, EventArgs e)
        {
            if (th != null) th.Abort();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start(@"z:\ime.txt");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null) th.Abort();
        }
    }
}
