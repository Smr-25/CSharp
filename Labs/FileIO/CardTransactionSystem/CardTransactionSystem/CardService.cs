using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Pa201LabN5.Enums;
namespace Pa201LabN5
{
    internal class CardService : ICardService
    {
        string path = "C:\\Users\\samiraa\\Desktop\\Lab\\Pa201LabN5\\Pa201LabN5\\Data\\cards.json";


        List<Card> Cards { get; set; } = [];
        public void AddCard()
        {
            GetCards();
            //Console.WriteLine("Please enter car");
            Card card = new(Bank.Kapital,"1234567812345678",10000, 500);
            if (Cards.Any(c => c.Equals(card)))
                throw new ConflictException("This card already exits");
            

            Cards.Add(card);

            using FileStream fileStream = new FileStream(path, FileMode.Create);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            string datas = JsonSerializer.Serialize(Cards);
            streamWriter.Write(datas);
            Console.WriteLine("Added");
        }

        public Card this[string cardNumber]
        {
            get
            {
                return Cards.FirstOrDefault(c => c.CardNumber == cardNumber);
            }
        }

        public void GetCards()
        {
            //FileStream fileStream = new FileStream(path, FileMode.Open);
            //StreamReader streamReader = new StreamReader(fileStream);
            //string datas = streamReader.ReadToEnd();
            //Cards = JsonSerializer.Deserialize<List<Card>>(datas);

            if (!File.Exists(path))
            {
                Cards = [];
                return;
            }

            string datas;
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            using (StreamReader streamReader = new StreamReader(fileStream))
            datas = streamReader.ReadToEnd();
            

            if (string.IsNullOrWhiteSpace(datas))
            {
                Cards = [];
            }
            else
            {
                Cards = JsonSerializer.Deserialize<List<Card>>(datas);
            }
        }

        public void GetCardByCardNumber(string cardNumber)
        {
            Console.WriteLine(this[cardNumber]);
        }


     
    }
}
