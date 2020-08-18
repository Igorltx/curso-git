using System;
using System.Collections.Generic;
using System.Text;

namespace teste
{
    class Cadastro
    {
        public int ID { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cadastro(int iD, string nome, string email)
        {
            ID = iD;
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return "ID: "
                + ID
                + ", "
                + Nome
                + ", "
                + Email;
        }
    }
}
