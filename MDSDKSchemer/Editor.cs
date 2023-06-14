using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDSDK;
using MDSDKBase;

namespace MDSDKDerived
{
    //using MDSDKSchemer;

    /// <summary>
    /// See the xml docs for EditorBase.
    /// </summary>
	internal class Editor : EditorBase
    {
        public Editor(FileInfo fileInfo) : base(fileInfo) { }

        // Methods that don't modify.

        // Methods that modify. Set this.IsDirty to true only you modify the document directly, not
        // if you call a method that already does so.
    }
}
