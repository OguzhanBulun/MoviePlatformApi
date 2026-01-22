using MoviePlatformApi.Application.Features.CQRS.Commands.CategoryCommands;
using MoviePlatformApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHanler
    {
        private readonly AppDbContext _context;

        public RemoveCategoryCommandHanler(AppDbContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveCategoryCommand command)
        {
            var dataToDelete = await _context.Categories.FindAsync(command.CategoryId);
            _context.Categories.Remove(dataToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
