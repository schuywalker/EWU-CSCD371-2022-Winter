
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture1.Tests
{
	[TestClass]
	public class PersonTests
	{
		Person person;
		string userName;
			string password = "YouKilledMyF@ther";

		[TestInitialize]
		public void Initialize()
		{
			//we get ONE test with this decorator and itll run before everything else.
			//It runs ONCE before EVERY test method.
			person = new();
			userName = "Inigo.Montoya";

		}

		[TestMethod]
		public void LoginTest_GivenValidUserNameAndPassword_SuccessfulLogin()
		{

			bool success = PersonTests.Login(userName, password);
			Assert.IsTrue(success);
		}

		[Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
		public void InvalidLogin_GivenInvalidCredential()
		{

			//password = "InvalidPwd";
			userName = "SchuylerAsplin";
			bool success = PersonTests.Login(userName, password);
			Assert.IsFalse(result);
		}

	}
}
