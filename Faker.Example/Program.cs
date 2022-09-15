// See https://aka.ms/new-console-template for more information
using Faker.Core.Interfaces;
using Faker.Core;

IFaker faker = new Faker1();

Console.WriteLine(faker.Create<uint>().ToString());
Console.WriteLine(faker.Create<int>().ToString());
