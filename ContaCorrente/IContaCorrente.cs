using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.contaCorrente
{
    public interface IContaCorrente
    {
        double Saldo { get; set; }

        void ZeraSaldo();
        
    }
}
