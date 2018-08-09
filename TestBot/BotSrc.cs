using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestBot
{
    class botSrc
    {

        ////"NDY1MjM0Nzk5NTgyMjQ4OTY2.DiKjnA.Ec61JfOjNYjjxrUwQS0AcrFv2dY"
        //protected string BotToken { get; } = "NDY1MjM0Nzk5NTgyMjQ4OTY2.DiKjnA.Ec61JfOjNYjjxrUwQS0AcrFv2dY";
        public string BotToken { get; set; }
        protected string getToken()
        {
            using (StreamReader StreamReader = File.OpenText(@"A:\C# Bots\TestBot\TestBot\TestBot\Source"))
            {
                BotToken = StreamReader.ReadLine();
                return BotToken;
            }
        }
    }
}
