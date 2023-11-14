using DiscUtils.Iso9660;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

// Handlers for Compiling Formats (ISO, VHD)

namespace CoombeImageEditor.ProjectManagers
{
    internal class ProjectCompilers
    {
        public void isoCompiler(ProjectData pd)
        {
            System.Console.WriteLine("Generating ISO...");
            CDBuilder builder = new CDBuilder();
            builder.UseJoliet = true;
            builder.VolumeIdentifier = pd.projectTitle;
            foreach(string s in System.IO.Directory.GetFiles(pd.projectFolder + "\\fs"))
            {
                string[] sp = s.Split('\\');
                builder.AddFile(sp.Last(), System.IO.File.ReadAllBytes(s));
                System.Console.WriteLine("Adding File - " + s);
            }
            System.IO.Directory.CreateDirectory(pd.projectFolder + "\\out");
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            builder.Build(sf.FileName + ".iso");
        }

        private string[] dirs;
        private void getListOfDirectories(CDReader cd, string dir)
        {
            foreach (string dirname in cd.GetDirectories(dir))
            {
                dirs.Append(dirname);
                Console.WriteLine(dirname);
                getListOfDirectories(cd, dirname);
            }
        }
        public void isoDecompiler(string fileName, string outFolder, ProjectData pd, ProjectSystem ps)
        {
            using (FileStream isoStream = File.Open(fileName,FileMode.Open))
            {
                CDReader cd = new CDReader(isoStream, true);
                pd.initData(outFolder, "iso", cd.VolumeLabel, "", 0, "fs", "");
                ps.createProject(pd);
                /* foreach(string s in cd.GetFiles("\\"))
                {
                    Stream fileStream = cd.OpenFile(s, FileMode.Open);
                    Stream outStream = File.Create(pd.projectFolder + "\\" + pd.projectFSroot + "\\" + s);
                    fileStream.CopyTo(outStream);
                    outStream.Close();
                    fileStream.Close();
                }
                foreach(string s in cd.GetDirectories("\\"))
                {
                    System.IO.Directory.CreateDirectory(pd.projectFolder + "\\" + pd.projectFSroot + "\\" + s);
                    foreach (string s2 in cd.GetFiles("\\"))
                    {
                        Stream fileStream = cd.OpenFile(s2, FileMode.Open);
                        Stream outStream = File.Create(pd.projectFolder + "\\" + pd.projectFSroot + "\\" + s2);
                        fileStream.CopyTo(outStream);
                        outStream.Close();
                        fileStream.Close();
                    }
                } */
                string[] fse = cd.GetDirectories("\\");
                TextWriter w = new StreamWriter("C:\\test\\list.txt");
                foreach(string f in fse)
                {
                    w.WriteLine(f);
                    foreach (string dir in cd.GetDirectories(f))
                    {
                        fse.Append(dir);
                        w.WriteLine(dir);
                        Console.Write(dir);
                    }
                }
                w.Close();

                // Use fileStream...
            }
        }
    }
}
