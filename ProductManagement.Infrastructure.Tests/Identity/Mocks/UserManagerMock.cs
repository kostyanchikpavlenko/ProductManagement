﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;
using ProductManagement.Infrastructure.Identity.Models;

namespace ProductManagement.Infrastructure.Tests.Identity.Mocks;

public class FakeUserManager : UserManager<ApplicationUser>
{
    public FakeUserManager()
        : base(
            new Mock<IUserStore<ApplicationUser>>().Object,
            new Mock<Microsoft.Extensions.Options.IOptions<IdentityOptions>>().Object,
            new Mock<IPasswordHasher<ApplicationUser>>().Object,
            new IUserValidator<ApplicationUser>[0],
            new IPasswordValidator<ApplicationUser>[0],
            new Mock<ILookupNormalizer>().Object,
            new Mock<IdentityErrorDescriber>().Object,
            new Mock<IServiceProvider>().Object,
            new Mock<ILogger<UserManager<ApplicationUser>>>().Object)
    { }
}