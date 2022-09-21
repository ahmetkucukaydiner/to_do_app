using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_app.Actions
{
    internal interface IActions
    {
        public void List() {}
        public void Add() {}
        public void Delete() {}
        public void Move() {}
    }
}