using System;

namespace Tutorial_Interface.Lesson0
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
