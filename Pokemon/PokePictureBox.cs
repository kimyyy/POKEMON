using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
	public class PokePictureBox : PictureBox
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

		public PokePictureBox()
		{

		}
	}
}
