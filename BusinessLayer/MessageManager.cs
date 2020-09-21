using BusinessLayer.Interfaces;

namespace BusinessLayer
{
    public class MessageManager : IMessageManager
    {
        public MessageManager()
        {

        }
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;

        }
    }
}
