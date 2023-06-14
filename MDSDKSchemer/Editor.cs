using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using MDSDK;
using MDSDKBase;

namespace MDSDKDerived
{
    //using MDSDKSchemer;

    /// <summary>
    /// To placate the compiler until I've fixed the underlying issue.
    /// </summary>
    internal class Editor : EditorBase
    {
        public Editor(FileInfo fileInfo) : base(fileInfo) { }
    }
}
