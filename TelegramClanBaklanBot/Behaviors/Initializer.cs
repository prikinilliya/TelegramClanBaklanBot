using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramClanBaklanBot
{
    static class Initializer
    {
        public static void InitializeEvents(TelegramBotClient bot)
        {
            bot.OnMessage += EventsHandlers.OnMessage;
        }
    }
}
