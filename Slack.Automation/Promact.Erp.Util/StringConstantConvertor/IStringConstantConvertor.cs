using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promact.Erp.Util.StringConstantConvertor
{
    public interface IStringConstantConvertor
    {
        void CreateFileWatcher(string path);
        void OnInit();
    }
}
