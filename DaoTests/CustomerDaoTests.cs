using DataAccess;
using Model;

namespace DaoTests
{
    public class CustomerDaoTests
    {
        [Fact]
        public void TestGetOrderSuccess()
        {
            // Arrange
            OrderDao orderDao = new OrderDao();

            // Act
            Order? test = orderDao.GetById(2);

            // Assert
            Assert.NotNull(test);
        }

        [Fact]
        public void TestDeleteOrderSuccess()
        {
            // Arrange
            OrderDao dao = new OrderDao();
            Order? test = dao.GetById(1);

            // Act
            if (test != null)
            {
                dao.Delete(test);
            }

            // Assert
            Assert.Null(dao.GetById(1));
        }
    }
}