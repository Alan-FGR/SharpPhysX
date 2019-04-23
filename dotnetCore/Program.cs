using System;
using static physx;

class SampleTestbed : DebugRenderer
{
    protected override void OnInit()
    {
        
    }

    protected override void OnUpdate(double frameTime)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        new SampleTestbed();
    }
}
