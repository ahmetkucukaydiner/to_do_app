using System;
using todo_app.Actions;

namespace todo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("************************");
            Console.WriteLine("(1) Board'ı listelemek");
            Console.WriteLine("(2) Board'a kart eklemek");
            Console.WriteLine("(3) Board'dan kart silmek");
            Console.WriteLine("(4) Kart taşımak");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ListCard listCard = new ListCard();
                    listCard.List();
                    break;
                case 2:
                    AddCard addCard = new AddCard();
                    addCard.Add();
                    break;
                case 3:
                    DeleteCard deleteCard = new DeleteCard();
                    deleteCard.Delete();
                    break;
                case 4: 
                    MoveCard moveCard = new MoveCard();
                    moveCard.Move();
                    break;  
            }
        }
    }
}
