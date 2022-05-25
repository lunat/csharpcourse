using static System.Console;
using static System.Convert;

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());


//double g = 9.8;
//int h = ToInt32(g);
//WriteLine($"g is {g} and h is {h}");

//WriteLine($"ToInt32(9.49) is {ToInt32(9.49)}");
//WriteLine($"ToInt32(9.5) is {ToInt32(9.5)}");
//WriteLine($"ToInt32(9.51) is {ToInt32(9.51)}");
//WriteLine($"ToInt32(10.49) is {ToInt32(10.49)}");
//WriteLine($"ToInt32(10.5) is {ToInt32(10.5)}");
//WriteLine($"ToInt32(10.51) is {ToInt32(10.51)}");
//
//double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51, };
//foreach (var n in doubles)
//{
//    WriteLine(format:
//        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}"
//        , arg0: n
//        , arg1: Math.Round(value: n
//            , digits: 0
//            , mode: MidpointRounding.AwayFromZero)
//    );
//}



//int a = 10;
//double b = a; // implicit casting
//WriteLine(b);

//double c = 9.8;
//int d = (int)c;
//WriteLine(d);

//long e = 10;
//int f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");
////e = long.MaxValue;
//e = 5_000_000_000;
//f = (int)e;
//WriteLine($"e is {e:N0} and f is {f:N0}");
//
//f = int.MaxValue;
//f++;
//WriteLine($"e is {e:N0} and f is {f:N0}");