using MoviePlatformApi.Application.Features.CQRS.Commands.CategoryCommands;
using MoviePlatformApi.Domain.Entities;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly AppDbContext _context;
        public CreateCategoryCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });

            await _context.SaveChangesAsync();
        }
    }
}
