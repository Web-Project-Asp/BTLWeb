﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Web_BTL.Models;

namespace Web_BTL.Models
{
    public class CustomerModel : UserModel
    {
        public CustomerModel() {
            Reviews = new List<ReviewModel>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CustomerId { get; set; }
        public virtual ICollection<ReviewModel> Reviews { get; set; } // liên kết đến bảng review
        public virtual int? HistoryListId { get; set; } // khoá phụ bảng History List
        public virtual int? FavoriteListId { get; set; } // khoá phụ bảng Favorite List
        public virtual int? WatchListId { get; set; } // khoá phụ bảng Watch List
        public virtual WatchListModel? WatchList { get; set; }
    }
}
