using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Item
    {
        public readonly static string INSERT = "INSERT INTO TB_PEDIDO (Descricao) values (@Descricao); SELECT CAST(SCOPE_IDENTITY() as int)";
        public int Id { get; set; }
        public string Mesa { get; set; }
        public Item item { get; set; }
    }
}
