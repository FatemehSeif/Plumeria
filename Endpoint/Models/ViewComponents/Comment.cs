using Application.Commetns.Commands;
using Endpoint.Models.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Models.ViewComponents
{
    public class Comment : ViewComponent
    {
        private readonly IMediator _mediator;

        public Comment(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync(CommentDto commentDto, string slug)
        {
            // Ensure you're passing CommentDto to the view
            var model = new CommentViewModel
            {
               Email = commentDto.Email,
               CatalogItemId = commentDto.CatalogItemId,    
               Commen = commentDto.Comment,
               CreatedAt = commentDto.CreatedAt,    
               Rating = commentDto.Rating,  
               Title = commentDto.Title,    
                Slug = slug
            };

            return View("Comment",model); // Ensure this is the correct model being passed
        }

    }
}
