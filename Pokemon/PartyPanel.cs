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

		public PictureBoxPoke[] pokeBoxes;

		public PartyPanel()
		{
			InitializeComponent();
		}

		private void PartyPanel_Load(object sender, EventArgs e)
		{
			pokeBoxes = new PictureBoxPoke[6]
			{ pokePictureBox1, pokePictureBox2,pokePictureBox3,
				pokePictureBox4,pokePictureBox5, pokePictureBox6};
			foreach(PictureBoxPoke pokePic in pokeBoxes)
			{
				pokePic.MouseDown += new System.Windows.Forms.MouseEventHandler(pokePictureBox_MouseDown);
			}
		}

		private void pokePictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				PictureBoxPoke pokebox = (PictureBoxPoke)sender;
				if (pokebox.Poke == null) return;
				var Poke = pokebox.Poke;

				DragDropEffects dde = pokebox.DoDragDrop(Poke, DragDropEffects.Copy);
			}
		}
	}
}
