using System.Collections.Generic;
using firstApp.Models;

namespace FirstApp.Data
{
    public interface IcommandRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}