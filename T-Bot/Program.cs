using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace T_Bot
{
    class Program
    {
        static async Task Main(string[] args) => await new Program().InitBot(args);

        private async Task InitBot(string[] args)
        {
            var discord = new DiscordClient(new DiscordConfiguration
            {
                Token = Environment.GetEnvironmentVariable("DiscordToken"),
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });
            
            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}