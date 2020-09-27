using Code2Night.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code2Night.DAL.Interfaces
{
    public interface IFeedback
    {
        string SaveFeedback(Feedback feedback);
    }
}
