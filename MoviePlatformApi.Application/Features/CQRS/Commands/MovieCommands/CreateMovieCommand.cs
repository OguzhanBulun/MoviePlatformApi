using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePlatformApi.Application.Features.CQRS.Commands.MovieCommands
{
    public class CreateMovieCommand
    {
        public int Rating { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreatedYear { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
