using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code2Night.DAL.Common;

namespace Code2Night.DAL.Interfaces
{
   public  interface ITutorial
    {
        void AddTutorials(Tutorial blog);
        List<Tutorial> ListTutorial(string technology);
        List<Tutorial> gettutorials();
    }
}
