using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component World = new World("World", 700000);
            Component Austria = new State("Austria", 8857, "parliamentary republic"); 
                Component Burgenland = new AP("Burgenland", 284);
                    Component Aisenstadt = new City("Aisenstadt", 14);
                    Component Rust = new City("Rust", 2);
                Component Carinthia = new AP("Carinthia", 557);
                    Component Hermagor = new City("Hermagor", 18);
                    Component Wolfsberg = new City("Wolfsberg", 56);
                    Component Feldkirchen = new City("Feldkirchen", 30);
                Component Salzburg = new AP("Salzburg", 531);
                    Component Hallein = new City("Hallein",20);
                    Component Salzburgcity = new City("Salzburg city", 20);
                    Component Saalfelden = new City("Saalfelden", 16);
                    Component Bischofshofen = new City("Bischofshofen", 10);
                    Component Seekirchen = new City("Seekirchen", 9);
                    World.Add(Austria);
                    Austria.Add(Burgenland);
                    Burgenland.Add(Aisenstadt);
                    Burgenland.Add(Rust);
                    Austria.Add(Carinthia);
                    Carinthia.Add(Hermagor);
                    Carinthia.Add(Wolfsberg);
                    Carinthia.Add(Feldkirchen);
                    Austria.Add(Salzburg);
                    Salzburg.Add(Hallein);
                    Salzburg.Add(Saalfelden);
                    Salzburg.Add(Salzburgcity);
                    Salzburg.Add(Bischofshofen);
                    Salzburg.Add(Seekirchen);
            Component Canada = new State("Canada", 37067, "constitutional monarchy"); 
                Component Alberta = new AP("Alberta", 4067 );
                    Component Calgary = new City("Calgary", 1239);
                    Component Edmonton = new City("Edmonton", 812);
                    Component RedDeer = new City("Red Deer", 90);
                    Component Lethbridge = new City("Lethbridge", 83);
                Component Saskatchewan = new AP("Saskatchewan", 1098 );
                    Component Saskatoon = new City("Saskatoon", 246);
                    Component Regina = new City("Regina", 215);
                    Component Estevan = new City("Estevan", 11);
                Component Quebec = new AP("Quebec", 8164 );
                    Component Gatineau = new City("Gatineau", 314);
                    Component Montreal = new City("Montreal", 3813);
                    Component Joliette = new City("Red Deer", 46);
                    Component Victoriaville = new City("Victoriaville", 46);
                    Component Matane = new City("Matane", 18);
                Component Ontario = new AP("Ontario", 13448 );
                    Component Toronto = new City("Toronto", 5927);
                    Component Ottawa = new City("Ottawa", 1352);
                    Component Hamilton = new City("Hamilton", 747);
                     Component Windsor = new City("Windsor", 329);
                    Component Kingston = new City("Kingston ", 161);
                    Component Brampton = new City("Brampton", 593);
                    Component Kitchener = new City("Kitchener", 233);
                    World.Add(Canada);
                    Canada.Add(Alberta);
                    Alberta.Add(Calgary);
                    Alberta.Add(Edmonton);
                    Alberta.Add(RedDeer);
                    Alberta.Add(Lethbridge);
                    Canada.Add(Saskatchewan);
                    Saskatchewan.Add(Saskatoon);
                    Saskatchewan.Add(Regina);
                    Saskatchewan.Add(Estevan);
                    Canada.Add(Quebec);
                    Quebec.Add(Gatineau);
                    Quebec.Add(Montreal);
                    Quebec.Add(Victoriaville);
                    Quebec.Add(Matane);
                    Canada.Add(Ontario);
                    Ontario.Add(Toronto);
                    Ontario.Add(Ottawa);
                    Ontario.Add(Hamilton);
                    Ontario.Add(Windsor);
                    Ontario.Add(Brampton);
                    Ontario.Add(Kingston);
                    Ontario.Add(Kitchener);
           Component Ukraine = new State("Ukraine", 123456, "constitutional republic");
               Component Volynr = new AP("Volyn Oblast", 1036);
                    Component Lutsk = new City("Lutsk ", 67);
                    Component Kovel = new City("Kovel", 40);
              Component Kyivr = new AP("Kyiv Oblast", 1729);
                    Component Kyiv = new City("Kyiv", 2900);
                    Component Irpin = new City("Irpin", 40);
                    Component BilaTserkva = new City("Bila Tserkva", 200);
                    Component Brovary = new City("Brovary", 86);
                    Component Boryspil = new City("Boryspil", 54);
                    Component Fastiv = new City("Fastiv", 52);
              Component Odessar = new AP("Odessa Oblast", 2387);
                    Component Izmail = new City("Izmail ", 72);
                    Component Odessa = new City("Odessa", 1010);
                    Component Yuzhne = new City("Yuzhne", 33);
              Component Dnipror = new AP("Dnipropetrovsk Oblast", 3324);
                    Component Dnipro = new City("Dnipro", 1080);
                    Component Kamianske = new City("Kamianske", 262);
                    Component Novomoskovsk = new City("Novomoskovsk", 72);
                    Component Pokrov = new City("Pokrov", 46);
                    World.Add(Ukraine);
            Ukraine.Add(Volynr);
                    Volynr.Add(Kovel);
                    Volynr.Add(Lutsk);  
            Ukraine.Add(Kyivr);
                    Kyivr.Add(Kyiv);
                    Kyivr.Add(Irpin);
                    Kyivr.Add(BilaTserkva);
                    Kyivr.Add(Brovary);
                    Kyivr.Add(Fastiv);
                    Kyivr.Add(Boryspil);
            Ukraine.Add(Odessar);
                    Odessar.Add(Odessa);
                    Odessar.Add(Izmail);
                    Odessar.Add(Yuzhne);
            Ukraine.Add(Dnipror);
                    Dnipror.Add(Dnipro);
                    Dnipror.Add(Kamianske);
                    Dnipror.Add(Novomoskovsk);
                    Dnipror.Add(Pokrov);
            World.Print();
            Console.Read();
        }
    }

    abstract class Component
    {
        protected string name;
        protected int pop;
        public Component(string name, int pop)
        {
            this.name = name;
            this.pop = pop;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine(name + ", population(in thousands): " + pop);
        }
    }

    class World : Component
    {
        private List<Component> components = new List<Component>();
        public World(string name, int pop)
            : base(name, pop)
        {
           
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine(name + ", population(in billions): " + pop);
            Console.WriteLine("States: ");
            for (int i = 0; i < components.Count; i++)
            {
                Console.Write("  " + (i + 1) + ". ");
                components[i].Print();
            }
            Console.WriteLine();
        }
    }

    class State : Component
    {
        private List<Component> components = new List<Component>();

        protected string form;
        public State(string name, int pop, string form): base(name, pop)
        {
            this.form = form;
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("State " + name + ", population(in thousands): " + pop + ", government: " + form);
            Console.WriteLine("   APs: ");
            for (int i = 0; i < components.Count; i++)
            {
                Console.Write("    " + (i + 1) + ". ");
                components[i].Print();
            }
            Console.WriteLine();
        }
    }

    class AP : Component
    {
        private List<Component> components = new List<Component>();
        public AP(string name, int pop): base(name, pop)
        {
        }
        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
        public override void Print()
        {
            Console.WriteLine("AP:" + name + ", population(in thousands): " + pop);
            Console.WriteLine("      Cities: ");
            for (int i = 0; i < components.Count; i++)
            {
                Console.Write("          "+(i+1)+". ");
                components[i].Print();
            }
        }
    }

    class City : Component
    {
        public City(string name, int pop)
            : base(name, pop)
        { }
    }
}
