﻿using System;

public class AirBender : Bender
{
    public AirBender(string name, int power,double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity  { get; private set; }
    public override double GetTotalPower()
    {
        return this.AerialIntegrity * base.Power;
    }
}

