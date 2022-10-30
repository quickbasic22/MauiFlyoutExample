using SQLite;
using System;
using System.ComponentModel.DataAnnotations;

namespace MauiFlyoutExample.Models
{
    public class Item
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime NoteDate { get; set; }
        public bool Done { get; set; }
    }
}