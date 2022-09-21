using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app.Datas;

namespace todo_app.Actions
{
    public class MoveCard : IActions
    {
        public void Move()
        {
            move:
            while(true)
            {
                Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor. \n Lütfen kart başlığını yazınız:");
                string cardName = Console.ReadLine();

                

                if (Db.Cards.Any(x=> x.Title == cardName))
                {
                    Console.WriteLine("Bulunan kart bilgileri: \n ******************");
                    foreach (var c in Db.Cards)
                    {
                        Console.WriteLine(c.Title);
                        Console.WriteLine(c.Content);
                        Console.WriteLine(c.Person);
                        Console.WriteLine(c.Size);
                        Console.WriteLine(c.Board);
                        break;
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \n (1) To Do \n (2) In Progress \n (3) Done");
                    int boardType = int.Parse(Console.ReadLine());

                    //Card card = new Card();
                    Card card = Db.Cards.FirstOrDefault(x=> x.Title == cardName);

                    if (boardType == 1) 
                    {
                        card.Board = "ToDo"; 
                    }
                    else if (boardType == 2)
                    {
                        card.Board = "InProgress";
                    }
                    else if (boardType == 3)
                    {
                        card.Board = "Done";
                    }
                    else
                    {
                        card.Board = "Hatalı bir seçim yaptınız.";  
                    }

                    ListCard listCard = new ListCard();
                    listCard.List();
                break;   
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n* İşlemi sonlandırmak için : (1) \n* Yeniden denemek için : (2)");
                    int choice = int.Parse(Console.ReadLine());

                    trymove:
                    if (choice == 1)
                        break;
                    else if (choice == 2)
                        goto move;    
                    else
                    {
                        Console.WriteLine("Hatalı bir giriş yaptınız. Tekrar deneyiniz. ");
                        goto trymove; 
                    }       
                }
            }
        }
    }
}