// See https://aka.ms/new-console-template for more information

int sayi1, sayi2, toplam = 0;
string islem;   
Console.WriteLine("İlk sayıyı giriniz");
sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine(" ikinci sayıyı giriniz");
sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine(" Yapacağınız işlemi girin -,*,+,/");
islem = Console.ReadLine();

switch (islem)
{
	case "+":
		toplam = sayi1 + sayi2;
		Console.WriteLine($" ilk sayı olan {sayi1} ve ikinci sayi olan {sayi2} nin toplamı {toplam}");
		break;
    case "-":
        toplam = sayi1 - sayi2;
        Console.WriteLine($" ilk sayı olan {sayi1} den ikinci sayi olan {sayi2} nin çıkartılması {toplam}");
        break;
    case "*":
        toplam = sayi1 * sayi2;
        Console.WriteLine($" ilk sayı olan {sayi1} ve ikinci sayi olan {sayi2} nın çarğımı {toplam}");
        break;
    case "/":
        toplam = sayi1 / sayi2;
        Console.WriteLine($" ilk sayı olan {sayi1} ve ikinci sayi olan {sayi2} nin bölümü {toplam}");
        break;
    default:
        Console.WriteLine(" 4 operatörden birini seçmediniz. Çıkışa yönlendirdirildiniz");
		break;
}


