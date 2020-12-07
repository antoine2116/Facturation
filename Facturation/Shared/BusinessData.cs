using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public List<Facture> lesFactures { get; } = new List<Facture>();

        public BusinessData(params Facture[] factures)
        {
            lesFactures.AddRange(factures);
        }
    }
}
