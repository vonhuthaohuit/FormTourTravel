﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
	public class DiemDuLichBLL
	{
		private readonly DiemDuLichDAL diemDuLichDAL = new DiemDuLichDAL();
		public List<diemdulich> LayDanhSachDiemDuLich()
		{
			return diemDuLichDAL.LayDanhSachDiemDuLich();
		}
	}
}
