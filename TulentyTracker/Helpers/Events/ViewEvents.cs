using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TulentyTracker.Helpers.Events
{
    internal class ViewEvents
    {
        delegate void ViewHandler(Form parrentView);
        event ViewHandler UpdateParrent;
    }
}