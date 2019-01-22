using System;
using System.Collections.Generic;
using System.Text;

namespace FirstXmr1.Models
{
    public interface IDialer
    {
		bool MakeCall(string number);
    }
}
