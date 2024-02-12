using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatQueue
{
    public class Menu
    {
        private TQueue<Message> _queue = null!;

        public Menu() {
            _queue = new TQueue<Message>(10);
        }

        public void HandleEnqueueMessage() {

            try
            {
                Console.WriteLine("Enter the message : ");
                string content = Console.ReadLine() ?? string.Empty;
                _queue.Enqueue(new Message
                {
                    Content = content,
                    MessageId = new Random().Next(1000),
                    TimeStamp = DateTime.Now,
                    SourceId = new Random().Next(1000),
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}"); 
            }

        }
        public void HandleDequeueMessage()
        {
            try
            {
                Message dequeuedMessage = _queue.Dequeue();
                Console.WriteLine($"Dequeued message: ID {dequeuedMessage.MessageId}, Content: {dequeuedMessage.Content}, TimeStamp: {dequeuedMessage.TimeStamp}, SourceId: {dequeuedMessage.SourceId}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public void HandleQueueStatus()
        {
            if(_queue.IsEmpty)
            {
                Console.WriteLine("Queue is empty");
            }
            else if( _queue.IsFull) 
            {
                Console.WriteLine("Queue is full");
            }else {

                Console.WriteLine("Queue is yet be fulled ");
            }
        }
    }
}
