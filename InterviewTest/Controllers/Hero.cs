﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTest.Interface;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}
        public void evolve(int statIncrease = 5)
        {
            for (int i = 0; i < stats.Count; i++)
            {
                var statsValue = (stats[i].Value * (statIncrease / 2)) + stats[i].Value;

                stats[i] = new KeyValuePair<string, int>(stats[i].Key, (int)statsValue);
            }
        }
    }
}
