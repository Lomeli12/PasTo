using System;
using System.IO;
using System.Windows.Forms;

namespace PasTo {

	internal sealed class Program {

		public static int bin;
		
		public static string pasteBinAPIKey = "162d2cf151f52682fdca3db53f57feb4";
		public static string userKey = "";
		
		[STAThread]
		private static void Main(string[] args) {
			bin = readConfig();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		private static int readConfig() {
			string configFile = "options.cfg";
			int bin = 0;
			if (File.Exists(configFile)) {
				StreamReader reader = new StreamReader(configFile);
				string line;
				while ((line = reader.ReadLine()) != null ) {
					if (line.StartsWith("BinURL")) {
						string[] config = line.Split('=');
						if (config.Length >= 2) {
							bin = parseString(config[1]);
							break;
						}
					}
				}
				reader.Close();
			} else {
				StreamWriter writer = new StreamWriter(configFile);
				writer.WriteLine("'Determines what bin is used. 0 = paste.ubuntu.com; 1 = pastebin.com");
				writer.WriteLine("BinURL=0");
				writer.Close();
			}
			return bin;
		}
		
		private static int parseString(string obj) {
			try {
				return int.Parse(obj);
			} catch (Exception e) {
			}
			return 0;
		}
		
	}
}
