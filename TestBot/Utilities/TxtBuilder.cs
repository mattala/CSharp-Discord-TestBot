using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using System.Threading.Tasks;

namespace TestBot.Utilities
{
    public static class TxtBuilder
    {
        //I Forgot what i wanted to do here please help
        public enum Colors { green, blue, red }
        public static Embed FlatBuild(string Title, string Desc, Color Clr, string Ftr = null, string ImgUrl = null)
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithColor(Clr).WithTitle(Title).WithDescription(Desc).WithFooter(Ftr).WithImageUrl(ImgUrl).WithCurrentTimestamp();
            return builder.Build();
        }
    }
}
