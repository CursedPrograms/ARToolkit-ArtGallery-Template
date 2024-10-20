﻿
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text.RegularExpressions;

[InitializeOnLoad]
public class ARToolKitMenuEditor : MonoBehaviour {
    private const  string FIRST_RUN             = "artoolkit_first_run";
    private const  string TOOLS_MENU_PATH       = "ARToolKit/Download Tools";
    private const  string TOOLS_UNITY_MESSAGE   = "To use ARToolKit, you will need tools to generate markers and calibrate your camera.\n" +
            "please select \"{0}\" from the menu to download those tools.";
    private const  string HOME_PAGE_URL         = "http://www.artoolkit.org/";
    private const  string DOCUMENTATION_URL     = "http://www.artoolkit.org/documentation/";
    private const  string COMMUNITY_URL         = "http://www.artoolkit.org/community/forums/";
    private const  string SOURCE_URL            = "https://github.com/artoolkit/artoolkit5";
    private const  string PLUGIN_SOURCE_URL     = "https://github.com/artoolkit/arunity5";
	private const  string TOOLS_URL             = "http://artoolkit.org/download-artoolkit-sdk#unity";
    private const  string VERSION               = "ARToolKit/ARToolKit for Unity Version 5.3.3";
    private const  string WINDOWS_UNITY_MESSAGE = "Thank you for choosing ARToolKit for Unity! " +
            "<b>ARToolKit requires the Microsoft C++ Redistributables to be installed on your system.</b>\n" +
            "Please select \"{0}\" from the menu above, and install the required packages.";
    private const  string GET_TOOLS_MESSAGE     = "ARToolKit for Unity Version 5.3.3! <b>To make your own markers, you'll need to download our tools.</b>\n" +
		"Please select {0} from menu above to download them.";

    static ARToolKitMenuEditor() {
        if (EditorPrefs.GetBool(FIRST_RUN, true)) {
            EditorPrefs.SetBool(FIRST_RUN, false);
            Debug.Log(string.Format(GET_TOOLS_MESSAGE, TOOLS_MENU_PATH));
#if UNITY_EDITOR_WIN
            Debug.Log(string.Format(WINDOWS_UNITY_MESSAGE, TOOLS_MENU_PATH));
#endif
        }
    }
    
    [MenuItem (VERSION, false, 0)]
    private static void Version() { }

	[MenuItem (VERSION, true, 0)]
	private static bool ValidateVersion() {
		return false;
	}

    [MenuItem (TOOLS_MENU_PATH, false, 1)]
    private static void DownloadTools() {
        Application.OpenURL(TOOLS_URL);
    }

    [MenuItem ("ARToolKit/Support/Home Page", false, 50)]
	private static void HomePage() {
        Application.OpenURL(HOME_PAGE_URL);
    }
    
    [MenuItem ("ARToolKit/Support/Documentation", false, 51)]
	private static void Documentation() {
        Application.OpenURL(DOCUMENTATION_URL);
    }
	[MenuItem ("ARToolKit/Build", false, 41)]
	private static void Documentdation() {
		ARToolKitPackager.CreatePackage();
	}
	[MenuItem ("ARToolKit/Support/Community Forums", false, 52)]
	private static void Community() {
        Application.OpenURL(COMMUNITY_URL);
    }
    
    [MenuItem ("ARToolKit/Source Code/View ARToolKit Source", false, 53)]
	private static void Source() {
        Application.OpenURL(SOURCE_URL);
    }
    
    [MenuItem ("ARToolKit/Source Code/View Unity Plugin Source", false, 54)]
	private static void PluginSource() {
        Application.OpenURL(PLUGIN_SOURCE_URL);
    }
}
