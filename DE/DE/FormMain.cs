using System;
using System.Drawing;
using System.Windows.Forms;

namespace DE
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
