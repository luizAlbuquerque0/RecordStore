using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.Core.Enums
{
    public enum OrderStatusEnum
    {
        Created = 0,
        PaymentConfirmed = 1,
        WaitingForDelivery = 2,
        Completed = 3,
        Canceled = 4,
        
    }
}
