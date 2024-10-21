using System;
using System.ComponentModel.DataAnnotations;

namespace MauiAppCSharpBasic.Classes;

public class Car
{
    public string Model;
    public string Color;
    public double Speed;
    public double Fuel;
    public double TotalMile;
    public double UseFuelRate; // xxx mile per liter

    public Car(string model, double speed, double fuel)
    {
        this.Model = model;
        this.Speed = speed;
        this.Fuel = fuel;
    }

    public void Run(double mile)
    {
        //this.TotalMile = this.TotalMile + mile ;
        this.TotalMile += mile;
        var use_fuel = mile * this.UseFuelRate;
        this.Fuel = this.Fuel - use_fuel;
    }

    public uint TimeUseForRun(double mile)
    {
        var timeuse = mile/Speed;
        this.Run(mile);
        return Convert.ToUInt16(timeuse);
    }

    public string ShowInfo()
    {
        var info = $"Model : {this.Model}\nTotal Mile : {Convert.ToInt32(this.TotalMile)}\nFuel : {Convert.ToInt32(this.Fuel)}";
        return info;
    }

}
