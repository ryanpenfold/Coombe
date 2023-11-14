using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

// Project Save/Load/Generate runtimes.

namespace CoombeImageEditor.ProjectManagers
{
    class ProjectSystem
    {

        public ProjectData loadProject(string projectFolder)
        {
            ProjectData pd = new ProjectData();
            pd.projectFolder = projectFolder;
            FileStream fileStream = new FileStream(projectFolder + "\\project.xml", FileMode.Open);
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;
            using(XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                while (reader.Read())
                {
                    switch(reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.WriteLine("Text Node: {0}", reader.Name);
                            switch(reader.Name)
                            {
                                case "meta":
                                    pd.projectTitle = reader.GetAttribute("title");
                                    pd.projectFormat = reader.GetAttribute("format");
                                    break;
                                case "fs":
                                    pd.projectFStype = reader.GetAttribute("type");
                                    pd.projectFSsize = Convert.ToDecimal(reader.GetAttribute("size"));
                                    break;
                                case "input":
                                    pd.projectFSroot = reader.GetAttribute("files");
                                    pd.projectBootRom = reader.GetAttribute("boot");
                                    break;
                            }
                            break;
                        case XmlNodeType.EndElement:

                            break;
                    }
                }
            }
            fileStream.Close();
            return pd;
        }

        public bool createProject(ProjectData pd, bool overwrite)
        {
            Console.WriteLine("Attempting to create " + pd.projectFormat + " project in " + pd.projectFolder);
            if (System.IO.Directory.Exists(pd.projectFolder) && overwrite == false)
            {
                DialogResult dr = MessageBox.Show("Project folder already exists! Continue generating project?", "Project Folder exists", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.No) {
                    return false;
                }
            } 
            else
            {
                System.IO.Directory.CreateDirectory(pd.projectFolder);
            }
            System.IO.Directory.CreateDirectory(pd.projectFolder + "\\fs");
            FileStream fileStream = new FileStream(pd.projectFolder + "\\project.xml", FileMode.Create);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Async = true;

            using (XmlWriter writer = XmlWriter.Create(fileStream, settings))
            {
                // Create basic Project.XML file in the folder root
                writer.WriteStartElement("coombeimgproj");
                writer.WriteStartElement("meta");
                writer.WriteAttributeString("format", pd.projectFormat);
                writer.WriteAttributeString("title", pd.projectTitle);
                writer.WriteEndElement();
                writer.WriteStartElement("fs");
                writer.WriteAttributeString("type", pd.projectFStype);
                writer.WriteAttributeString("size", pd.projectFSsize.ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("input");
                writer.WriteAttributeString("files", pd.projectFSroot);
                writer.WriteAttributeString("boot", pd.projectBootRom);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            fileStream.Close();
            return true;
        }
    }
}
