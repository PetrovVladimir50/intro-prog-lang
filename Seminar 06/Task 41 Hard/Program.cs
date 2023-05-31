// using System.Text.RegularExpressions;



// // Метод считывает нажатие клавиш на клавиатуре заданное количество раз
// // и собирает данные в строку через запятую
// string ReadLineData(string msg)
// {
//   Console.WriteLine(msg);
//   string line = "";
//   for (int i = 0; i < taps; i++)
//   {
//     var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
//     line = line + String.Format(key.KeyChar.ToString()) + ",";
//   }
//   line = line.TrimEnd(','); //кусь последнюю запятую
//   return line;
// }
