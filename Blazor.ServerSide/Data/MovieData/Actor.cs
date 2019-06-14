using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ServerSide.Data.MovieData
{
    public class Actor
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Born { get; internal set; }
        public string PosterImage { get; internal set; }
    }
}
