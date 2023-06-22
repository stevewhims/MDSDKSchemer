using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using MDSDK;
using MDSDKBase;

namespace MDSDKSchemer
{
}

namespace MDSDKDerived
{
    using MDSDKSchemer;
    using Microsoft.VisualBasic;
    using System.Diagnostics;
    using System.Net.Sockets;

    /// <summary>
    /// See the xml docs for ProgramBase.
    /// </summary>
    internal class Program : ProgramBase
    {
        // Logs
        //private Log? exampleLog = null;

        // Data
        //private DocSet? win10Docs = null;
        //private Dictionary<string, string> uniqueKeyMap = null;
        //private Dictionary<string, List<string>> nonUniqueKeyMap = null;

        static int Main(string[] args)
        {
            return (new Program()).Run();
        }

        protected override void OnRun()
        {
            // Load a docset.
            //this.win10Docs = DocSet.CreateDocSet(DocSetType.ConceptualAndReference, Platform.UWPWindows10, "Win10 docs");

            //this.exampleLog = new Log()
            //{
            //    Label = "Text log containing info too verbose for the console.",
            //    Filename = "Example_Log.txt",
            //    AnnouncementStyle = ConsoleWriteStyle.Default
            //};
            //this.RegisterLog(this.exampleLog);
            //this.exampleLog.Add("Example message.");

            string topicsRootPath = ProgramBase.Win32ConceptualContentRepoName + @"\desktop-src\";
            string topicsFolderName = @"NativeWiFi";

            string schemaDisplayName = @"LAN_profile";
            string schemaNameForFilenames = @"lan-profileschema";
            string xsdFileName = @"C:\Users\stwhi\Downloads\schemas\LAN_profile_v1.xsd";

            //    @"lan-policychema",
            //    @"C:\Users\stwhi\Downloads\schemas\LAN_policy_v1.xsd");

            //    @"onexschema",
            //    @"C:\Users\stwhi\Downloads\schemas\OneX_v1.xsd");

            //    @"wlan-profileschema",
            //    @"C:\Users\stwhi\Downloads\schemas\WLAN_profile_v1.xsd");

            var schemer = new Schemer(
                topicsRootPath,
                topicsFolderName,
                schemaDisplayName,
                schemaNameForFilenames,
                xsdFileName);

            ProgramBase.IndentationCharForConsole = '.';
            schemer.DebugInit(); // This is just a convenience so you don't have to manually delete the output folder each run. Delete this call for production.
            schemer.Survey(); // Read the xsd, and build tree of Editors.
            //EditorBase.IndentationChar = '.';
            schemer.Generate(); // Generate content.
            schemer.Commit(); // Clean up.

            //Win32APIReferenceContentTopicsLexer.DocumentTypesForParameters(apiRefModelWin32);
            //Win32APIReferenceContentTopicsLexer.ReportAnyFirstAsteriskInYamlDescription();

            // Specifics are in configuration.txt.
            //GitProcess.CreatePersonalBranch(false);
            // Edit and save files here.
            //GitProcess.StageAndCommit();
            // You can now create your pull-request.
            // Delete personal branch now if you're sure you're done with it.
            //GitProcess.DeletePersonalBranch(false);

            //this.uniqueKeyMap = this.LoadUniqueKeyMap("uniqueKeyMap.txt");
            //this.nonUniqueKeyMap = this.LoadNonUniqueKeyMap("nonUniqueKeyMap.txt");
        }
    }
}
