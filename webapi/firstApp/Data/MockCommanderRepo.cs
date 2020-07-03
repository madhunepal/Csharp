using System.Collections.Generic;
using firstApp.Models;

namespace FirstApp.Data {

    public class MockCommanderRepo: IcommandRepo {
        public IEnumerable<Command> GetAppCommands() {
            //throw new System.NotImplementedException();
            var commands = new List<Command> {

            new Command{Id=0, HowTo="Boil an Egg", Line="Boil Water", Platform="Kettle and Pan"},
            new Command{Id=1, HowTo="cut the bread", Line="get a knife", Platform="choping board"}

            };
           
        }

        public Command GetCommandById(int id) {
            //throw new System.NotImplementedException();
            return new Command{Id=0, HowTo="Boil an Egg", Line="Boil Water", Platform="Kettle and Pan"};
        }
    }

}