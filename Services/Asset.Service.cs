﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Services
{
    static class AssetService
    {
        /// <summary>
        /// Global service where all widgets are stored
        /// </summary>
        static public WidgetListService widgets = new WidgetListService();

        /// <summary>
        /// Path where the assets of the application are stored
        /// </summary>
        static public string assetsPath = Application.StartupPath + "/Assets";

        /// <summary>
        /// Path to the html widgets
        /// </summary>
        static public string widgetsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Widgets");

        /// <summary>
        /// Gets the path where the HTML files (widgets) of the project are stored
        /// </summary>
        /// <param name="path">Path to the root folder</param>
        /// <returns>An array of all html files and their absolute paths</returns>
        static public string[] GetPathToHTMLFiles(string path)
        {
            return Directory.GetFiles(path, "*.html", SearchOption.AllDirectories);
        }

        /// <summary>
        /// Creates the default directory for all html files (widgets)
        /// </summary>
        static public void CreateHTMLFilesDirectory()
        {
            Directory.CreateDirectory(widgetsPath);
        }

        /// <summary>
        /// Creates a html file if it doesn't exist
        /// </summary>
        /// <param name="path">Path of creation and name of the file</param>
        /// <param name="content">Content of the folder</param>
        static public void CreateHTMLFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {
                    streamWriter.WriteLine(content);
                }
            }
        }
    }
}
