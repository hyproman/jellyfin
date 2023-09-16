using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBrowser.Model.Dto;
using MediaBrowser.Model.Entities;

namespace Jellyfin.Server.Implementations.Events.Consumers.Session
{
    internal class Utils
    {
        internal static string GetItemName(BaseItemDto item)
        {
            if (item.MediaType == MediaType.Video)
            {
                return "a video item";
            }
            else if (item.MediaType == MediaType.Audio)
            {
                return "an audio item";
            }
            else
            {
                return "an item";
            }
        }
    }
}
