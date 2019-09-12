using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace TelegramClanBaklanBot
{
    class ClanBaklanBot
    {
        #region Private Fields
        private static TelegramBotClient _bot;
        #endregion

        #region Public Propeties
        public TelegramBotClient Bot {
            get
            {
                return _bot;
            }
        }
        #endregion

        #region Public Constructors
        public ClanBaklanBot() {
            _bot = new TelegramBotClient("977859984:AAEPHJ2rDMbrW6HZP-kHdYF8O8hRsptKSq4");
        }
        #endregion
    }
}
