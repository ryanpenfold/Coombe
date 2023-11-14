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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoombeImageEditor.Dialogs
{
    public partial class MainPage : Form
    {
        ProjectSystem ps = new ProjectSystem();
        ProjectData pd = new ProjectData();
        ProjectCompilers pc = new ProjectCompilers();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            tsLabel.Visible = false;
            tsProgress.Visible = false;
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();

            tsLabel.Visible = true;
            tsLabel.Text = "Loading File...";
            tsProgress.Maximum = 3;
            tsProgress.Value = 0;
            tsProgress.Visible = true;

            pd = ps.loadProject(folderBrowserDialog1.SelectedPath);

            tsProgress.Value++;

            ActiveForm.Text = "Coombe - " + pd.projectTitle;

            foreach (string s in System.IO.Directory.GetDirectories(pd.projectFolder + "\\fs"))
            {
                navArea.Items.Add(s.Split('\\').Last(), 0);
            }

            tsProgress.Value++;

            foreach (string s in System.IO.Directory.GetFiles(pd.projectFolder + "\\fs"))
            {
                
                navArea.Items.Add(s.Split('\\').Last(),1);
            }

            tsProgress.Value++;

            tsLabel.Visible = true;
            tsLabel.Text = "Loading Complete.";
            tsProgress.Maximum = 100;
            tsProgress.Value = 0;
            tsProgress.Visible = false;

            projectTitle.Text = pd.projectTitle;
            switch (pd.projectFormat.ToLower())
            {
                case "iso":
                    pd.projectFormat = "iso";
                    volumeType.SelectedIndex = 1;
                    break;

                case "flp":
                    volumeType.SelectedIndex = 3;
                    break;

                case "vhd":
                    volumeType.SelectedIndex = 2;
                    break;

                default:
                    volumeType.SelectedIndex = 0;
                    break;
            }
            updateLayout();
        }

        private void volumeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (volumeType.SelectedText)
            {
                case "Disc Image (ISO)":
                    pd.projectFormat = "iso";
                    break;

                case "Floppy Image (FLP)":
                    pd.projectFormat = "flp";
                    break;

                case "Virtual Hard Disk (VHD)":
                    pd.projectFormat = "vhd";
                    break;

                default:
                    volumeType.SelectedIndex = 0;
                    break;
            }
            Console.WriteLine("Project Format changed to " + pd.projectFormat);
        }

        private void projectTitle_TextChanged(object sender, EventArgs e)
        {
            pd.projectTitle = projectTitle.Text;
            Console.WriteLine("Updated project title to " + pd.projectTitle);
            ActiveForm.Text = "Coombe - " + pd.projectTitle;
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ps.createProject(pd, true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateLayout()
        {
            /* if (pd.projectFormat != "vhd")
            {
                discSize.Enabled = false;
                pd.projectFSsize = 700;
                sizeLeftPrg.Maximum = Convert.ToInt32(pd.projectFSsize);
                DirectoryInfo dinfo = new DirectoryInfo(pd.projectFolder + "\\" + pd.projectFSroot);
                sizeleft.Text = "of which " + dinfo.EnumerateFiles().Sum(file => file.Length / 1024 / 1024) + "mb is left.";
                sizeLeftPrg.Value = Convert.ToInt32(dinfo.EnumerateFiles().Sum(file => file.Length) / 1024 / 1024);
            } */
        }

        private void sizeLeftPrg_Click(object sender, EventArgs e)
        {

        }
    }
}
