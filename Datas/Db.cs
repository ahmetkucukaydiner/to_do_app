using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo_app.Datas
{
    internal class Db
    {
        private static List<Person> _personList;
        private static List<Card> _cards;

        static Db()
        {
            _personList = new List<Person>()
            {
                new Person{ID=1, Name = "Ahmet", Team = "Product"},
                new Person{ID=2, Name = "Osman", Team = "Product"},
                new Person{ID=3, Name = "Ömer", Team = "Test"},
                new Person{ID=4, Name = "Denizhan", Team = "Test"}
            };

            _cards = new List<Card>()
            {
                new Card{Title="Toplantı", Content="Ajans ile görüşme 10:00", Person= "Ahmet", Size="M",Board="ToDo"},
                new Card{Title="Kontrol", Content="Ödeme dosyaları kontrol edilecek.", Person= "Osman", Size="XL",Board="InProgress"},
                new Card{Title="Test", Content="Yeni versiyon testleri", Person= "Ömer", Size="L",Board="ToDo"},
                new Card{Title="Kontrol", Content="Canlı kontrolü", Person= "Denizhan", Size="S",Board="InProgress"},
            };
        }

        public static List<Card> Cards
        {
            get {return _cards; }
        }
        public static List<Person> PersonList
        {
            get {return _personList; }
        }
    }
}