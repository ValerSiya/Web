using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Witch witch = new Witch();
           Throll throll = new Throll();
           Pegasus pegasus = new Pegasus();
           Harpy harpy = new Harpy();
           Elf elf = new Elf();
           Vampire vampire = new Vampire();
           Console.WriteLine("Witch:");
           witch.Battle();
           Console.WriteLine("Throll:");
           throll.Battle();
           Console.WriteLine("Pegasus:");
           pegasus.Battle();
           Console.WriteLine("Harpy:");
           harpy.Battle();
           Console.WriteLine("Elf:");
           elf.Battle();
           Console.WriteLine("Vampire");
           vampire.Battle();

            Console.Read();
        }
    }

   abstract class Character
    {
        public void Battle()
        {
            Enter();
            Walk();
            Fly();
            Magic();
            Fight();
            Die();
        }
        public void Enter()
        {
            Console.WriteLine("Character enters the battlefield");
        }
        public abstract void Fight();
        public  void Die()
        {
            Console.WriteLine("Character dies");
            Console.WriteLine("----------------------");
        }
        public virtual void Walk() { }
        public virtual void Fly() { }
        public virtual void Magic() { }
    }

    class Witch : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Witch fights with magic wand");
        }
        public override void Walk()
        {
            Console.WriteLine("Witch walks");
        }
        public override void Magic()
        {
            Console.WriteLine("Witch can fly with magic");
        }
    }

    class Throll : Character
    {

        public override void Fight()
        {
            Console.WriteLine("Throll fights with dubina");
        }
        public override void Walk()
        {
            Console.WriteLine("Throll walks");
        }


    }

    class Pegasus : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Pegasus fights with hooves");
        }
        public override void Walk()
        {
            Console.WriteLine("Pegasus walks");
        }
        public override void Fly()
        {
            Console.WriteLine("Pegasus flies");
        }
    }

    class Harpy : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Harpy fights with claws");
        }
        public override void Walk()
        {
            Console.WriteLine("Harpy walks");
        }
        public override void Fly()
        {
            Console.WriteLine("Harpy flies");
        }
    }

    class Elf : Character
    {

        public override void Fight()
        {
            Console.WriteLine("Elf fights with the sword");
        }
        public override void Walk()
        {
            Console.WriteLine("Elf walks");
        }


    }

    class Vampire : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Vampire fights with superforce");
        }
        public override void Walk()
        {
            Console.WriteLine("Vampire walks");
        }
        public override void Magic()
        {
            Console.WriteLine("Vampire can fly with magic (as a human");
        }
        public override void Fly()
        {
            Console.WriteLine("Vampire flies as a bat");
        }
    }
}
