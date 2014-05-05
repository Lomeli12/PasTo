using System;

namespace PasTo {
	public class Paste {
		private string title;
		private string content;
		private string author;
		private int syntax;
		
		public Paste() {
			this.title = this.content = "";
			this.syntax = 0;
			this.author = "Guest";
		}
		
		public Paste(string i, string content) {
			this.title = i;
			this.content = content;
			this.author = "Guest";
			this.syntax = 0;
		}
		
		public Paste(string i, string content, string author) {
			this.title = i;
			this.content = content;
			this.author = author;
			this.syntax = 0;
		}
		
		public Paste(string i, string content, string author, int syntax) {
			this.title = i;
			this.content = content;
			this.author = author;
			this.syntax = syntax;
		}
		
		public string getTitle() {
			return this.title;
		}
		
		public string getContent() {
			return this.content;
		}
		
		public string getAuthor() {
			return this.author;
		}
		
		public int getSyntax() {
			return this.syntax;
		}
	}
}
