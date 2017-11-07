﻿using System.Linq;
using System.Reflection;
using ProjectAltis.Properties;

namespace ProjectAltis.Core
{
    public class ErrorReporter
    {
        public static ErrorReporter Instance => _instance ?? (_instance = new ErrorReporter());
        private static ErrorReporter _instance;

        public string Username = Settings.Instance.Username;
        public bool RandomBackgrounds = Settings.Instance.WantRandomBackgrounds;

        public string NetVersion => Assembly.GetExecutingAssembly().GetReferencedAssemblies().First(x => x.Name == "System.Core").Version.ToString();

        public string WindowsVersion => UwpHelper.RawProductName();
    }
}