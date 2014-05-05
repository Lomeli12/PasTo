using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasTo {
	public partial class MainForm : Form {
		private string historyFile = "pastes.txt";
		public bool shouldUpdateFile, updatePass;
		public MainForm() {
			InitializeComponent();
		}

		async void PastebtnClick(object sender, EventArgs e) {
			bool displayWarn = false;
			string warning = "";
			
			if (postName.Enabled == true && postName.Text == "") {
				displayWarn = true;
				warning += "Post name required\n";
			}
			
			if (posterName.Enabled == true && posterName.Text == "") {
				displayWarn = true;
				warning += "Poster name required!\n";
			}
			
			if (textToPaste.Text == "") {
				displayWarn = true;
				warning += "Cannot paste empty paste\n";
			}
			
			if (displayWarn) {
				MessageBox.Show(warning);
				return;
			}
			Paste newPasteFile = new Paste(postName.Text, textToPaste.Text, posterName.Text, language.SelectedIndex);
			BinHandler bin = new BinHandler(newPasteFile, user.Text, pass.Text);
			await bin.parsePaste();
			if (bin.getURL() != null) {
				Clipboard.SetText(bin.getURL());
				MessageBox.Show("Text pasted to " + bin.getURL() + " and copied to your clipboard");
				addToHistory(bin.getURL());
			}
			
			textToPaste.Clear();
			postName.Clear();
			posterName.Clear();
			language.SelectedIndex = 0;
		}

		void addToHistory(string newPaste) {
			if (newPaste != null) {
				this.pasteList.Items.Add(newPaste);
				updateHistory();
			}
			newPaste = "";
		}

		void DeleteBtnClick(object sender, EventArgs e) {
			if (this.pasteList.SelectedItem != null) {
				this.pasteList.Items.RemoveAt(this.pasteList.SelectedIndex);
				updateHistory();
			}
		}
		
		void readHistory() {
			if (File.Exists(historyFile)) {
				this.pasteList.Items.Clear();
				string line;
				StreamReader reader = new StreamReader(historyFile);
				while ((line = reader.ReadLine()) != null ) {
					this.pasteList.Items.Add(line);
				}
				reader.Close();
			} else
				File.Create(historyFile);
		}

		void updateHistory() {
			if (!File.Exists(historyFile))
				File.Create(historyFile);
			StreamWriter writer = new StreamWriter(historyFile);
			for (int i = 0; i < this.pasteList.Items.Count; i++) {
				object j = this.pasteList.Items[i];
				if (j != null && j is string)
					writer.WriteLine(((string)j));
			}
			writer.Close();
		}

		void CopyBtnClick(object sender, EventArgs e) {
			if ((this.pasteList != null)) {
				object j = this.pasteList.Items[this.pasteList.SelectedIndex];

				if (j != null && j is string) {
					Clipboard.SetText((string)j);
					MessageBox.Show(((string)j) + " has been copied to your clipboard");
				}
			}
		}

		void ClearClick(object sender, EventArgs e) {
			if (MessageBox.Show("Warning! This will earse all pastes! Are you sure?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
			                    MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false) == DialogResult.OK) {
				this.pasteList.Items.Clear();
				if (File.Exists(historyFile)) {
					File.Delete(historyFile);
					File.Create(historyFile);
				}
			}
		}

		void MainFormLoad(object sender, EventArgs e) {
			readHistory();
			LoginHandler.getLoginCredientials(this);
			this.updatePass = false;
			switch (Program.bin) {
				case 0:
					postName.Enabled = false;
					posterName.Enabled = true;
					ubuntuPasteBinOption.Checked = true;
					updateLang(LanguageParse.ubuntuNames);
					break;
				case 1:
					postName.Enabled = true;
					posterName.Enabled = false;
					pasteBinOption.Checked = true;
					updateLang(LanguageParse.pasteBinNames);
					break;
					default :
						postName.Enabled = false;
					posterName.Enabled = true;
					ubuntuPasteBinOption.Checked = true;
					updateConfig(0, LanguageParse.ubuntuNames);
					break;
			}
			this.language.SelectedIndex = 0;
			this.shouldUpdateFile = false;
			this.updatePass = false;
		}
		
		void UbuntuPasteBinOptionCheckedChanged(object sender, EventArgs e) {
			int type = 0;
			postName.Enabled = false;
			posterName.Enabled = true;
			if (Program.bin != type)
				updateConfig(type, LanguageParse.ubuntuNames);
		}
		
		void PasteBinOptionCheckedChanged(object sender, EventArgs e) {
			int type = 1;
			postName.Enabled = true;
			posterName.Enabled = false;
			if (Program.bin != type)
				updateConfig(type, LanguageParse.pasteBinNames);
		}
		
		void InfoBtnClick(object sender, EventArgs e){
			MessageBox.Show("By Anthony Lomeli © 2014\nIcon by Iconleak and used\nunder thier Free License Agreement\nhttp://iconleak.com/");
		}
		
		void updateConfig(int i, string[] lang) {
			if (Program.bin != i)
				Program.bin = i;
			this.shouldUpdateFile = true;
			updateLang(lang);
		}
		
		void updateLang(string[] lang) {
			this.language.Items.Clear();
			foreach (string langName in lang) {
				if ((this.language != null) && (this.language.Items != null))
					this.language.Items.Add(langName);
			}
			this.language.SelectedIndex = 0;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)	{
			if (this.shouldUpdateFile) {
				if (File.Exists("options.cfg"))
					File.Delete("options.cfg");
				StreamWriter writer = new StreamWriter("options.cfg");
				writer.WriteLine("'Determines what bin is used. 0 = paste.ubuntu.com; 1 = pastebin.com");
				writer.WriteLine("BinURL=" + Program.bin);
				writer.Close();
				
			}
			if (this.updatePass)
				LoginHandler.storeLoginCredientials(user.Text, pass.Text);
		}
		
		void UserTextChanged(object sender, EventArgs e){
			this.updatePass = true;
		}
		
		void PassTextChanged(object sender, EventArgs e) {
			this.updatePass = true;
		}
		
		void MainFormSizeChanged(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized)
				this.Hide();
		}
		
		void NotifyIconMouseDoubleClick(object sender, MouseEventArgs e) {
			this.Show();
			this.WindowState = FormWindowState.Normal;
		}
	}
}
