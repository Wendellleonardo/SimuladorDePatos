using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPatos
{
    public class Duck
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
