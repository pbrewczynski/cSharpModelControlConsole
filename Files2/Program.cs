using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files2
{
    class Program
    {
        static void Main(string[] args)
        {
            Model           model = new Model();
            Controller controller = new Controller(model);
            controller.interact();
        }
    }
}
