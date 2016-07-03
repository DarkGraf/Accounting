using System;

namespace AccountingWebMvc.Bll.Dto
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Amount { get; set; }

        public Guid ArticleId { get; set; }
        public string ArticleName { get; set; }
        public short ArticleSign { get; set; }
    }
}
