using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineApp.Models.Menu
{
  public interface IInOut
    {
        
        string InputString();
        void OutputString(string text);
        void ClearPanel();
        //int UserInputInt();
        //decimal UserInputDecimal();

    }
}
