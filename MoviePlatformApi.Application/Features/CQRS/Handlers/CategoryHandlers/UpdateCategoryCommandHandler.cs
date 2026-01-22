using MoviePlatformApi.Application.Features.CQRS.Commands.CategoryCommands;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly AppDbContext _context;

        public UpdateCategoryCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async void Handle(UpdateCategoryCommand command)
        {
            var dataToUpdate = await _context.Categories.FindAsync(command.CategoryId);

            dataToUpdate.CategoryName = command.CategoryName;

            await _context.SaveChangesAsync();
        }
    }
}
