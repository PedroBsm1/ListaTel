using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
        public class Repositorio
        {
            public List<Dados> Tele { get; set; } = new List<Dados> { };

            public void Incluir(Dados tele)
            {
                Tele.Add(tele);
            }
            public void Remover(Dados tele)
            {
                Tele.Remove(tele);
            }
        }
    }
