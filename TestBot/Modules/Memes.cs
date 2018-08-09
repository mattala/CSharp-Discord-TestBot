using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;

namespace TestBot.Modules
{
    //This is a meme dedicated class
    //Add All your meme related commands here
    public class Memes : ModuleBase<SocketCommandContext>
    {
        //Communist boi is my baby don't you ever come near it
        [Command("communistboi")]
        public async Task CommunistAsync()
        {
            //Needs to be sent all at once like a package can't find a way to break line lol
            await ReplyAsync(":point_up_2: :rage: :point_right: :point_right: :point_right: ");
            await ReplyAsync(":point_up_2:  :rage:  :point_up_2: :rage: :rage:");
            await ReplyAsync(":point_up_2: :point_left: :fist: :point_right: :point_down:");
            await ReplyAsync(":rage: :rage: :point_down: :rage: :point_down:");
            await ReplyAsync(":point_left: :point_left: :point_left: :rage: :point_down:");
        }
    }
}
