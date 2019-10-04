using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento.Models
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm");
        }

        public string dadosCompletos()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm") + " - " + DataAtend.ToString("dd/MM/yyyy") + " - " + HoraAtend.ToString("HH:MM");
        }
        
    }
}
