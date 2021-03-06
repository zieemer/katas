﻿using Checkout.Contracts;
using NUnit.Framework;

namespace Checkout.Tests
{
    [TestFixture]
    public class DependencyResolverTest
    {
        [SetUp]
        public void Setup()
        {
            DependencyConfig.Setup();


        }
        [Test]
        public void ShouldDependencyRosolverWork()
        {
            var checkout = DependencyConfig.GetInstance<ICheckout>();
            Assert.True(checkout.GetType() == typeof(Checkout.Services.Checkout));

        }

    }
}
