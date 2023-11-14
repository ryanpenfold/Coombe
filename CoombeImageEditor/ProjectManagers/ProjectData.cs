using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Handles ProjectData stuff

namespace CoombeImageEditor.ProjectManagers
{
    class ProjectData
    {
        public string projectFolder;
        public string projectFormat;
        public string projectTitle;
        public string projectFStype;
        public decimal projectFSsize;
        public string projectFSroot;
        public string projectBootRom;

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
