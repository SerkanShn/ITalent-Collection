//---LIST---
Console.WriteLine("---LIST---");
//String tip tutan bir liste örneği
var stringList = new List<string>();

//Listeye add fonksiyonu ile eleman ekleme
stringList.Add("kalem");
stringList.Add("defter");
stringList.Add("kitap");

//Listeden remove fonksiyonu ile eleman çıkarma
stringList.Remove("defter");

//Listeden belirli indeksdeki elemanı alma
String temp = stringList[1];

//Listede belirli indeksdeki elemanı güncelleme
stringList[1] = "silgi";

//Listedeki bütün elemanları yazdırma
stringList.ForEach(x => Console.WriteLine(x));



//---Dictionary---
Console.WriteLine("---DICTIONARY---");
//Key int ve string tipinde value tutan bir dictionary örneği
var stringDictionary = new Dictionary<int,string>();

//Dictionarye key value şeklinde eleman ekleme
stringDictionary.Add(1,"kalem");
stringDictionary.Add(2,"defter");
stringDictionary.Add(3,"kitap");

//Dictionaryden key vererek değer silme
stringDictionary.Remove(1);

//Dictionaryden key vererek değer okuma
String temp2 = stringDictionary[2];

//Dictionaryde key vererek değeri güncelleme
stringDictionary[2] = "silgi";

//Dictionaryde ki bütün elemanları yazdırma
stringDictionary.Values.ToList().ForEach(x => Console.WriteLine(x));



//---HASHSET---
Console.WriteLine("---HASHSET---");
//String tipinde değer tutan Hashset örneği
var stringHashset = new HashSet<string>();

//Hashset'e değer ekleme, birden fazla aynı değer eklenemez. Eklenen elementler uniquedir.
stringHashset.Add("kalem");
stringHashset.Add("defter");
stringHashset.Add("kitap");
stringHashset.Add("defter");
stringHashset.Add("kitap");

//Hashset'ten değer silme.
stringHashset.Remove("kitap");

//Hashsette ki bütün değerleri yazdırma
stringHashset.ToList().ForEach(x => Console.WriteLine(x));
