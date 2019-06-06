using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    public class Custo
    {
        private int _idViagem;
        private decimal _custoAbastecimento;
        private decimal _custoPedagio;
        private decimal _custoEstacionamento;
        private decimal _custoAluguel;

        public Custo(int idViagem, decimal custoAbastecimento, decimal custoPedagio, decimal custoEstacionamento, decimal custoAluguel)
        {
            IdViagem = idViagem;
            CustoAbastecimento = custoAbastecimento;
            CustoPedagio = custoPedagio;
            CustoEstacionamento = custoEstacionamento;
            CustoAluguel = custoAluguel;
        }
        public int IdViagem
        {
            get { return _idViagem; }
            set { _idViagem = value; }
        }

        public decimal CustoAbastecimento
        {
            get { return _custoAbastecimento; }
            set { _custoAbastecimento = value; }
        }

        public decimal CustoPedagio
        {
            get { return _custoPedagio; }
            set { _custoPedagio = value; }
        }

        public decimal CustoEstacionamento
        {
            get { return _custoEstacionamento; }
            set { _custoEstacionamento = value; }
        }

        public decimal CustoAluguel
        {
            get { return _custoAluguel; }
            set { _custoAluguel = value; }
        }

    }
}
