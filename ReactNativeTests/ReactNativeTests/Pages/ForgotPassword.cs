using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace ReactNativeTests
{
	public class ForgotPassword : Accounts
	{
		Query backArrowButton;
		Query forgotPasswordLabel;
		//Query skipButton;
		Query enterEmailText;
		Query emailAddressTextbox;
		Query sendResetEmailButton;

		public ForgotPassword()
		{
			backArrowButton = x => x.Marked("back button");
			forgotPasswordLabel = x => x.Marked("forgot password label");
			enterEmailText = x => x.Marked("Enter your email address below. If there is an account on Sothebys.com that matches it, instructions for resetting your password will be sent to that email address. label");
			emailAddressTextbox = x => x.Marked("email address textinput");
			sendResetEmailButton = x => x.Marked("send reset email button"); 
		}

		public void enterForgottenEmail()
		{
			app.Tap(enterEmailText);
			app.EnterText("fakeEmail@sothebysqa.com");
		}

		public void sendResetEmail()
		{
			app.Tap(sendResetEmailButton);
		}

		public void tapBackButton()
		{
			app.Tap(backArrowButton);
		}
	}
}
