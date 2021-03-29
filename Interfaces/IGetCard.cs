using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Interfaces
{
    public interface IGetCard
    {
        public IVisaCard GetVisaCard();
        public IMasterCard GetMasterCard();
    }
}
