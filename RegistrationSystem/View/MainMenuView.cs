﻿using RegistrationSystem.Controller;
using RegistrationSystem.Event;
using RegistrationSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem.View
{
	public partial class MainMenuView : Form, IMainMenuView
	{
		public event EventHandler OnAddButtonCliked;
		public event EventHandler<int> OnDeleteButtonClicked;
		public event EventHandler<string> OnLoadUsers;
		public event EventHandler<string> OnSaveUsers;

		private readonly IReadableApplicationModel _applicationModel;

		public MainMenuView(IReadableApplicationModel applicationModel)
		{
			InitializeComponent();

			_applicationModel = applicationModel;
			_applicationModel.OnUserAdded += UserAdded;
			_applicationModel.OnUserDeleted += UserDeleted;
			_applicationModel.OnUsersEdited += OnUsersEdited;
		}

		public void ShowSelectionMenu(string message, Action<bool> action)
		{
			var menu = new SelectionMenu(message);
			menu.ShowDialog(this);

			action?.Invoke(menu.CancelAct);
		}

		public void ShowAlert(string message)
		{
			AlertMenu alert = new AlertMenu(message);
			alert.ShowDialog(this);
		}

		private SaveMenu ShowSaveMenu()
		{
			var menu = new SaveMenu();
			menu.ShowDialog(this);

			return menu;
		}

		private void UserAdded(object sender, UserEventArgs e)
		{
			UserList.Items.Add(e.User);
			DeleteButton.Enabled = true;
		}

		private void UserDeleted(object sender, UserEventArgs e)
		{
			UserList.Items.RemoveAt(e.Index);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			OnAddButtonCliked?.Invoke(this, EventArgs.Empty);
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			OnDeleteButtonClicked?.Invoke(this, UserList.SelectedIndex);
			(sender as Button).Enabled = false;
		}

		private void OnUsersEdited(object sender, EventArgs e)
		{
			SaveButton.Enabled = true;
		}

		private void Open_Click(object sender, EventArgs e)
		{
			TrySaveUsers();
		}

		private void MainMenuView_FormClosing(object sender, FormClosingEventArgs e)
		{
			TrySaveUsers(() => e.Cancel = true);
		}

		private void TrySaveUsers(Action onCancel = null)
		{
			if (_applicationModel.UsersMustSave)
			{
				var saveMenu = ShowSaveMenu();
				if (saveMenu.CancelAct)
				{
					onCancel?.Invoke();
					return;
				}

				if (saveMenu.IsSave)
				{
					saveFileDialog1.ShowDialog();
				}
			}

			openFileDialog1.ShowDialog();
		}

		private void Save_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}

		private void UserList_SelectedIndexChanged(object sender, EventArgs e)
		{
			DeleteButton.Enabled = true;
		}

		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			if (!e.Cancel)
			{
				OnLoadUsers?.Invoke(this, openFileDialog1.FileName);
			}
		}

		private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			if (!e.Cancel)
			{
				OnSaveUsers?.Invoke(this, saveFileDialog1.FileName);
			}
		}
	}
}
