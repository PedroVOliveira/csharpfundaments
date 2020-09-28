using System;


namespace TypeEnum.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing = 1,
        Shipeed = 2,
        Delivered = 3,

    }
}
