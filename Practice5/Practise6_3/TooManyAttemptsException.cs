using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise6_3
{
  internal class TooManyAttemptsException: Exception
  {
    public TooManyAttemptsException(string message) :base(message) { }
  }
}
