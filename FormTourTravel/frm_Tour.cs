using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace FormTourTravel
{
	public partial class frm_Tour : XtraForm
	{
		private TourBLL tourBLL = new TourBLL();
		public frm_Tour()
		{
			InitializeComponent();
		}
	}
}
