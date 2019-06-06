using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimForms.Classes
{
    public class Multa
    {
        
        private string _numeroDaInfracao;        
        private decimal _valor;
        private DateTime _data;
        private int _idfuncionario;
        private int _idveiculo;


        public Multa (string numeroDaInfracao, decimal valor, DateTime data, int idfuncionario, int idveiculo)
        {
            NumeroDaInfracao = numeroDaInfracao;
            Valor = valor;
            Data = data;
            Funcionario = idfuncionario;
            Veiculo = idveiculo;
        }
        public Multa()
        {

        }

        public int Funcionario
        {
            get { return _idfuncionario; }
            set
            {  
               _idfuncionario = value;
            }
        }


        public int Veiculo
        {
            get { return _idveiculo; }
            set
            {
                _idveiculo = value;
            }
        }


        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (IsValidarValor(value))
                    _valor = value;
            }            
        }
        private bool IsValidarValor(decimal valor)
        {
          if( valor > 0 && valor < 9999.99m)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public string NumeroDaInfracao
        {
            get { return _numeroDaInfracao; }
            set
            {
                if (IsValidarNumeroDaInfracao(value))
                {
                    _numeroDaInfracao = value;
                }         
                
            }
        }
        private bool IsValidarNumeroDaInfracao(string numero)
        {
            if (numero.Length == 6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DateTime Data
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }       
        
        
        }
    }


