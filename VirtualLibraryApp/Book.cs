﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualLibraryApp
{
	public partial class Book : Form
	{


		public Book(DataView bookdata)
		{
			InitializeComponent();

			//Informacija apie knyga
			BookName.Text = bookdata[0]["BookName"].ToString();
			ISBN13.Text = bookdata[0]["ISBN13"].ToString();
			ISBN10.Text = bookdata[0]["ISBN10"].ToString();
			Author.Text = bookdata[0]["Author"].ToString();
			Publisher.Text = bookdata[0]["Publisher"].ToString();
			Published.Text = bookdata[0]["Published"].ToString();
			ListPrice.Text = bookdata[0]["ListPrice"].ToString();
			BookCoverBox.Load(bookdata[0]["CoverLink"].ToString());
		}
	}
}
