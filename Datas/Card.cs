using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_app.Datas
{
    internal class Card
    {
        public string Title {get; set;}
        public string Content {get; set;}
        public string Person {get; set;}
        public string Size {get; set;}
        public string Board {get; set;} = "ToDo";
    }
}