using CoombeImageEditor.Dialogs;
using CoombeImageEditor.ProjectManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CoombeImageEditor
{

    public partial class Form1 : Form
    {
        ProjectSystem ps = new ProjectSystem();
        ProjectData pd = new ProjectData();
        ProjectCompilers pc = new ProjectCompilers();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            System.Console.WriteLine("Begin startup of CoombeImageEditor");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void generateProjectBtn_Click(object sender, EventArgs e)
        {
            pd.initData(textBox1.Text, metaType.Text, metaName.Text, metaFormat.Text, numericUpDown1.Value, "fs", "");
            ps.createProject(pd, false);
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", textBox1.Text + "\\fs");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pd = ps.loadProject(textBox1.Text);

            metaType.Text = pd.projectFormat;
            metaName.Text = pd.projectTitle;
            metaFormat.Text = pd.projectFStype;
            numericUpDown1.Value = pd.projectFSsize;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metaType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (pd.projectFormat == "iso")
            {
                pc.isoCompiler(pd);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isoChoose.ShowDialog();
            folderBrowserDialog1.ShowDialog();
            pc.isoDecompiler(isoChoose.FileName, folderBrowserDialog1.SelectedPath, pd, ps);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}
