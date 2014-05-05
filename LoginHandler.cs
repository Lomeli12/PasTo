using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace PasTo {
	public class LoginHandler {
		private static string loginFile = "login.dat";
		public static void storeLoginCredientials(string user, string pass) {
			GZipStream stream = new GZipStream(new FileStream(loginFile, FileMode.Create, FileAccess.Write), CompressionMode.Compress, false);
			
			stream.WriteByte(10);
			writeString("", stream);
			stream.WriteByte(8);
			writeString("username", stream);
			writeString(user, stream);
			stream.WriteByte(8);
			writeString("pass", stream);
			writeString(pass, stream);
			stream.WriteByte(0);
			
			stream.Close();
		}
		
		public static void getLoginCredientials(MainForm form) {
			if (File.Exists(loginFile)) {
				GZipStream stream = new GZipStream(new FileStream(loginFile, FileMode.Open, FileAccess.Read), CompressionMode.Decompress, false);

				byte id = (byte)readByte(stream);
				if (id == 10) {
					readString(stream);
					bool flag = true;
					while (flag) {
						byte tagID = readByte(stream);
						if (tagID != 0) {
							if (tagID == 8) {
								string tagName = readString(stream);
								if (tagName != null) {
									string tagValue = readString(stream);
									if (tagValue != null) {
										if (tagName.Equals("username"))
											form.user.Text = tagValue;
										else if (tagName.Equals("pass"))
											form.pass.Text = tagValue;
									}
								}
							}
						} else
							flag = false;
					}
				}
				stream.Close();
			}
		}
		
		public static byte readByte(Stream stream) {
			if (stream == null)
				throw new ArgumentNullException();
			int num = stream.ReadByte();
			if (num == -1)
				throw new EndOfStreamException();
			return checked((byte)num);
		}
		
		private static void writeString(string j, Stream stream) {
			if (stream == null)
				throw new ArgumentNullException();
			if (Encoding.UTF8.GetByteCount(j) > 65535)
				throw new ArgumentException("String is too long");
			byte[] bytes = Encoding.UTF8.GetBytes(j);
			writeUShort(stream, checked((ushort)bytes.Length));
			stream.Write(bytes, 0, bytes.Length);
		}
		
		private static void writeUShort(Stream stream, ushort j) {
			if (stream == null)
				throw new ArgumentNullException();
			byte[] bytes = BitConverter.GetBytes(j);
			if (BitConverter.IsLittleEndian)
				Array.Reverse(bytes);
			stream.Write(bytes, 0, bytes.Length);
		}
		
		private static string readString(Stream stream) {
			if (stream == null)
				throw new ArgumentNullException();
			byte[] array = new byte[(int)readUShort(stream)];
			if (stream.Read(array, 0, array.Length) != array.Length)
				throw new EndOfStreamException();
			return Encoding.UTF8.GetString(array);
		}
		
		private static ushort readUShort(Stream stream) {
			if (stream == null)
				throw new ArgumentNullException();
			byte[] array = new byte[2];
			if (stream.Read(array, 0, array.Length) != array.Length)
				throw new EndOfStreamException();
			if (BitConverter.IsLittleEndian)
				Array.Reverse(array);
			return BitConverter.ToUInt16(array, 0);
		}
	}
}
