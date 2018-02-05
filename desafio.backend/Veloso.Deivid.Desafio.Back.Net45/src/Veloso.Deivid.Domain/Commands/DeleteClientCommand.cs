using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloso.Deivid.Domain.Commands
{
    public class DeleteClientCommand
    {
        public int Id { get;  set; }
        public bool Disabled { get;  set; }
        public DeleteClientCommand(int id)
        {
            Id = id;
            Disabled = true;
        }
    }
}
