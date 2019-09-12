using System;

namespace TelegramClanBaklanBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ClanBaklanBot bot = new ClanBaklanBot();
            Initializer.InitializeEvents(bot.Bot);
            bot.Bot.StartReceiving();

            Console.ReadLine();
        }
    }
}
