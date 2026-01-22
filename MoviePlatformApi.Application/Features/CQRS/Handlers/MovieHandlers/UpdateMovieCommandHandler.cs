using MoviePlatformApi.Application.Features.CQRS.Commands.MovieCommands;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly AppDbContext _context;

        public UpdateMovieCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async void Hanle(UpdateMovieCommand command)
        {
            var dataToUpdate = await _context.Movies.FindAsync(command.MovieId);

            dataToUpdate.Status = command.Status;
            dataToUpdate.Duration = command.Duration;
            dataToUpdate.MovieName = command.MovieName;
            dataToUpdate.Rating = command.Rating;
            dataToUpdate.CoverImageUrl = command.CoverImageUrl;
            dataToUpdate.Description = command.Description;
            dataToUpdate.CreatedYear = command.CreatedYear;

            await _context.SaveChangesAsync();
        }
    }
}
