/*
 * Создано в SharpDevelop.
 * Пользователь: zernova.ea0799
 * Дата: 29.10.2022
 * Время: 14:40
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DE
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void ButtonInputClick(object sender, EventArgs e)
		{
			FormMain formMain = new FormMain();
			formMain.Show();
			this.Hide();
		}
	}
}
