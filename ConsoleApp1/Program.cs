using Leo.Extensions;

ulong ul = 0b1111111111111111111111111111111100000000000000000000000000000000;

Console.WriteLine($"source: {ul}");
Console.WriteLine($"exchange: {ul.ExchangeHightAndLow()}");

uint ui = 0b11111111111111110000000000000000;

Console.WriteLine($"source: {ui}");
Console.WriteLine($"exchange: {ui.ExchangeHightAndLow()}");

ushort us = 0b1111111100000000;

Console.WriteLine($"source: {us}");
Console.WriteLine($"exchange: {us.ExchangeHightAndLow()}");

/**
 * source: 18446744069414584320
 * exchange: 4294967295
 * source: 4294901760
 * exchange: 65535
 * source: 65280
 * exchange: 255
 */


float f1 = 0.1314f;
float f2 = 9999.1314f;

Console.WriteLine(f1.Round(2));
Console.WriteLine(f2.Round(2));
// 0.13
Console.WriteLine(f1.ValidDecimal(2));
Console.WriteLine(f2.ValidDecimal(2));
// 0.13