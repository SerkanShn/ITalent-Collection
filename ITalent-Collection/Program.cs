using ITalent_Collection;
using System.Collections;

Console.WriteLine("Generic Collections");
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

//---LINKEDLIST---
Console.WriteLine("---LINKEDLIST---");
//String tip tutan bir LinkedList örneği
var stringLinkedList = new LinkedList<string>();

//LinkedListin sonuna eleman ekleme
stringLinkedList.AddLast("kitap");
stringLinkedList.AddLast("kitap2");
stringLinkedList.AddLast("defter");
stringLinkedList.AddLast("defter2");
stringLinkedList.AddLast("kitap");
stringLinkedList.AddLast("kitap2");
stringLinkedList.AddLast("kitap3");

//LinkedListin başına eleman ekleme
stringLinkedList.AddFirst("canta");

//LinkedListden remove fonksiyonu ile eleman çıkarma
stringLinkedList.Remove("defter");

//LinkedListin ilk elemanını çıkarma
stringLinkedList.RemoveFirst();

//LinkedListin son elemanını çıkarma
stringLinkedList.RemoveLast();

//LinkedList değer tutan Nodeu alma
object temp2 = stringLinkedList.Find("defter");

//LinkedList değer tutan Nodedaki değeri güncelleme
stringLinkedList.Find("defter2").Value="silgi";

//LinkedListte ki bütün elemanları yazdırma
stringLinkedList.ToList().ForEach(x => Console.WriteLine(x));



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
String temp3 = stringDictionary[2];

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





//---SortedList---
Console.WriteLine("---SortedList---");
//Key int ve float tipinde value tutan bir SortedList örneği
var floatSortedList = new SortedList<int,float>();

//SortedListe key value şeklinde eleman ekleme
floatSortedList.Add(1, 1.203f);
floatSortedList.Add(3, 2.2f);
floatSortedList.Add(5, 22.4f);
floatSortedList.Add(2, 11.2f);
floatSortedList.Add(4, 0.67f);

//SortedListden key vererek değer silme
floatSortedList.Remove(3);

//SortedListden key vererek değer okuma
float temp4 = floatSortedList[2];

//SortedListde key vererek değeri güncelleme
floatSortedList[2] = 5.23f;

//SortedListte ki bütün elemanları yazdırma
floatSortedList.Values.ToList().ForEach(x => Console.WriteLine(x));


Console.WriteLine("Non-Generic Collections");
//---ARRAYLIST---
Console.WriteLine("---ARRAYLIST---");
//Bir ArrayList örneği
var arrayList = new ArrayList();

//ArrayList'e istenilen tipte eleman ekleme
arrayList.Add("silgi");
arrayList.Add("kalem");
arrayList.Add(25);
arrayList.Add(25.23f);
arrayList.Add(5.19f);
arrayList.Add(true);

//Arraylistten indeks vererek değer silme
arrayList.Remove(3);

//Arraylistten key vererek değer okuma
object temp5 = arrayList[2];

//Arraylistte indeks vererek değer güncelleme
arrayList[1] = 12;

//Arraylistteki bütün elemanları yazdırma
arrayList.ToArray().ToList().ForEach(x => Console.WriteLine(x));


//---HASHTABLE---
Console.WriteLine("---HASHTABLE---");
//Key istenilen tipte ve istenilen tipte value tutan bir HashTable örneği
var hashTableList = new Hashtable();

//HashTable'a istenilen tipte key ve value ekleme
hashTableList.Add(1,"silgi");
hashTableList.Add(true,"kalem");
hashTableList.Add(19,25);
hashTableList.Add(false,25.23f);
hashTableList.Add("defter",5.19f);

//HashTable key vererek değer silme
hashTableList.Remove(false);

//HashTable'a key vererek değer okuma
object temp6 = hashTableList[2];

//HashTable'a key vererek değer güncelleme
hashTableList[true] = 12;

//Arraylistteki bütün elemanları yazdırma
foreach (DictionaryEntry entry in hashTableList)
{
    Console.WriteLine(entry.Value);
}


//---OWNLINKEDLIST---
Console.WriteLine("---OWNLINKEDLIST---");
//Kendi oluşturduğum Bağıl liste örneği tanımlaması
var ownLinkedList = new OwnLinkedList<string>();

//Bağıl listenin nodeuna değer ekleme
ownLinkedList.InsertLast("silgi");
ownLinkedList.InsertLast("kalem");
ownLinkedList.InsertLast("defter");
ownLinkedList.InsertLast("serkan");
ownLinkedList.InsertLast("canta");


//Bağıl listeden indeksdeki nodeu silen fonksiyon
ownLinkedList.RemoveAt(3);

//Bağıl listeden indeksle veri çeken fonksiyon
object temp7 = hashTableList[2];

//Bağıl listede ilgili indeksdeki değeri güncelleme
ownLinkedList[1] = "kutu";

//Bağıl listede ki bütün değerleri yazdırma
ownLinkedList.ToList().ForEach(x => Console.WriteLine(x));