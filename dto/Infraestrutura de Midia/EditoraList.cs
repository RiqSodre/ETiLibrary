using System;
using System.Collections.Generic;

namespace DTO.Infraestrutura_de_Midia
{
    public class EditoraList : List<Editora>
    {
        public static implicit operator EditoraList(Editora v)
        {
            throw new NotImplementedException();
        }
    }
}
