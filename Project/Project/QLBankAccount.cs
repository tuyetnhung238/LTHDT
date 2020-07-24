using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
     class QLBankAccount
    {
        private readonly string m_idAdmin;
        private readonly string m_PassAdmin;

        
        public QLBankAccount()
        {
            m_idAdmin = "1";
            m_PassAdmin = "123";
        }

        public string IdAdmin
        {
            get
            {
                return m_idAdmin;
            }
        }

        public string PassAdmin
        {
            get
            {
                return m_PassAdmin;
            }
        }
        
    }
}
