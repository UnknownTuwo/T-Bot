using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace T_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            var discord = new DiscordClient(new DiscordConfiguration())
            {
                Token = Environment.GetEnvironmentVariable("DiscordToken"),
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            };
            

            await discord.ConnectAsync();
            await Task.Delay(-1);

        }
    }
}