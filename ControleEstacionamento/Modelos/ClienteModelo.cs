﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.Modelos {

    public class ClienteModelo {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Endereco { get; set; }
        public long Cpf { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }

        public FuncionarioModelo Funcionario { get; set; }

        public ClienteModelo() {

        }
    }
}
