
namespace WebApplication2
{
    public class DenemeService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested) {
                Console.WriteLine("sdfsdfdsf");
                await Task.Delay(1000);   
            }
            
        }
    }
}
