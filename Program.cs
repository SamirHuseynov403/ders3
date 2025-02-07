

// SUAL 1__________ a ədədi verilmişdir.//Yalnız vurma əməliyyatından istifadə edərək 3 əməliyyata
// a⁸-i hesablayan proqram yazın.

//Console.WriteLine("Eded daxil edin");
//uint input = uint.Parse(Console.ReadLine());
//uint a2, a4, a8;
//a2 = input * input;
//a4 = a2 * a2;
//a8 = a4 * a4;
//Console.WriteLine($"a8= {a8}");


// SUAL 2__________ M və N natural ədədləri verilmişdir.M / N əməliyyatından alınan ədədin
// kəsr hissəsinin birinci və tam hissəsinin sonuncu rəqəmini tapan proqram yazın.

//Console.WriteLine("M ededi daxil edin");
//double M=double.Parse(Console.ReadLine());
//Console.WriteLine("N ededi daxil edin");
//double N=double.Parse(Console.ReadLine());
//double bolme = M / N;
//int tameded = (int)(bolme);
//int tekeded = tameded % 10;
//double kesreded=((M/N)-tameded)*10;
//int tekkesreded=((int)kesreded);
//Console.WriteLine($"Bolme emeliyyati {M}/{N}={bolme}");
//if (bolme-tameded == 0)
//{
//    Console.WriteLine("Bolme emeliyyatinda kesr eded yoxdur");
//}
//else
//{
//    Console.WriteLine($"Kesr hissenin birinci ededi {tekkesreded}");
//}
//Console.WriteLine($"Tam hissenin sonuncu ededi {tekeded}");


// SUAL 3__________ Saniyənin tam ədəd kimi daxil edilməsi və uyğun
// sutka, saat, dəqiqə və saniyə formatına çevrilməsi.
//Məsələn:Saniyəni daxil edin: 31600000 Nəticə: 365 gün, 17 saat, 46 dəq, 40 saniyə

//Console.WriteLine("Saniyeler daxil edin ");
//int input = int.Parse(Console.ReadLine());

//int saniyeler = input;

//int gun = 86400;
//int saat = 3600;
//int deqiqe = 60;

//int gunsay = saniyeler / gun;
//saniyeler = saniyeler % gun;

//int saatsay = saniyeler / saat;
//saniyeler = saniyeler % saat;

//int deqiqesay = saniyeler / deqiqe;
//int qalan_saniye = saniyeler % deqiqe;

//string netice = "";

//if (gunsay > 0)
//    netice += $"{gunsay} gun, ";

//if (saatsay > 0)
//    netice += $"{saatsay} saat, ";

//if (deqiqesay > 0)
//    netice += $"{deqiqesay} deqiqe, ";

//if (saniyeler > 0 || netice == "")
//    netice += $"{qalan_saniye} saniye";

//Console.WriteLine(netice);


// SUAL 4__________ Klaviaturadan daxil edilmiş simvolun hərf, rəqəm və ya simvol
// olduğunu müəyyənləşdirən proqram yazın. 

//Console.WriteLine("simvol yazin");
//char input =char.Parse(Console.ReadLine());

//if (input >= '0' && input <= '9')
//{
//    Console.WriteLine("Bu bir ededdir");
//}
//else if ((input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z'))
//{
//    Console.WriteLine("Bu bir herfdir");
//}
//else { Console.WriteLine("Bu bir simvoldur"); }


// SUAL 5__________ n natural ədədi və d ədədinin o zaman bərabər böləni adlanır ki,
//n - ni m - dən bölünməsindən alınan tam və qalıq bərabər olsun.
//Verilmiş n natural ədədinə görə onun bərabər bölənlərini tapın.

//Console.Write("n natural ededini daxil edin: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i < n; i++)
//{
//    int tam = n / i;
//    int qaliq = n - tam * i;
//    if (tam == qaliq)
//    {
//        Console.WriteLine($"m - {i}");
//    }
//}

//Console.Write("n natural ededini daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i < n; i++)
//{
//    int tam = n / i;   // Tam hissəni tapırıq
//    int qaliq = n % i; // Doğru qalıq hesablaması

//    if (tam == qaliq)  // Əgər tam və qalıq eynidirsə, uyğun m tapılıb
//    {
//        Console.WriteLine($"m - {i}");
//    }
//}


// SUAL 6__________ Verilmiş n ədədinin rəqəmlərinin müxtəlif olub-olmadığını yoxlayan proqram yazın.
//Input: 3366 → Output: No
//Input: 3687 → Output: Yes

//Console.WriteLine("Daxil edilecek eded sayı:");
//int[] mass = new int[int.Parse(Console.ReadLine())];

//Console.WriteLine("Ededleri daxil edin:");
//for (int i = 0; i < mass.Length; i++)
//{
//    mass[i] = int.Parse(Console.ReadLine());
//}
//// Hər bir ədəd üçün son rəqəmlərin eyni olub-olmadığını yoxlayaq
//for (int i = 0; i < mass.Length; i++)
//{
//    int firstnum = mass[i]; 
//    int secondnum = mass[i];
//    bool yoxla = true; 

//    for (int j = 1; j < mass[i].ToString().Length; j++)
//    {
//         secondnum /= 10;
//        if (secondnum==firstnum%10)
//        {
//            yoxla = false;
//            break;
//        }
//        firstnum/=10;
//    }
//    if (yoxla)
//        Console.WriteLine($"{mass[i]} - Yes");
//    else
//        Console.WriteLine($"{mass[i]} - No");
//}


// SUAL 7__________ N natural ədədi verilmişdir.
              //Bu ədədin sadə olub-olmadığını yoxlayan proqram yazın.

//Console.WriteLine("Eded daxil edin");
//int input = int.Parse(Console.ReadLine());

//bool yoxla = true;
//if (input < 2)
//{
//    Console.WriteLine("Sade eded deyil");
//}
//else
//{
//for (int i = 2; true; i++) 
//{
//    if (input % i == 0) 
//    {
//        yoxla = false;
//        break; 
//    }
//}
//if (yoxla)
//    Console.WriteLine("Sade ededdir");
//else
//    Console.WriteLine("Sade eded deyil");
//}

// SUAL 8__________ Ebob

//Console.Write("Birinci ededi daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("İkinci ededi daxil edin: ");
//int b = int.Parse(Console.ReadLine());

//int x = a, y = b;
//while (y != 0)
//{
//    int temp = y;
//    y = x % y;
//    x = temp;
//}
//int ebob = x;

//int ekob = (a * b) / ebob;

//Console.WriteLine();
//Console.WriteLine($"EKOB {ekob}");

// SUAL 9__________ Ekob

//Console.Write("Birinci ededi daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("İkinci ededi daxil edin: ");
//int b = int.Parse(Console.ReadLine());

//int x = a, y = b;
//while (y != 0)
//{
//    int temp = y;
//    y = x % y;
//    x = temp;
//}
//int ebob = x;

//Console.WriteLine();
//Console.WriteLine($"EBOB {ebob}");