using foododering.DAO;
using foododering.Model;

namespace foododering.Controller
{
    public sealed class DeliveryController
    {
        private readonly DeliveryDao deliveryDao = new();

        public Task<IReadOnlyList<DeliveryModel>> GetDeliveriesAsync() => deliveryDao.GetAllAsync();

        public Task AssignAsync(int orderId, int deliveryPersonId)
        {
            if (orderId <= 0) throw new ArgumentOutOfRangeException(nameof(orderId));
            if (deliveryPersonId <= 0) throw new ArgumentOutOfRangeException(nameof(deliveryPersonId));
            return deliveryDao.InsertAsync(orderId, deliveryPersonId);
        }

        public Task UpdateStatusAsync(int deliveryId, string status)
        {
            if (deliveryId <= 0) throw new ArgumentOutOfRangeException(nameof(deliveryId));
            return deliveryDao.UpdateStatusAsync(deliveryId, status);
        }

        public Task DeleteAsync(int deliveryId)
        {
            if (deliveryId <= 0) throw new ArgumentOutOfRangeException(nameof(deliveryId));
            return deliveryDao.DeleteAsync(deliveryId);
        }
    }
}
