namespace LB4
{
    namespace FlowerShop
    {
        public abstract class AbstractFlower
        {
            protected String color;
            protected int price;
            protected String name;

            public AbstractFlower(String color, String name, int price)
            {
                this.color = color;
                this.name = name; 
                this.price = price;
            }

            public String getColor() { return color; }
            public int getPrice() { return price; }
            public String getName() { return name; }
            public void setPrice(int price)
            { this.price = price; }
            override public String ToString()
            {
                return color + " " + name + ": " + price;
            }
        }

        public class Rose : NaturalFlower
        {
            public Rose(string color, int price) : base(color, "rose", price){}
        }
        public class Tulpin : NaturalFlower
        {
            public Tulpin(string color, int price) : base(color, "iris", price) {}
        }
        public class Iris : NaturalFlower
        {
            public Iris(string color, int price) : base(color, "iris", price) { }
        }
        public class Gladiolus : NaturalFlower
        {
            public Gladiolus(string color, int price) : base(color, "gladiolus", price) { }
        }

        public class ArtificialFlower : AbstractFlower
        {
            public ArtificialFlower(String color, String name, int price) : base(color, name, price) { }
        }

        public class NaturalFlower : AbstractFlower
        {
            public NaturalFlower(string color, string name, int price) : base(color, name, price) { }

            private int _storageLife
            {
                get { return _storageLife; }
                set { _storageLife = value; }
            }

            public bool isRot()
            { return false; }
            public void smell() { }
        }

        public class Wrapper
        {
            protected String material;

            protected int price;

            public Wrapper(String material, int price)
            {
                this.material = material;
                this.price = price;
            }

            public int getPrice() { return price; }
            public void setPrice(int price) { this.price = price; }
            override public String ToString()
            {
                return material + " wrapper: " + price;
            }
        }


        public class Bouquet
        {
            private Wrapper _wrapper;
            private List<AbstractFlower> _composition;

            public Bouquet(Wrapper wrapper)
            {
                _wrapper = wrapper;
                _composition = new List<AbstractFlower>();
            }
            public Bouquet(Wrapper wrapper, AbstractFlower[] flowers)
            {
                _wrapper = wrapper;
                _composition = new List<AbstractFlower>();
                foreach (AbstractFlower flower in flowers)
                {
                    _composition.Add(flower);
                }
            }

            public int getPrice()
            {
                int price = 0;
                foreach (AbstractFlower flower in _composition)
                {
                    price += flower.getPrice();
                }
                if (_wrapper != null)
                {
                    price += _wrapper.getPrice();
                }
                return price;
            }

            public List<AbstractFlower> getComposition()
            {
                return _composition;
            }

            public Wrapper getWrapper()
            {
                return _wrapper;
            }

            public void setWrapper(Wrapper wrapper) { 
                _wrapper = wrapper;  
            }

            public void addFlower(AbstractFlower flower)
            {
                _composition.Add(flower);
            }

            public void removeFlower(AbstractFlower flower)
            {
                _composition.Remove(flower);
            }

            override public String ToString()
            {
                String bouquet = "Bouquet: \n";
                bouquet += "\t" + _wrapper.ToString() + "\n";
                foreach(AbstractFlower flower in _composition)
                {
                    bouquet += "\t" + flower.ToString() + "\n";
                }
                bouquet += "________________________________\n";
                bouquet += "\tTotal cost: " + getPrice() + "\n\n\n";
                return bouquet;
            }
        }
    }
}
