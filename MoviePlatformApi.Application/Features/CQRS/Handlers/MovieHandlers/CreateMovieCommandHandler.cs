using MoviePlatformApi.Application.Features.CQRS.Commands.CategoryCommands;
using MoviePlatformApi.Application.Features.CQRS.Commands.MovieCommands;
using MoviePlatformApi.Domain.Entities;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly AppDbContext _context;

        public CreateMovieCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async void Handle(CreateMovieCommand command)
        {
            _context.Add(new Movie
            {
                CoverImageUrl = command.CoverImageUrl,
                CreatedYear = command.CreatedYear,
                Description = command.Description,
                Duration = command.Duration,
                MovieName = command.MovieName,
                Rating = command.Rating,
                ReleaseDate = command.ReleaseDate,
                Status = command.Status,
            });

            await _context.SaveChangesAsync();
        }
    }
}
