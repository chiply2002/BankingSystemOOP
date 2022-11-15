using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class IDGenerator
    {
        static int _id = 0;
        string _storeId;
        DateTime _date = DateTime.Now;

        public string generate()
        {
            string _gid = DateTime.Now.ToString("yyyy-MM-");
            _storeId = _gid + ++_id;
            
            return _storeId;

        }

    }
}

