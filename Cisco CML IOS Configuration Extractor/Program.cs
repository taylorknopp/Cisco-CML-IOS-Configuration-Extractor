using System;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
namespace Cisco_CML_IOS_Configuration_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("ERROR: No Path Provided");
                Environment.Exit(0);
            }
            if (args[0] == null)
            {
                Console.WriteLine("ERROR: No Path Provided");
                Environment.Exit(0);
            }
            string path = args[0];
            Regex rx = new Regex(@"[a-zA-Z]:[\\\/](?:[a-zA-Z0-9]+[\\\/])*([a-zA-Z0-9]+\.yaml)");
            var match = rx.Match(path);
            if(!match.Success)
            {
                Console.WriteLine("ERROR: Invalid Path To YML File");
                Environment.Exit(0);
            }
            string labYaml = File.ReadAllText(path);
            Console.Write(labYaml);
        }
    }
}
