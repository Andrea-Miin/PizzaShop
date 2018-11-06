using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment : EntityBase
    {
        public string Text { get; set; }
        public byte Punctuacion { get; set; }
        public DateTime Date { get; set; }
        public int Id_Pizza { get; set; }
    }
}
