using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.ServerSide.Data.MovieData
{
    public class ActorService
    {
        private IEnumerable<Actor> Actors;
        private string[] _actors;

        public ActorService()
        {
            _actors = File.ReadAllLines(@".\bin\Debug\netcoreapp3.0\Data\MovieData\person_node.csv");
            Actors = _actors.Skip(1).Select(x =>
            {
                var actorAttributes = x.Split(';');
                return new Actor
                {
                    //id:ID(Person);name;born:int;poster_image
                    Id = Convert.ToInt32(actorAttributes[0]) - 1,
                    Name = actorAttributes[1],
                    Born = actorAttributes[2],
                    PosterImage = actorAttributes[3]
                };
            });
        }
          
        public Task<Actor[]> GetActorsAsync(int maxActors)
        {
            return Task.FromResult(Actors.Take(maxActors).ToArray());
        }
    }
}
