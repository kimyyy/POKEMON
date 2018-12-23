using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
	public class PictureBoxPoke : PictureBox
	{
		private Poke poke;

		public Poke Poke
		{
			get { return poke; }
			set
			{
				poke = value;

				if(poke != null)Image = poke.bmp;
			}
		}

		private bool isMyPoke;

		public bool IsMyPoke { get {return isMyPoke; } set {isMyPoke = value; } }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PictureBoxPoke()
		{
			BorderStyle = BorderStyle.Fixed3D;
			BackColor = Color.White;
			base.DoubleClick += new System.EventHandler(PicBoxPoke_DoubleClick);
		}

		private void PicBoxPoke_DoubleClick(object sender, EventArgs e)
		{
			if (Poke == null) return;

			// StatusFormを表示
			using(var form = new StatusForm(Poke))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					// OKならポケモンを更新。
					Poke = form.Poke;
				}
			}
		}
	}
}
