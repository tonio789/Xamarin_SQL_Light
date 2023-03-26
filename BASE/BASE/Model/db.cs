using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BASE.Model
{
    [Table("Agenda")]
    class db
    {
        [PrimaryKey, AutoIncrement] public int Id { get; set; }
        [MaxLength(100)] public String Description { get; set; }
        [MaxLength(100)] public int Importancia { get; set; }
    }
}
