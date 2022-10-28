using Grpc.Core;

namespace SakuraGenin.Services
{
    public class GeninSerice : Genin.GeninBase
    {
        private readonly ILogger<GeninSerice> _logger;
        public GeninSerice(ILogger<GeninSerice> logger)
        {
            _logger = logger;
        }

        public override Task<Reply> RequestGennin(Request request, ServerCallContext context)
        {
            _logger.LogInformation($"Got request from {request.Name}.");

            return Task.FromResult(new Reply
            {
                Name = Environment.MachineName
            });
        }
    }
}