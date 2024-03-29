﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento.Models
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;
        
        public Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            id = 0;
            atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }

        

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count == 0) return false;
            Senha aux = filaSenhas.Dequeue();
            aux.DataAtend = DateTime.Now;
            aux.HoraAtend = DateTime.Now;
            atendimentos.Enqueue(aux);
            return true;
        }

    }
}
