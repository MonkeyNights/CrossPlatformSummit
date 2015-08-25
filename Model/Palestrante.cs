using System;

namespace Model
{
	public class Palestrante : Base
	{
		string nome;
		public string Nome {
			get {
				return nome;
			}
			set {
				nome = value;
				this.Notify ();
			}
		}

		string bio;
		public string Bio {
			get {
				return bio;
			}
			set {
				bio = value;
				this.Notify ();
			}
		}

		string urlFoto;
		public string UrlFoto {
			get {
				return urlFoto;
			}
			set {
				urlFoto = value;
				this.Notify ();

			}
		}

	}
}