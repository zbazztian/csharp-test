using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Globomantics.CloudGame
{
    public class Program
    {

        public const string DefaultPasswordTestAdvancedSecurity = "P@55w0rd123";

        public static void Main(string[] args)
        {
            string passwd = "local secret";
            CreateHostBuilder(args).Build().Run();
        }

        public void test(){
            this.PassPhrase = "property secret";
        }

        private string passcode = "secret";

        public string PassPhrase
        { get; set; }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
