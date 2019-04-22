using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static physx;

class SampleTestbed : DebugRenderer
{
    protected override void OnInit()
    {
        var geometry = new PxBoxGeometry(0.5f,0.5f,0.5f);
        var material = pxPhysics.createMaterial(.5f, .5f, .5f);

        var wallSize = 64;
        for (int i = 0; i < wallSize; i++)
        {
            for (int j = 0; j < wallSize; j++)
            {
                var transform = new PxTransform(new PxVec3(i-wallSize/2, j, 0));
                PxRigidDynamicPtr dynamic = PxCreateDynamic(pxPhysics, transform, geometry, material, 10);
                dynamic.setAngularDamping(.5f);
                pxScene.addActor(dynamic);
            }
        }
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
        //new SampleHelloWorld(true);
    }
}