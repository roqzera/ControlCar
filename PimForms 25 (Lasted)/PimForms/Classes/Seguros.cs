using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    class Seguros
    {
        private DateTime _datainicio;
        private DateTime _datavencimento;
        private decimal _valor;
        private string _seguradora;
        private int _idveiculo;

        public DateTime DataInicio
        {
            get
            {
                return _datainicio;
            }
            set
            {
                _datainicio = value;
            }
        }
        public DateTime DataVencimento
        {
            get
            {
                return _datavencimento;
            }
            set
            {
                _datavencimento = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }

        public string Seguradora
        {
            get
            {
                return _seguradora;
            }
            set
            {
                _seguradora = value;
            }
        }

        public int IdVeiculo
        {
            get
            {
                return _idveiculo;
            }
            set
            {
                _idveiculo = value;
            }
        }

        public Seguros(DateTime datainicio, DateTime datavencimento, decimal valor, string seguradora, int idveiculo)
        {
            DataInicio = datainicio;
            DataVencimento = datavencimento;
            Valor = valor;
            Seguradora = seguradora;
            IdVeiculo = idveiculo;
        }
}


}
