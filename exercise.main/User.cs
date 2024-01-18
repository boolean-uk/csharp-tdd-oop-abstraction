using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
	public class User
	{
		private string _email;
		private string _password;
		private bool _enabled = false;

		public bool SetPassword(string password)
		{
			if (password.Length > 7)
			{
				_password = password;
				return true;
			}

			Console.WriteLine("Password is too short!");
			return false;
		}

		public bool SetEmail(string email)
		{
			if (email.Contains('@'))
			{
				_email = email;
				return true;
			}

			Console.WriteLine("Email must contain '@'!");
			return false;
		}

		public void EnableUser()
		{
			_enabled = true;
		}

		public bool IsEnabled()
		{
			return _enabled;
		}

		public bool LogIn()
		{
			return IsEnabled();
		}
	}
}
