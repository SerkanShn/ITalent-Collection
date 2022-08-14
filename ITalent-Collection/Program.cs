//---LIST---
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








