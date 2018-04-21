using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Tipo
    {
        public int? Id { get; set; }
        public string Descricao { get; set; }

        public Tipo() { }

        public Tipo(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }
    }
}
