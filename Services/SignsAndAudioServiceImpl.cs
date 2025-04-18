using Grpc.Core;
using System.Text;
using SignsAndAudioService;

namespace SignsAndAudioService
{
    public class SignsAndAudioServiceImpl : SignsAndAudioService.SignsAndAudioServiceBase
    {
        public override Task<MessageReply> ReceiveMessages(MessageRequest request, ServerCallContext context)
        {
            var message = Encoding.UTF8.GetString(request.Data.ToByteArray());
            Console.WriteLine($"[SAAS] Received: {message}");

            return Task.FromResult(new MessageReply { Status = "OK" });
        }
    }
}
