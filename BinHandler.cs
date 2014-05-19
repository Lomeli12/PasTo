using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PasTo {
    public class BinHandler	{
        private Paste paste;
        private string pasteURL, user, password;
        public BinHandler(Paste paste) {
            this.paste = paste;
        }
        
        public BinHandler(Paste paste, string pasteUser, string pass)	{
            this.paste = paste;
            this.user = pasteUser;
            this.password = pass;
        }
        
        public async Task parsePaste() {
            switch (Program.bin) {
                case 0:
                    await this.getResponseUPB();
                    break;
                case 1:
                    if (this.user != "" & this.password != "")
                        await this.getUserKey();
                    
                    await this.getResponsePB();
                    break;
                case 2:
                    await this.getResponsePEE();
                    break;
            }
        }
        
        public string getURL() {
            return this.pasteURL;
        }
        
        public async Task getUserKey() {
            WebRequest request = WebRequest.Create("http://pastebin.com/api/api_login.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string[] byteData = { "api_dev_key=" + Program.pasteBinAPIKey,
                "api_user_name=" + Uri.EscapeDataString(this.user),
                "api_user_password=" + Uri.EscapeDataString(this.password),
            };
            byte[] byteArray = Encoding.UTF8.GetBytes(string.Join("&",byteData));
            request.ContentLength = byteArray.Length;
            try {
                using (Stream dataStream = request.GetRequestStream()) {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                using (WebResponse response = request.GetResponse()) {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
                        Program.userKey = reader.ReadToEnd();
                    }
                }
            } catch (WebException ex) {
                throw new Exception("Connection to Pastebin failed", ex);
            }
        }
        
        public async Task getResponsePEE() {
            WebRequest request = WebRequest.Create("https://paste.ee/api");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string[] byteData = { "key=" + Program.pasteeAPIKey,
                "description=" + Uri.EscapeDataString(paste.getTitle()),
                "language=" + LanguageParse.getLangByIndex(paste.getSyntax(), Program.bin),
                "paste=" + Uri.EscapeDataString(paste.getContent())
            };
            byte[] byteArray = Encoding.UTF8.GetBytes(string.Join("&",byteData));
            request.ContentLength = byteArray.Length;
            try {
                using (Stream dataStream = request.GetRequestStream()){
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                using (WebResponse response = request.GetResponse()) {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
                        string json = reader.ReadToEnd();
                        var jsonParse = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(json);
                        if (jsonParse == null)
                            return;
                        if (jsonParse.ContainsKey("errorcode"))
                            return jsonParse["error"].ToString();
                        var pasteInfo = (Dictionary<string, object>)jsonParse["paste"];
                        if (pasteInfo == null)
                            return;
                        this.pasteURL = pasteInfo["link"].ToString();
                    }
                }
            } catch (WebException ex){
                throw new Exception("Connection to Paste.ee failed", ex);
            }
        }
        
        // Thank you nikibobi
        // https://github.com/nikibobi/pastebin-csharp
        public async Task getResponsePB() {
            WebRequest request = WebRequest.Create("http://pastebin.com/api/api_post.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string[] byteData = { "api_dev_key=" + Program.pasteBinAPIKey,
                "api_option=paste",
                "api_paste_code=" + Uri.EscapeDataString(paste.getContent()),
                "api_user_key=" + Program.userKey,
                "api_paste_name=" + Uri.EscapeDataString(paste.getTitle()),
                "api_paste_format=" + LanguageParse.getLangByIndex(paste.getSyntax(), Program.bin),
                "api_paste_private=0",
                "api_paste_expire_date=N" };
            byte[] byteArray = Encoding.UTF8.GetBytes(string.Join("&",byteData));
            request.ContentLength = byteArray.Length;
            try {
                using (Stream dataStream = request.GetRequestStream()) {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                using (WebResponse response = request.GetResponse())
                    using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
                    this.pasteURL = reader.ReadToEnd();
                }
            } catch (WebException ex) {
                throw new Exception("Connection to Pastebin failed", ex);
            }
        }
        
        public async Task getResponseUPB() {
            HttpClient client = new HttpClient();
            FormUrlEncodedContent requestContent = new FormUrlEncodedContent(new [] {
                                                                                 (new KeyValuePair<string, string>("content", paste.getContent())),
                                                                                 (new KeyValuePair<string, string>("poster", paste.getAuthor())),
                                                                                 (new KeyValuePair<string, string>("syntax", LanguageParse.getLangByIndex(paste.getSyntax(), Program.bin)))
                                                                             });
            HttpResponseMessage response = await client.PostAsync("http://paste.ubuntu.com", requestContent);
            response.EnsureSuccessStatusCode();
            this.pasteURL = response.RequestMessage.RequestUri.ToString();
        }
    }
}
