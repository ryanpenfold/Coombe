using CoombeImageEditor.ProjectManagers;
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

            pd = ps.loadProject(folderBrowserDialog1.SelectedPath);

            ActiveForm.Text = "Coombe - " + pd.projectTitle;

            foreach (string s in System.IO.Directory.GetDirectories(pd.projectFolder + "\\fs"))
            {
                navArea.Items.Add(s.Split('\\').Last(), 0);
            }

            foreach (string s in System.IO.Directory.GetFiles(pd.projectFolder + "\\fs"))
            {
                
                navArea.Items.Add(s.Split('\\').Last(),1);
            }
        }
    }
}
