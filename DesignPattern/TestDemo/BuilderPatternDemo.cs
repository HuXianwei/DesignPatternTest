using DesignPattern.CreationalPattern.BuilderAddition;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TestDemo
{
    class BuilderPatternDemo
    {
        internal static void Test()
        {
            //提出建造A型logo产品需求(创建A型logo产品建造者)
            ALogoProductBuilder aBuilder = new ALogoProductBuilder();
            //创造建造指导者
            BuilderDirector director = new BuilderDirector();
            //指导者指导创建
            var aProduct = director.Construct(aBuilder);
            aProduct.Shape.Draw();
            aProduct.Color.Fill();
            Console.WriteLine(aProduct.Size);
            //提出建造A型logo产品需求(创建A型logo产品建造者)
            BLogoProductBuilder bBuilder = new BLogoProductBuilder();
            var bProduct = director.Construct(bBuilder);
            bProduct.Shape.Draw();
            bProduct.Color.Fill();
            Console.WriteLine(bProduct.Size);
        }
    }
}
