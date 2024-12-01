using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gerenciamento_despesas_domesticas
{
    public  class Despesas
    {
        public string descricao { get; set; }

        public string valor { get; set; }

        public string categoria { get; set; }

        public DateTime date { get; set; }


        public Despesas(string descricao,  string valor, string categoria, DateTime date)
        {
            this.descricao = descricao;
            this.valor=valor;
            this.categoria = categoria;
            this.date = date;


        }

        public Despesas() 
        {

        }

        public string Serializer(Despesas despesas)
        {
            return JsonConvert.SerializeObject(despesas);
        }

        public static Despesas Deserializar(string json)
        {
            return JsonConvert.DeserializeObject<Despesas>(json);
        }


    }
}
