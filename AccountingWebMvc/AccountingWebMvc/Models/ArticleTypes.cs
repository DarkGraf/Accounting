using System;

namespace AccountingWebMvc.Models
{
    public enum ArticleTypes : sbyte
    {
        /// <summary>
        /// Расход.
        /// </summary>
        Credit = -1,
        /// <summary>
        /// Приход.
        /// </summary>
        Debit = 1        
    }
}