﻿using System;
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

            Schemer.Process(
                ProgramBase.Win32ConceptualContentRepoName + @"\desktop-src\",
                @"NativeWiFi",
                @"lan-profileschema",
                @"C:\Users\stwhi\Downloads\schemas\LAN_profile_v1.xsd"
            );

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
