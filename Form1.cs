using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BSUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\Program Files\\Oculus\\Support\\oculus-diagnostics\\OculusDebugToolCLI.exe"))
                AswButton.Enabled = false;
        }

        private void PriorityButton_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/q/13944554
            Process[] pname = Process.GetProcessesByName("Beat Saber");
            if (pname.Length == 0)
                MessageBox.Show("Failed to find Beat Saber's process. Is Beat Saber Open?");
            else
            {
                pname[0].PriorityClass = ProcessPriorityClass.High;
                MessageBox.Show("Beat Saber Priority Has Successfully Been Set To High!");
                priorityButton.Enabled = false;
            }

        }

        private void AswButton_Click(object sender, EventArgs e)
        {
        string TempAswPath = $"{Path.GetTempPath()}aswDisableCmds.txt";
            if(!File.Exists(TempAswPath))
            {
                string[] aswDisableLines = { "server:asw.Off", "exit" };
                File.WriteAllLines(TempAswPath, aswDisableLines);
            }
            Process.Start("C:\\Program Files\\Oculus\\Support\\oculus-diagnostics\\OculusDebugToolCLI.exe", $"-f {TempAswPath}");

            AswButton.Enabled = false;
        }

        private void ReenableButton_Click(object sender, EventArgs e)
        {
            // it works
            AswButton.Enabled = true;
            priorityButton.Enabled = true;
        }
    }
}
