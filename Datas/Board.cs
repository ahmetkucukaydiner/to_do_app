using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_app.Datas
{
    internal class Board
    {
        public List<Card> ToDo {get; set;}
        public List<Card> InProgress {get; set;}
        public List<Card> Done {get; set;}
    }
}