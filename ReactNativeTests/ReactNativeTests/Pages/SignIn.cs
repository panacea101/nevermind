using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;e

namespace ReactNativeTests
{
	public class SignIn : Accounts
	{
		Query signInLabel;
		Query emailAddressTextbox;
		Query passwordTextbox;
		Query forgotPasswordButton;
		Query signInButton;
		//Query orText;
		Query createAccountButton;

		public SignIn()
		{
			signInLabel = x => x.Marked("sign in label");
			emailAddressTextbox = x => x.Marked("email address textinput");
			passwordTextbox = x => x.Marked("password textinput");
			forgotPasswordButton = x => x.Marked("forgot password button");
			signInButton = x => x.Marked("sign in button");
			createAccountButton = x => x.Marked("create account button");
		}

	}
}
