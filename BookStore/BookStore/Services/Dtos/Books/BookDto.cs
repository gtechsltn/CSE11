﻿using BookStore.Entities.Books;
using Volo.Abp.Application.Dtos;

namespace BookStore.Services.Dtos.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

    }
}
