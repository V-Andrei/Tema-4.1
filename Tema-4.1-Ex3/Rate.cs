﻿using System;

namespace Tema_4._1_Ex3
{
    class Rate
    {
        public int Amount { get; set; }
        public string Currency { get; set; }      

        public void Print ()
        {
            Console.WriteLine($"Amount is: {Amount}{Currency}");
        }
    }
}
