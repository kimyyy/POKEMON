using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
	public partial class PartyPanel : UserControl
	{
		private Poke[] party = new Poke[6];

		public Poke[] Party
		{
			get { return party; }
			set
			{
				party = value;
				for(var i = 0;i < 6; i++)
				{
					if (party[i] == null) continue;
					pokeBoxes[i].Poke = party[i];
				}
			}
		}

		public PokePictureBox[] pokeBoxes;

		public PartyPanel()
		{
			InitializeComponent();
		}

		private void PartyPanel_Load(object sender, EventArgs e)
		{
			pokeBoxes = new PokePictureBox[6]
			{ pokePictureBox1, pokePictureBox2,pokePictureBox3,
				pokePictureBox4,pokePictureBox5, pokePictureBox6};
			foreach(PokePictureBox pokePic in pokeBoxes)
			{
				pokePic.BorderStyle = BorderStyle.Fixed3D;
				pokePic.BackColor = Color.White;
			}
		}
	}
}
