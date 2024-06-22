using NUnit.Framework;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

public class StartUp
{
    static void Main(string[] args)
    {
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10,10);

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9),"Axe Duraility doesn't change after atack.");
    }
}
