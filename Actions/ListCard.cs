using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app.Datas;

namespace todo_app.Actions
{
    public class ListCard : IActions
    {
        private static Board _boards;
        public void LineBoard()
        {
            var toDo = Db.Cards.Where(x=> x.Board == "ToDo").ToList();
            var inProgress = Db.Cards.Where(x=> x.Board == "InProgress").ToList();
            var done = Db.Cards.Where(x=> x.Board == "Done").ToList();

            _boards = new Board();
            _boards.ToDo = toDo;
            _boards.InProgress = inProgress;
            _boards.Done = done;
        }
        public void List()
        {
           LineBoard();
           Show("ToDo",_boards.ToDo);
           Show("In Progress",_boards.InProgress);
           Show("Done",_boards.Done);
        }

        void Show(string board, List<Card> list)
        {
            Console.WriteLine("\t");
            Console.WriteLine(board);
            Console.WriteLine("*******************");
            foreach (var card in list)
            {
                Console.WriteLine("Başlık      : {0}",card.Title);
                Console.WriteLine("İçerik      : {0}",card.Content);
                Console.WriteLine("Atanan kişi : {0}",card.Person);
                Console.WriteLine("Büyüklük    : {0}\n",card.Size);
            }
        }
    }
}