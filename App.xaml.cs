using System;
using System.IO;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AIDE2
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new AppShell();
		}
	}
}