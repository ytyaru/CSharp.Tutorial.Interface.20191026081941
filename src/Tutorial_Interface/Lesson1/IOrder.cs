using System;

namespace Tutorial_Interface.Lesson1
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
