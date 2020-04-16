using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
	public partial class NoticeForm : Form
	{
		private string Message;

		public NoticeForm(string message)
		{
			InitializeComponent();
			Message = message;
		}

		private void NoticeForm_Load(object sender, EventArgs e)
		{
			label1.Text = Message;
		}
	}
}
