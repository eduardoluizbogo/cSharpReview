using cSharpReview._11___Inheritance.Entities;
using cSharpReview._7___Enum.Entities;
using cSharpReview._7___Enum.Entities.Enums;

namespace cSharpReview.Enum
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine("order: " + order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);
        }
    }
}
