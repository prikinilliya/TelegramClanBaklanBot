using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;
using TelegramClanBaklanBot.StringExtensions;

namespace TelegramClanBaklanBot
{
    static class EventsHandlers
    {
        static ClanBaklanBot bot = new ClanBaklanBot();

        public static void OnMessage(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message == null || message.Type != MessageType.Text)
                return;

            string response = CommandParser.Parse(message);


            if (response != string.Empty)
            {
                bot.Bot.SendTextMessageAsync(message.From.Id, response);
            }
        }
    }
}
