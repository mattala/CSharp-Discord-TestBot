using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Commands;
using System.Threading.Tasks;
using TestBot.Utilities;

namespace TestBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Test", false, TxtBuilder.FlatBuild("Testing!", "Description...!", Color.Blue, "Footer",
                    "https://i.kym-cdn.com/photos/images/original/000/495/461/be9.gif"));
        }
    }
}
