﻿namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tiger = new Tiger(100);
            var lion = new Lion(200);

            tiger.Show();
            lion.Show();
        }
    }
}