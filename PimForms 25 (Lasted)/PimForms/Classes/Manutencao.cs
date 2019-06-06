using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    public class Manutencao
    {
        private int _idVeiculo;
        private string _placa;
        private string _tipo;
        private decimal _valor;
        private string _local;
        private string _descricao;
        private DateTime _data;
        private decimal _quilometragem;

        public Manutencao()
        {
        }

        public Manutencao(int idVeiculo, string placa, string tipo, decimal valor, string local, string descricao, DateTime data, decimal quilometragem)
        {
            IdVeiculo = idVeiculo;
            Placa = placa;
            Tipo = tipo;
            Valor = valor;
            Local = local;
            Descricao = descricao;
            Data = data;
            Quilometragem = quilometragem;
        }

        public int IdVeiculo
        {
            get { return _idVeiculo; }
            set { _idVeiculo = value; }
        }

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string Local
        {
            get { return _local; }
            set { _local = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public decimal Quilometragem
        {
            get { return _quilometragem; }
            set { _quilometragem = value; }
        }
    }
}
