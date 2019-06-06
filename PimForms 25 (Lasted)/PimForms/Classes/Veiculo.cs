using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    public class Veiculo
    {
        private string _placa;
        private string _numerorenavam;
        private string _marca;
        private string _modelo;
        private string _motor;
        private string _cor;
        private string _ano;
        private decimal _quilometragem;
        private string _tipodeveiculo;
        private string _status;

        public string Placa
        {
            get
            {
                return _placa;
            }

            set
            {
                if (IsPlaca(value) == true)
                {
                    _placa = value;
                }
            }
        }

        public bool IsPlaca(string placa)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

            if (regex.IsMatch(placa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string NumeroRenavam
        {
            get
            {
                return _numerorenavam;
            }
            set
            {
                if (IsRenavam(value) == true)
                {
                    _numerorenavam = value;
                }
            }
        }

        public bool IsRenavam(string renavam)
        {

            if (string.IsNullOrEmpty(renavam.Trim())) return false;

            int[] d = new int[11];
            string sequencia = "3298765432";
            string SoNumero = Regex.Replace(renavam, "[^0-9]", string.Empty);

            if (string.IsNullOrEmpty(SoNumero)) return false;

            //verificando se todos os numeros são iguais **************************
            if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;
            SoNumero = Convert.ToInt64(SoNumero).ToString("00000000000");

            int v = 0;

            for (int i = 0; i < 11; i++)
                d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));

            for (int i = 0; i < 10; i++)
                v += d[i] * Convert.ToInt32(sequencia.Substring(i, 1));

            v = (v * 10) % 11; v = (v != 10) ? v : 0;
            return (v == d[10]);

        }


        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
            }
        }

        public string Motor
        {
            get
            {
                return _motor;
            }
            set
            {
                _motor = value;
            }
        }

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        public string Ano
        {
            get
            {
                return _ano;
            }
            set
            {
                _ano = value;
            }
        }

        public decimal Quilometragem
        {
            get
            {
                return _quilometragem;
            }
            set
            {
                _quilometragem = value;
            }
        }

        public string TipoDeVeiculo
        {
            get
            {
                return _tipodeveiculo;
            }
            set
            {
                _tipodeveiculo = value;
            }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //Construtor
        public Veiculo(string placa, string numeroRenavam, string marca, string modelo, string motor, string cor, string ano, decimal quilometragem, string tipodeveiculo, string status)
        {
            Placa = placa;
            NumeroRenavam = numeroRenavam;
            Marca = marca;
            Modelo = modelo;
            Motor = motor;
            Cor = cor;
            Ano = ano;
            Quilometragem = quilometragem;
            TipoDeVeiculo = tipodeveiculo;
            Status = status;
        }
        //remover
        public Veiculo()
        {

        }
    }
}