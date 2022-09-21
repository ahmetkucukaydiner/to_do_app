using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app.Datas;

namespace todo_app.Actions
{
    public class AddCard : IActions
    {
        public void Add()
        {
            Card newCard = new Card();

            Console.Write("Başlık giriniz: ");
            newCard.Title = Console.ReadLine();

            Console.Write("İçerik giriniz: ");
            newCard.Content = Console.ReadLine();

            Console.Write("Büyüklük seçiniz -> XS(1),S(2),M(3),L(4),XL(5)");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Kişi seçiniz: ");
            newCard.Person = Console.ReadLine();

            if(size != null)
            {
                string sizeVal = Enum.GetName(typeof(Sizes),size);
                newCard.Size = sizeVal;

                Db.Cards.Add(newCard); 
                
                ListCard listCard = new ListCard();
                listCard.List();                      
            }
            else
                Console.WriteLine("Geçersiz bir karakter girdiniz. Tekrar deneyin.");               
        }
                
    }
    enum Sizes
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
}