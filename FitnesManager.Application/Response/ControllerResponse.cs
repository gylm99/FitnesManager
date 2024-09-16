using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesManager.Application.Response
{
    public class ControllerResponse:ErrorStore
    {
        public Guid Id { get; set; }
        public bool IsSucces => !HasError;

        public ControllerResponse() : base() { }
    }
}
