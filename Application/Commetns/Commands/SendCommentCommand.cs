using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Interfaces.Contexts;
using Azure.Core;
using Domain.Catalogs;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commetns.Commands
{

    public class CommentDto
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Email { get; set; }
        public int CatalogItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Rating { get; set; }
    }

    public class SendCommentCommand : IRequest<SendCommentResponseDto>
    {
        public SendCommentCommand(ComDto commentDto)
        {
            Comment = commentDto;
        }
        public ComDto Comment { get; set; }

    }

    public class SendCommentHandler : IRequestHandler<SendCommentCommand, SendCommentResponseDto>
    {

        private readonly IDataBaseContext context;
        public SendCommentHandler(IDataBaseContext context)
        {
            this.context = context;
        }

        public Task<SendCommentResponseDto> Handle(SendCommentCommand request, CancellationToken cancellationToken)
        {
            var catalogItem = context.CatalogItems.Find(request.Comment.CatalogItemId);
            CatalogItemComment comment = new CatalogItemComment
            {
                Comment = request.Comment.Comment,
                Email = request.Comment.Email,
                Title = request.Comment.Title,
                CatalogItem = catalogItem,
                CreatedAt = request.Comment.CreatedAt,
                Rating = request.Comment.Rating,


            };
            var entity = context.CatalogItemComments.Add(comment);
            context.SaveChanges();

            return Task.FromResult(new SendCommentResponseDto
            {
                Id = entity.Entity.Id
            });
        }

        //public class GetCommentsByCatalogItemIdQuery : IRequest<List<CommentDto>>
        //{
        //    public int CatalogItemId { get; }

        //    public GetCommentsByCatalogItemIdQuery(int catalogItemId)
        //    {
        //        CatalogItemId = catalogItemId;
        //    }
        //}

        //public class GetCommentsByCatalogItemIdHandler : IRequestHandler<GetCommentsByCatalogItemIdQuery, List<CommentDto>>
        //{
        //    private readonly IDataBaseContext context;

        //    public GetCommentsByCatalogItemIdHandler(IDataBaseContext context)
        //    {
        //        this.context = context;
        //    }

        //    public Task<List<CommentDto>> Handle(GetCommentsByCatalogItemIdQuery request, CancellationToken cancellationToken)
        //    {
        //        // دریافت کامنت‌ها از پایگاه‌داده
        //        var comments = context.CatalogItemComments
        //            .Where(c => c.CatalogItem.Id == request.CatalogItemId)
        //            .Select(c => new ComDto
        //            {
        //                Title = c.Title,
        //                Comment = c.Comment,
        //                Email = c.Email,
        //                Rating = c.Rating,
        //                CreatedAt = c.CreatedAt
        //            })
        //            .ToList();

        //        return Task.FromResult(comments);
        //    }
        //}



    }







    public class SendCommentResponseDto
    {
        public int Id { get; set; }
    }
}
