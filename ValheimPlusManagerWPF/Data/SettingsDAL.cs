﻿using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ValheimPlusManager.Models;

namespace ValheimPlusManager.Data
{
    public sealed class SettingsDAL
    {
        public static Settings GetSettings()
        {
            using (var fileStream = File.Open("Data/Settings.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                return (Settings)serializer.Deserialize(fileStream);
            }
        }

        public static bool UpdateSettings(Settings settings, bool manageClient)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("Data/Settings.xml");

            if (manageClient)
            {
                XmlNode node = xml.SelectSingleNode("Settings/ValheimPlusGameClientVersion");
                node.InnerText = settings.ValheimPlusGameClientVersion;

                XmlNode node2 = xml.SelectSingleNode("Settings/ClientInstallationPath");
                node2.InnerText = settings.ClientInstallationPath;
            }
            else
            {
                XmlNode node = xml.SelectSingleNode("Settings/ValheimPlusServerClientVersion");
                node.InnerText = settings.ValheimPlusServerClientVersion;

                XmlNode node2 = xml.SelectSingleNode("Settings/ServerInstallationPath");
                node2.InnerText = settings.ServerInstallationPath;
            }

            xml.Save("Data/Settings.xml");

            return true;
        }

        private SettingsDAL()
        {
        }
        private static SettingsDAL instance = null;
        public static SettingsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsDAL();
                }
                return instance;
            }
        }
    }
}
