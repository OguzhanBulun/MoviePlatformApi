using MoviePlatformApi.Application.Features.CQRS.Commands.MovieCommands;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHanler
    {
        private readonly AppDbContext _context;
        public RemoveMovieCommandHanler(AppDbContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveMovieCommand command)
        {
            var dataToDelete = await _context.Movies.FindAsync(command.MovieId);
            _context.Movies.Remove(dataToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
