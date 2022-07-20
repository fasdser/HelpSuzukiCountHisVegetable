using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpSuzukiCountHisVegetable
{
    internal class Program
    {
        /* Help Suzuki count his vegetables....

    Suzuki is the master monk of his monastery so it is up to him to ensure the kitchen is operating at full capacity to feed his students and the villagers that come for lunch on a daily basis.

    This week there was a problem with his deliveries and all the vegetables became mixed up.There are two important aspects of cooking in his kitchen, it must be done in harmony and nothing can be wasted. Since the monks are a record keeping people the first order of business is to sort the mixed up vegetables and then count them to ensure there is enough to feed all the students and villagers.


    You will be given a string with the following vegetables:*/

        /* Помогите Сузуки сосчитать овощи....

    Судзуки — главный монах своего монастыря, поэтому именно он должен следить за тем, чтобы кухня работала на полную мощность, чтобы накормить своих учеников и жителей деревни, которые ежедневно приходят на обед.

    На этой неделе у него возникла проблема с доставкой, и все овощи перемешались. Есть два важных аспекта приготовления пищи на его кухне, это должно быть сделано в гармонии, и ничто не может быть потрачено впустую. 
        Поскольку монахи ведут учет, первым делом нужно рассортировать смешанные овощи, а затем пересчитать их, чтобы убедиться, что их достаточно, чтобы накормить всех студентов и жителей деревни.


    Вам будет дана строка со следующими овощами:*/
        /*"cabbage", "carrot", "celery", "cucumber", "mushroom", "onion", "pepper", "potato", "tofu", "turnip"*/
        static void Main(string[] args)
        {
        }

        
            public static List<Tuple<int, string>> CountVegetables(string s)
            {
                var veggies = s.Split(' ');

                var cabbages = 0;
                var carrots = 0;
                var celeries = 0;
                var cucumbers = 0;
                var mushrooms = 0;
                var onions = 0;
                var peppers = 0;
                var potatoes = 0;
                var tofus = 0;
                var turnips = 0;

                foreach (var vegetable in veggies)
                {
                    switch (vegetable)
                    {
                        case "cabbage":
                            cabbages++;
                            break;
                        case "carrot":
                            carrots++;
                            break;
                        case "celery":
                            celeries++;
                            break;
                        case "cucumber":
                            cucumbers++;
                            break;
                        case "mushroom":
                            mushrooms++;
                            break;
                        case "onion":
                            onions++;
                            break;
                        case "pepper":
                            peppers++;
                            break;
                        case "potato":
                            potatoes++;
                            break;
                        case "tofu":
                            tofus++;
                            break;
                        case "turnip":
                            turnips++;
                            break;
                        default:
                            break;
                    }
                }

                var seperatedVegetables = new List<Tuple<int, string>>()
            {
                new Tuple <int, string>(cabbages, "cabbage"),
                                new Tuple <int, string>(carrots, "carrot"),
                                                new Tuple <int, string>(celeries, "celery"),
                                                                new Tuple <int, string>(cucumbers, "cucumber"),
                new Tuple <int, string>(mushrooms, "mushroom"),
                new Tuple <int, string>(onions, "onion"),
                new Tuple <int, string>(peppers, "pepper"),
                new Tuple <int, string>(potatoes, "potato"),
                new Tuple <int, string>(tofus, "tofu"),
                new Tuple <int, string>(turnips, "turnip"),
            };

                return seperatedVegetables.OrderByDescending(x => x.Item1).ThenByDescending(y => y.Item2).ToList();
            }
        }
    }

