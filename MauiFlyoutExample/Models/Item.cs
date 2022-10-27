using SQLite;
using System;

namespace MauiFlyoutExample.Models
{
    public class Item
    {
        [PrimaryKey]
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public DateTime NoteDate { get; set; }
        public bool Done { get; set; }
    }
}