﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MealServices.BusinessLayer.UseCases;
using OnlineServices.Shared.MealServices.TransfertObjects;
using System;
using OnlineServices.Shared.MealServices.Interfaces;

namespace MealServices.BusinessLayerTests.UseCases.AssistanteTests
{
    [TestClass]
    public class Supplier_RemoveSupplierTests
    {
        [TestMethod()]
        public void RemoveSupplier_ThrowException_WhenSupplierIDisZero()
        {
            //ARRANGE
            var Assistante = new AssistantRole((new Mock<IMSUnitOfWork>()).Object);
            var SupplierToRemove = new SupplierTO { Id = 0, Name = "InexistantSupplier" };

            //ACT
            Assert.ThrowsException<Exception>( () => Assistante.RemoveSupplier(SupplierToRemove));
        }

        [TestMethod()]
        public void RemoveSupplier_ThrowException_WhenSupplierIsNull()
        {
            //ARRANGE
            var Assistante = new AssistantRole((new Mock<IMSUnitOfWork>()).Object);

            //ACT
            Assert.ThrowsException<ArgumentNullException>(() => Assistante.RemoveSupplier(null));
        }

        [TestMethod()]
        public void RemoveSupplier_ReturnsTrue_WhenAValidSupplierIsProvidedAndRemovedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.Remove(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IMSUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var Assistante = new AssistantRole(mockUoW.Object);
            var SupplierToRemove = new SupplierTO { Id = 10, Name = "ExistantSupplier" };

            //ACT
            var ReturnValueToAssert = Assistante.RemoveSupplier(SupplierToRemove);

            Assert.IsTrue(ReturnValueToAssert);
        }

        [TestMethod()]
        public void RemoveSupplier_SupplierRepositoryIsCalledOnce_WhenAValidSupplierIsProvidedAndRemovedInDB()
        {
            //ARRANGE
            var mockSupplierRepository = new Mock<ISupplierRepository>();
            mockSupplierRepository.Setup(x => x.Remove(It.IsAny<SupplierTO>()));

            var mockUoW = new Mock<IMSUnitOfWork>();
            mockUoW.Setup(x => x.SupplierRepository).Returns(mockSupplierRepository.Object);

            var Assistante = new AssistantRole(mockUoW.Object);
            var SupplierToRemove = new SupplierTO { Id = 10, Name = "ExistantSupplier" };

            //ACT
            Assistante.RemoveSupplier(SupplierToRemove);

            mockSupplierRepository.Verify(x => x.Remove(It.IsAny<SupplierTO>()), Times.Once);
        }
    }
}
