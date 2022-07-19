using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            //sort sıralama işlemi
            int[] sayidizisi={23,12,4,86,72,1,15};
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            //clear metodu ile 2. indexten itibaren 2 elemenaı sıfırlar koşula bağlı olarak
            Array.Clear(sayidizisi,2,2);
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            //reverse komutu ile 
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            //indexof ile sayının hangi indexte olduğu bulunuyo örn 23 sayısı kaçıncı index
            Console.WriteLine(Array.IndexOf(sayidizisi,4));
            //resize komt ile dizi yeniden boyutlanır.
            Array.Resize<int>(ref sayidizisi,10);
            sayidizisi[9]=55;
             foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);
        }
    }
}
