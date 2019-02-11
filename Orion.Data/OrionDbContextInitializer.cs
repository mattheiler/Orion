using System.Threading.Tasks;

namespace Orion.Data
{
    public class OrionDbContextInitializer
    {
        public async Task Initialize()
        {
            await Task.Yield();
        }
    }
}