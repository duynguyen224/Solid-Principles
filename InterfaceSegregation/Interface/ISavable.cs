using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.Interface
{
    public interface ISavable
    {
        public void SaveToDB();
        public void SaveToFile();
    }
}
