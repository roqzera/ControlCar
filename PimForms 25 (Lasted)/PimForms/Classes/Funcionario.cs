using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimForms.Formulários;
using System.Text.RegularExpressions;
using PimForms.Classes;
using System.Globalization;
using System.Windows.Forms;

namespace PimForms
{
    public class Funcionario
    {
        private string _matricula;
        private string _nome;
        private string _cpf;
        private DateTime _dataDeNascimento;
        private string _telefone;
        private string _cargo;
        private string _email;
        private string _numeroCNH;
        private string _categoriaCNH;
        private DateTime _validadeCNH;
        private string _motorista;
        private string _status;

        public Funcionario()
        {
        }

        public Funcionario(string matricula,
            string nome,
            string cpf,
            DateTime dataDeNascimento,
            string telefone,
            string cargo,
            string email,
            string numeroCNH,
            string categoriaCNH,
            DateTime validadeCNH,
            string motorista,
            string status
            )
        {
            Matricula = matricula;
            Nome = nome;
            CPF = cpf;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Cargo = cargo;
            Email = email;
            NumeroCNH = numeroCNH;
            CategoriaCNH = categoriaCNH;
            ValidadeCNH = validadeCNH;
            Motorista = motorista;
            Status = status;
        }

        public string Matricula
        {
            get { return _matricula; }
            set
            {
                if (IsMatricula(value) == true)
                {
                    _matricula = value;
                }
            }
        }

        private bool IsMatricula(string matricula)
        {
            if (matricula.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (IsNome(value) == true)
                {
                    _nome = value;
                }
            }
        }

        private bool IsNome(string nome)
        {
            if (nome.Length >= 5 && nome.Length <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (IsCpf(value) == true)
                {
                    _cpf = value;
                }
            }
        }

        private bool IsCpf(string cpf)
        {
            // Array criado para verificar a validade do primeiro dígito do cpf. Cada número inteiro desse array multiplicará os nove primeiros números do cpf.
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            // Array criado para verificar a validade do segundo dígito do cpf.Cada número inteiro desse array multiplicará os dez primeiros números do cpf, incluindo o primeiro dígito do cpf.
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            // 
            cpf = cpf.Trim();

            // Os caracteres "." e "-" e os espaços " " são substituidos por "", restando uma string com apenas números.
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            // A string cpf deve ter 11 caracteres (neste caso, 11 números) para ser válida, caso ao contrário o método de validação retorna o valor false.
            if (cpf.Length != 11)
                return false;

            // A string tempCpf passa a armazenar os 9 primeiros números da string cpf, deixando de fora os dois dígitos do cpf.
            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
                // A cada laço de repetição um número da string tempCpf é convertido para int e multiplicado por um número inteiro da array multiplicador1.
                // E a cada laço o valor resultante dessa multiplicação é armazenado na variável soma.
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            // Se o resto da divisão for menor que 2, então o dígito é igual a Zero.
            if (resto < 2)
                resto = 0;
            // Senão o resto é igual a 11 menos o resto da divisão(11 - resto).
            else
                resto = 11 - resto;

            // O resto é convertido para string e igualado a variável digito, ou seja, o primeiro dígito do cpf foi encontrado.
            digito = resto.ToString();

            // O digito (do tipo string) é adicionado ao final da string tempCpf, passando a ficar com 10 números.
            tempCpf = tempCpf + digito;
            soma = 0;

            // O processo para encontrar o primeiro dígito se repete para o segundo.
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            // Adiciona o segundo dígito encontrado à direita do primeiro dígito, ficando a string digito com dois números (do tipo string).
            digito = digito + resto.ToString();

            // Após encontrar os dois dígitos do cpf, verifica se os dois dígitos são iguais aos dois últimos números da string cpf, e retorna true, se o cpf for válido.
            return cpf.EndsWith(digito);
        }

        public DateTime DataDeNascimento
        {
            get { return _dataDeNascimento; }
            set
            {
                _dataDeNascimento = value;
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
            }
        }

        /*
        public bool IsTelefone(string telefone)
        {
            string telefoneRegex = string.Format

            if (Regex.IsMatch(telefone, telefoneRegex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        public string Cargo
        {
            get { return _cargo; }
            set
            {
                if (IsCargo(value) == true)
                {
                    _cargo = value;
                }
            }
        }

        private bool IsCargo(string cargo)
        {
            if (cargo.Length >= 5 && cargo.Length <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (IsEmail(value) == true)
                {
                    _email = value;
                }
            }
        }

        private bool IsEmail(string email)
        {
            string emailRegex = string.Format("{0}{1}",
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (Regex.IsMatch(email, emailRegex))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string NumeroCNH
        {
            get { return _numeroCNH; }
            set
            {
                if(IsNumeroCNH(value) == true)
                {
                    _numeroCNH = value;
                }
            }
        }

        private bool IsNumeroCNH(string numeroCNH)
        {
            if (numeroCNH.Length == 11 || numeroCNH == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CategoriaCNH
        {
            get { return _categoriaCNH; }
            set
            {
                if (IsCategoriaCNH(value) == true)
                {
                    _categoriaCNH = value;
                }
            }
        }

        private bool IsCategoriaCNH(string categoriaCNH)
        {
            if (categoriaCNH == "A" || categoriaCNH == "B" || categoriaCNH == "AB" || categoriaCNH == "C" || categoriaCNH == "D" || categoriaCNH == "E" || categoriaCNH == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DateTime ValidadeCNH
        {
            get { return _validadeCNH; }
            set { _validadeCNH = value; }
        }

        public string Motorista
        {
            get { return _motorista; }
            set { _motorista = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
