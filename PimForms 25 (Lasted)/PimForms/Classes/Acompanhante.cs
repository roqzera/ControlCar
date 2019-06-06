using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimForms.Classes
{
    public class Acompanhante
    {
        private string _acompanhante1;
        private string _acompanhante2;
        private string _acompanhante3;

        public Acompanhante(string acompanhante1, string acompanhante2, string acompanhante3)
        {
            Acompanhante1 = acompanhante1;
            Acompanhante2 = acompanhante2;
            Acompanhante3 = acompanhante3;
        }

        public string Acompanhante1
        {
            get { return _acompanhante1; }
            set
            {
                _acompanhante1 = value;
            }
        }

        public string Acompanhante2
        {
            get { return _acompanhante2; }
            set
            {
                _acompanhante2 = value;
            }
        }

        public string Acompanhante3
        {
            get { return _acompanhante3; }
            set
            {
                _acompanhante3 = value;
            }
        }
    }
}
