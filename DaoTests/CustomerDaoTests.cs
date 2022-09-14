using DataAccess;
using DataAccess.MemoryDaos;
using Model;

namespace DaoTests
{
    public class CustomerDaoTests
    {
        [Fact]
        public void TestGetOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();

            // Act
            Order? test = orderDao.GetById(2);

            // Assert
            Assert.NotNull(test);
        }

        [Fact]
        public void TestDeleteOrderSuccess()
        {
            // Arrange
            IDao<Order> orderDao = DaoFactory.CreateOrderDao();
            Order? test = orderDao.GetById(1);

            // Act
            if (test != null)
            {
                orderDao.Delete(test);
            }

            // Assert
            Assert.Null(orderDao.GetById(1));
        }
    }
}