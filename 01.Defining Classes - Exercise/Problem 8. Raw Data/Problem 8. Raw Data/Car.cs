﻿namespace Problem_8.Raw_Data
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tires tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires Tires { get; set; } 
    }
}
