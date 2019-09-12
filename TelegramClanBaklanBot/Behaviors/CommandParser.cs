using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramClanBaklanBot.StringExtensions;

namespace TelegramClanBaklanBot
{
    static class CommandParser
    {
        static ClanBaklanBot bot = new ClanBaklanBot();
        public static string Parse(Message message)
        {
            string response = default(string);
            if (message.Text.StartsWith("/clanbaklanbot"))
            {
                switch (message.Text.Replace(" ", "").TrimStart("/clanbaklanbot"))
                {
                    case "!qq":
                        response = $"Hello, {message.From.FirstName}!";
                        break;
                }
            }
            return response;
        }

       
    }
}
