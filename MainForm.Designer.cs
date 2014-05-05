using System.Drawing;

namespace PasTo {
partial class MainForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing) {
            if (components != null) {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent() {
    	this.components = new System.ComponentModel.Container();
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    	this.label1 = new System.Windows.Forms.Label();
    	this.label2 = new System.Windows.Forms.Label();
    	this.posterName = new System.Windows.Forms.TextBox();
    	this.language = new System.Windows.Forms.ComboBox();
    	this.textToPaste = new System.Windows.Forms.TextBox();
    	this.tabs = new System.Windows.Forms.TabControl();
    	this.pasteTab = new System.Windows.Forms.TabPage();
    	this.postNameLabel = new System.Windows.Forms.Label();
    	this.postName = new System.Windows.Forms.TextBox();
    	this.pastebtn = new System.Windows.Forms.Button();
    	this.historyTab = new System.Windows.Forms.TabPage();
    	this.clear = new System.Windows.Forms.Button();
    	this.deleteBtn = new System.Windows.Forms.Button();
    	this.copyBtn = new System.Windows.Forms.Button();
    	this.pasteList = new System.Windows.Forms.ListBox();
    	this.optionTab = new System.Windows.Forms.TabPage();
    	this.infoBtn = new System.Windows.Forms.Button();
    	this.groupBox1 = new System.Windows.Forms.GroupBox();
    	this.pass = new System.Windows.Forms.TextBox();
    	this.user = new System.Windows.Forms.TextBox();
    	this.label4 = new System.Windows.Forms.Label();
    	this.label3 = new System.Windows.Forms.Label();
    	this.binsBox = new System.Windows.Forms.GroupBox();
    	this.pasteBinOption = new System.Windows.Forms.RadioButton();
    	this.ubuntuPasteBinOption = new System.Windows.Forms.RadioButton();
    	this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
    	this.tabs.SuspendLayout();
    	this.pasteTab.SuspendLayout();
    	this.historyTab.SuspendLayout();
    	this.optionTab.SuspendLayout();
    	this.groupBox1.SuspendLayout();
    	this.binsBox.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// label1
    	// 
    	this.label1.Location = new System.Drawing.Point(8, 38);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(136, 17);
    	this.label1.TabIndex = 0;
    	this.label1.Text = "Poster (30 Character Max):";
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(85, 64);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(59, 16);
    	this.label2.TabIndex = 1;
    	this.label2.Text = "Language:";
    	// 
    	// posterName
    	// 
    	this.posterName.Location = new System.Drawing.Point(150, 35);
    	this.posterName.MaxLength = 30;
    	this.posterName.Name = "posterName";
    	this.posterName.Size = new System.Drawing.Size(276, 20);
    	this.posterName.TabIndex = 2;
    	// 
    	// language
    	// 
    	this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    	this.language.FormattingEnabled = true;
    	this.language.Location = new System.Drawing.Point(150, 61);
    	this.language.Name = "language";
    	this.language.Size = new System.Drawing.Size(276, 21);
    	this.language.TabIndex = 3;
    	// 
    	// textToPaste
    	// 
    	this.textToPaste.Location = new System.Drawing.Point(8, 88);
    	this.textToPaste.Multiline = true;
    	this.textToPaste.Name = "textToPaste";
    	this.textToPaste.Size = new System.Drawing.Size(501, 230);
    	this.textToPaste.TabIndex = 4;
    	// 
    	// tabs
    	// 
    	this.tabs.Controls.Add(this.pasteTab);
    	this.tabs.Controls.Add(this.historyTab);
    	this.tabs.Controls.Add(this.optionTab);
    	this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.tabs.Location = new System.Drawing.Point(0, 0);
    	this.tabs.Name = "tabs";
    	this.tabs.SelectedIndex = 0;
    	this.tabs.Size = new System.Drawing.Size(525, 382);
    	this.tabs.TabIndex = 6;
    	// 
    	// pasteTab
    	// 
    	this.pasteTab.Controls.Add(this.postNameLabel);
    	this.pasteTab.Controls.Add(this.postName);
    	this.pasteTab.Controls.Add(this.pastebtn);
    	this.pasteTab.Controls.Add(this.posterName);
    	this.pasteTab.Controls.Add(this.textToPaste);
    	this.pasteTab.Controls.Add(this.label1);
    	this.pasteTab.Controls.Add(this.language);
    	this.pasteTab.Controls.Add(this.label2);
    	this.pasteTab.Location = new System.Drawing.Point(4, 21);
    	this.pasteTab.Name = "pasteTab";
    	this.pasteTab.Padding = new System.Windows.Forms.Padding(3);
    	this.pasteTab.Size = new System.Drawing.Size(517, 357);
    	this.pasteTab.TabIndex = 0;
    	this.pasteTab.Text = "New Paste";
    	this.pasteTab.UseVisualStyleBackColor = true;
    	// 
    	// postNameLabel
    	// 
    	this.postNameLabel.Location = new System.Drawing.Point(78, 9);
    	this.postNameLabel.Name = "postNameLabel";
    	this.postNameLabel.Size = new System.Drawing.Size(66, 20);
    	this.postNameLabel.TabIndex = 7;
    	this.postNameLabel.Text = "Post Name:";
    	// 
    	// postName
    	// 
    	this.postName.Location = new System.Drawing.Point(150, 9);
    	this.postName.Name = "postName";
    	this.postName.Size = new System.Drawing.Size(276, 20);
    	this.postName.TabIndex = 1;
    	// 
    	// pastebtn
    	// 
    	this.pastebtn.Location = new System.Drawing.Point(434, 328);
    	this.pastebtn.Name = "pastebtn";
    	this.pastebtn.Size = new System.Drawing.Size(75, 23);
    	this.pastebtn.TabIndex = 5;
    	this.pastebtn.Text = "Paste!";
    	this.pastebtn.UseVisualStyleBackColor = true;
    	this.pastebtn.Click += new System.EventHandler(this.PastebtnClick);
    	// 
    	// historyTab
    	// 
    	this.historyTab.Controls.Add(this.clear);
    	this.historyTab.Controls.Add(this.deleteBtn);
    	this.historyTab.Controls.Add(this.copyBtn);
    	this.historyTab.Controls.Add(this.pasteList);
    	this.historyTab.Location = new System.Drawing.Point(4, 21);
    	this.historyTab.Name = "historyTab";
    	this.historyTab.Padding = new System.Windows.Forms.Padding(3);
    	this.historyTab.Size = new System.Drawing.Size(517, 357);
    	this.historyTab.TabIndex = 1;
    	this.historyTab.Text = "History";
    	this.historyTab.UseVisualStyleBackColor = true;
    	// 
    	// clear
    	// 
    	this.clear.Location = new System.Drawing.Point(434, 64);
    	this.clear.Name = "clear";
    	this.clear.Size = new System.Drawing.Size(75, 23);
    	this.clear.TabIndex = 10;
    	this.clear.Text = "Clear All";
    	this.clear.UseVisualStyleBackColor = true;
    	this.clear.Click += new System.EventHandler(this.ClearClick);
    	// 
    	// deleteBtn
    	// 
    	this.deleteBtn.Location = new System.Drawing.Point(434, 35);
    	this.deleteBtn.Name = "deleteBtn";
    	this.deleteBtn.Size = new System.Drawing.Size(75, 23);
    	this.deleteBtn.TabIndex = 9;
    	this.deleteBtn.Text = "Delete Link";
    	this.deleteBtn.UseVisualStyleBackColor = true;
    	this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
    	// 
    	// copyBtn
    	// 
    	this.copyBtn.Location = new System.Drawing.Point(434, 6);
    	this.copyBtn.Name = "copyBtn";
    	this.copyBtn.Size = new System.Drawing.Size(75, 23);
    	this.copyBtn.TabIndex = 8;
    	this.copyBtn.Text = "Copy Link";
    	this.copyBtn.UseVisualStyleBackColor = true;
    	this.copyBtn.Click += new System.EventHandler(this.CopyBtnClick);
    	// 
    	// pasteList
    	// 
    	this.pasteList.FormattingEnabled = true;
    	this.pasteList.Location = new System.Drawing.Point(8, 6);
    	this.pasteList.Name = "pasteList";
    	this.pasteList.Size = new System.Drawing.Size(420, 342);
    	this.pasteList.TabIndex = 7;
    	// 
    	// optionTab
    	// 
    	this.optionTab.Controls.Add(this.infoBtn);
    	this.optionTab.Controls.Add(this.groupBox1);
    	this.optionTab.Controls.Add(this.binsBox);
    	this.optionTab.Location = new System.Drawing.Point(4, 21);
    	this.optionTab.Name = "optionTab";
    	this.optionTab.Size = new System.Drawing.Size(517, 357);
    	this.optionTab.TabIndex = 2;
    	this.optionTab.Text = "Options";
    	this.optionTab.UseVisualStyleBackColor = true;
    	// 
    	// infoBtn
    	// 
    	this.infoBtn.Location = new System.Drawing.Point(434, 323);
    	this.infoBtn.Name = "infoBtn";
    	this.infoBtn.Size = new System.Drawing.Size(75, 23);
    	this.infoBtn.TabIndex = 15;
    	this.infoBtn.Text = "About";
    	this.infoBtn.UseVisualStyleBackColor = true;
    	this.infoBtn.Click += new System.EventHandler(this.InfoBtnClick);
    	// 
    	// groupBox1
    	// 
    	this.groupBox1.Controls.Add(this.pass);
    	this.groupBox1.Controls.Add(this.user);
    	this.groupBox1.Controls.Add(this.label4);
    	this.groupBox1.Controls.Add(this.label3);
    	this.groupBox1.Location = new System.Drawing.Point(8, 88);
    	this.groupBox1.Name = "groupBox1";
    	this.groupBox1.Size = new System.Drawing.Size(501, 73);
    	this.groupBox1.TabIndex = 1;
    	this.groupBox1.TabStop = false;
    	this.groupBox1.Text = "PasteBin Account";
    	// 
    	// pass
    	// 
    	this.pass.Location = new System.Drawing.Point(78, 42);
    	this.pass.Name = "pass";
    	this.pass.Size = new System.Drawing.Size(417, 20);
    	this.pass.TabIndex = 14;
    	this.pass.UseSystemPasswordChar = true;
    	this.pass.TextChanged += new System.EventHandler(this.PassTextChanged);
    	// 
    	// user
    	// 
    	this.user.Location = new System.Drawing.Point(78, 16);
    	this.user.Name = "user";
    	this.user.Size = new System.Drawing.Size(417, 20);
    	this.user.TabIndex = 13;
    	this.user.TextChanged += new System.EventHandler(this.UserTextChanged);
    	// 
    	// label4
    	// 
    	this.label4.Location = new System.Drawing.Point(6, 42);
    	this.label4.Name = "label4";
    	this.label4.Size = new System.Drawing.Size(57, 16);
    	this.label4.TabIndex = 1;
    	this.label4.Text = "Password: ";
    	// 
    	// label3
    	// 
    	this.label3.Location = new System.Drawing.Point(6, 16);
    	this.label3.Name = "label3";
    	this.label3.Size = new System.Drawing.Size(66, 16);
    	this.label3.TabIndex = 0;
    	this.label3.Text = "User Name: ";
    	// 
    	// binsBox
    	// 
    	this.binsBox.Controls.Add(this.pasteBinOption);
    	this.binsBox.Controls.Add(this.ubuntuPasteBinOption);
    	this.binsBox.Location = new System.Drawing.Point(8, 3);
    	this.binsBox.Name = "binsBox";
    	this.binsBox.Size = new System.Drawing.Size(501, 79);
    	this.binsBox.TabIndex = 0;
    	this.binsBox.TabStop = false;
    	this.binsBox.Text = "Bins";
    	// 
    	// pasteBinOption
    	// 
    	this.pasteBinOption.Location = new System.Drawing.Point(6, 49);
    	this.pasteBinOption.Name = "pasteBinOption";
    	this.pasteBinOption.Size = new System.Drawing.Size(489, 24);
    	this.pasteBinOption.TabIndex = 12;
    	this.pasteBinOption.Text = "pastebin.com";
    	this.pasteBinOption.UseVisualStyleBackColor = true;
    	this.pasteBinOption.CheckedChanged += new System.EventHandler(this.PasteBinOptionCheckedChanged);
    	// 
    	// ubuntuPasteBinOption
    	// 
    	this.ubuntuPasteBinOption.Location = new System.Drawing.Point(6, 19);
    	this.ubuntuPasteBinOption.Name = "ubuntuPasteBinOption";
    	this.ubuntuPasteBinOption.Size = new System.Drawing.Size(489, 24);
    	this.ubuntuPasteBinOption.TabIndex = 11;
    	this.ubuntuPasteBinOption.Text = "paste.ubuntu.com (default)";
    	this.ubuntuPasteBinOption.UseVisualStyleBackColor = true;
    	this.ubuntuPasteBinOption.CheckedChanged += new System.EventHandler(this.UbuntuPasteBinOptionCheckedChanged);
    	// 
    	// notifyIcon
    	// 
    	this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
    	this.notifyIcon.Text = "PasTo";
    	this.notifyIcon.Visible = true;
    	this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseDoubleClick);
    	// 
    	// MainForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(525, 382);
    	this.Controls.Add(this.tabs);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
    	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    	this.MaximizeBox = false;
    	this.Name = "MainForm";
    	this.Text = "PasTo";
    	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
    	this.Load += new System.EventHandler(this.MainFormLoad);
    	this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
    	this.tabs.ResumeLayout(false);
    	this.pasteTab.ResumeLayout(false);
    	this.pasteTab.PerformLayout();
    	this.historyTab.ResumeLayout(false);
    	this.optionTab.ResumeLayout(false);
    	this.groupBox1.ResumeLayout(false);
    	this.groupBox1.PerformLayout();
    	this.binsBox.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox user;
    public System.Windows.Forms.TextBox pass;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button infoBtn;
    private System.Windows.Forms.TextBox postName;
    private System.Windows.Forms.Label postNameLabel;
    private System.Windows.Forms.RadioButton ubuntuPasteBinOption;
    private System.Windows.Forms.RadioButton pasteBinOption;
    private System.Windows.Forms.GroupBox binsBox;
    private System.Windows.Forms.TabPage optionTab;
    private System.Windows.Forms.ListBox pasteList;
    private System.Windows.Forms.Button copyBtn;
    private System.Windows.Forms.Button deleteBtn;
    private System.Windows.Forms.Button clear;
    private System.Windows.Forms.TabPage historyTab;
    private System.Windows.Forms.Button pastebtn;
    private System.Windows.Forms.TabPage pasteTab;
    private System.Windows.Forms.TabControl tabs;
    private System.Windows.Forms.TextBox textToPaste;
    private System.Windows.Forms.ComboBox language;
    private System.Windows.Forms.TextBox posterName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

}
}
