using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimForms.Classes;

namespace PimForms
{
    public class Viagem
    {
        private string _nomeMotorista;
        private string _placaVeiculo;
        private DateTime _dataSaida;
        private DateTime _dataRetorno;
        private string _destino;
        private decimal _valorAdiantamento;
        private decimal _kmInicial;
        private decimal _kmFinal;
        private int _idveiculo;
        private int _idfuncionario;
        private int _idacompanhante;

        public Viagem()
        {
        }

        public Viagem(DateTime datasaida, DateTime dataentrada, string destino, decimal valoradiantamento, decimal kminicial, decimal kmfinal, int idveiculo, int idfuncionario, int idacompanhante)
        {
            DataSaida = datasaida;
            DataRetorno = dataentrada;
            Destino = destino;
            ValorAdiantamento = valoradiantamento;
            KmInicial = kminicial;
            KmFinal = kmfinal;
            IdVeiculo = idveiculo;
            IdFuncionario = idfuncionario;
            IdAcompanhante = idacompanhante;
        }

        public string NomeMotorista
        {
            get { return _nomeMotorista; }
            set { _nomeMotorista = value; }
        }

        public string PlacaVeiculo
        {
            get { return _placaVeiculo; }
            set { _placaVeiculo = value; }
        }

        public DateTime DataSaida
        {
            get
            {
                return _dataSaida;
            }
            set
            {
                _dataSaida = value;
            }
        }

        public DateTime DataRetorno
        {
            get
            {
                return _dataRetorno;
            }
            set
            {
                _dataRetorno = value;
            }
        }

        public string Destino
        {
            get
            {
                return _destino;
            }
            set
            {
                _destino = value;
            }
        }

        public decimal ValorAdiantamento
        {
            get
            {
                return _valorAdiantamento;
            }
            set
            {
                _valorAdiantamento = value;
            }
        }

        public decimal KmInicial
        {
            get
            {
                return _kmInicial;
            }
            set
            {
                _kmInicial = value;
            }
        }

        public decimal KmFinal
        {
            get
            {
                return _kmFinal;
            }
            set
            {
                _kmFinal = value;
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
        public int IdFuncionario
        {
            get
            {
                return _idfuncionario;
            }
            set
            {
                _idfuncionario = value;
            }
        }

        public int IdAcompanhante
        {
            get
            {
                return _idacompanhante;
            }
            set
            {
                _idacompanhante = value;
            }
        }
    }
}
