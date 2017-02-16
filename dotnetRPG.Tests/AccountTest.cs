//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Xunit;
//using dotnetRPG.ViewModels;
//using Microsoft.AspNetCore.Identity;
//using dotnetRPG.Controllers;
//using Moq;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using dotnetRPG.Models;

//namespace dotnetRPG.Tests
//{
//    public class UserTest
//    {
//        public void Dispose()
//        {
//            // insert disposal code
//        }

//        public static Mock<SignInManager<TUser>> MockSignInManager<TUser>() where TUser : class
//        {
//            var context = new Mock<HttpContext>();
//            var manager = MockUserManager<TUser>();
//            return new Mock<SignInManager<TUser>>(manager.Object,
//                new HttpContextAccessor { HttpContext = context.Object },
//                new Mock<IUserClaimsPrincipalFactory<TUser>>().Object,
//                null, null)
//            { CallBase = true };
//        }

//        public static Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
//        {
//            IList<IUserValidator<TUser>> UserValidators = new List<IUserValidator<TUser>>();
//            IList<IPasswordValidator<TUser>> PasswordValidators = new List<IPasswordValidator<TUser>>();

//            var store = new Mock<IUserStore<TUser>>();
//            UserValidators.Add(new UserValidator<TUser>());
//            PasswordValidators.Add(new PasswordValidator<TUser>());
//            var mgr = new Mock<UserManager<TUser>>(store.Object, null, null, UserValidators, PasswordValidators, null, null, null, null, null);
//            return mgr;
//        }

//        [Fact]
//        public async void User_CreateAccount_Test()
//        {
//            var MockUserManager = MockUserManager<ApplicationUser>();
//            var MockSignInManager = MockSignInManager<ApplicationUser>();

//            var mockContext = new Mock<ApplicationDbContext>();

//            AccountController controller = new AccountController(MockUserManager.Object, MockSignInManager.Object, mockContext.Object);
//            //var registration = new RegisterViewModel();

//            var user = new ApplicationUser { UserName = "moocowabunga@gmail.com" };
//            IdentityResult result = await controller._userManager.CreateAsync(user, "moopass");
//            bool successful = false;

//            if (result.Succeeded)
//            {
//                successful = true;
//            }

//            Assert.Equal(true, successful);
//        }

//        //[Fact]
//        //public async void User_EditAccount_Test()
//        //{
//        //    var MockUserManager = MockUserManager<ApplicationUser>();
//        //    var MockSignInManager = MockSignInManager<ApplicationUser>();

//        //    var mockContext = new Mock<ApplicationDbContext>();

//        //    AccountController controller = new AccountController(MockUserManager.Object, MockSignInManager.Object, mockContext.Object);

//        //    var user = new ApplicationUser { UserName = "moocowabunga@gmail.com" };
//        //    IdentityResult result = await controller._userManager.CreateAsync(user, "moopass");

//        //    Assert.Equal(true, result);
//        //}
//    }
//}
