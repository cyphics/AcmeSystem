using AcmeSystem.Business;
using AcmeSystem.Business.Contacts;
using Moq;
using System.Linq;
using System;
using System.Collections.Generic;
using Xunit;
using AcmeSystem.Presentation.ClientWeb.Controllers;
using AcmeSystem.Persistence.MockRepositories;
using AcmeSystem.Applicative.Services;
using AcmeSystem.Presentation.ClientWeb.ViewModels;

namespace AcmeSystem.Presentation.ClientWebTest
{
    public class ContactControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            // Arrange
            IContactRepository mockrepo = new ContactRepositoryMock();
            IContactServices contactServices = new ContactServices(mockrepo);

            ContactController controller = new ContactController(contactServices);
            controller.PageSize = 3;

            // Act
            ContactListViewModel result =
                controller.List(4).ViewData.Model as ContactListViewModel;

            // Assert
            Contact[] prodArray = result.Contacts.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("Tesla", prodArray[0].Nom);
            Assert.Equal("Turing", prodArray[1].Nom);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Arrange
            IContactRepository mockrepo = new ContactRepositoryMock();
            IContactServices contactServices = new ContactServices(mockrepo);

            // Arrange
            ContactController controller = new ContactController(contactServices) { PageSize = 3 };

            // Act
            ContactListViewModel result =
            controller.List(4).ViewData.Model as ContactListViewModel;

            // Assert
            PagingInfo pageInfo = result.PagingInfo;

            Assert.Equal(4, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(11, pageInfo.TotalItems);
            Assert.Equal(4, pageInfo.TotalPages);
        }
    }
}
