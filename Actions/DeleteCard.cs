using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todo_app.Datas;

namespace todo_app.Actions
{
    public class DeleteCard : IActions
    {
        public void Delete()
        {
            delete:
            while(true)
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. \n Lütfen kart başlığını yazınız: ");
                string cardName = Console.ReadLine();

                if(Db.Cards.Any(x=> x.Title == cardName))
                {
                    Console.WriteLine("{0} başlıklı kartı silmeyi onaylıyor musunuz?  (Y / N )",cardName);
                    string y = Console.ReadLine().ToLower();

                    if (y == "y")
                    {
                        Db.Cards.RemoveAt(Db.Cards.FindIndex(x=> x.Title == cardName));
                        Console.WriteLine("Silme işlemi başarılı.");
                        ListCard listCard = new ListCard();
                        listCard.List();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için : (2)");

                    int n = int.Parse(Console.ReadLine());
                    if (n==1)
                    {
                        break;
                    }
                    else if (n==2)
                        goto delete;
                }
                break;
            }
        }
    }
}