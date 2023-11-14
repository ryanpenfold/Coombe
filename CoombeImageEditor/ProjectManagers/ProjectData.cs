using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

// Handles ProjectData stuff

namespace CoombeImageEditor.ProjectManagers
{
    class ProjectData
    {
        public string projectFolder;                // Root folder which Project Files are located in.
        public string projectFormat;                // Format of the Project - ISO/VHD/FLOPPY
        public string projectTitle;                 // Title of the Project  also serves as Volume Label
        public string projectFStype;                // FileSystem format of the VHD, or type of ISO/FLOPPY.
        public decimal projectFSsize;               // Size of the FS. 0/Disabled on ISO/Floppy
        public string projectFSroot;                // FS Root for the Project
        public string projectBootRom;               // Direct Address to Boot.ROM
        

        public void initData(string pj, string form, string title, string fstype, decimal size, string fsroot, string bootrom)
        {
            projectFolder = pj;
            projectFormat = form;
            projectTitle = title;
            projectFStype = fstype;
            projectFSroot = fsroot;
            projectBootRom = bootrom;
        }
    }
}
