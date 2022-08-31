using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure {
    abstract class GeoFigure {
        private string Name;

        public string name {
            get { return Name; }
            set { Name = value; }
        }
        public abstract decimal Square();
        public abstract decimal Perimeter();

    }
    class Rectangle : GeoFigure {
        public Rectangle() {
            name = "Rect001";
            Console.WriteLine("Введите длину:");
            Lengh = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите высоту:");
            Heigth = Convert.ToDecimal(Console.ReadLine()); ;
        }
        public override decimal Square() {
            decimal _square = this.lengh * this.heigth;
            return _square;
        }
        public override decimal Perimeter() {
            decimal _perimeter = this.lengh + this.lengh + this.heigth + this.heigth;
            return _perimeter;
        }
        private decimal Lengh;

        public decimal lengh {
            get { return Lengh; }
            set { Lengh = value; }
        }
        private decimal Heigth;

        public decimal heigth {
            get { return Heigth; }
            set { Heigth = value; }
        }
    }

    class Squere2 : GeoFigure {
        public Squere2() {
            name = "КВАДРАТ";
            Lengh = Convert.ToDecimal(Console.ReadLine()); ;
            Heigth = Convert.ToDecimal(Console.ReadLine()); ;
        }
        public override decimal Perimeter() {
            decimal _perimeter = this.lengh * 4;
            return _perimeter;
        }
        public override decimal Square() {
            decimal _square = this.lengh * this.heigth;
            return _square;
        }
        private decimal Lengh;

        public decimal lengh {
            get { return Lengh; }
            set { Lengh = value; }
        }
        private decimal Heigth;

        public decimal heigth {
            get { return Heigth; }
            set { Heigth = value; }
        }
    }

    class Triangle : GeoFigure {
        public Triangle() {
            name = "TРЕУГОЛЬНИК";
            AB = Convert.ToDecimal(Console.ReadLine()); ;
            BC = Convert.ToDecimal(Console.ReadLine()); ;
            AC = Convert.ToDecimal(Console.ReadLine()); ;
        }
        private decimal AB;

        public decimal ab {
            get { return AB; }
            set { AB = value; }
        }
        private decimal BC;

        public decimal bc {
            get { return BC; }
            set { BC = value; }
        }
        private decimal AC;

        public decimal ac {
            get { return AC; }
            set { AC = value; }
        }
        public override decimal Perimeter() {
            decimal _perimeter = AB + AC + BC;
            return _perimeter;
        }
        public override decimal Square() {
            decimal P = (AB + AC + BC) / 2;
            return (decimal)Math.Sqrt((double)(P * (P - AB) * (P - BC) * (P - AC)));
        }
    }
    class Сircle : GeoFigure {
        public Сircle() {
            name = "КРУГ";
            Radius = Convert.ToDecimal(Console.ReadLine()); ;
            PI = 3.14m;
        }
        private decimal Radius;

        public decimal radius {
            get { return Radius; }
            set { Radius = value; }
        }
        private decimal PI;

        public decimal pi {
            get { return PI; }
            set { PI = value; }
        }


        public override decimal Perimeter() {
            decimal _perimeter = 2 * Radius * PI;
            return _perimeter;
        }
        public override decimal Square() {
            decimal _squere = PI * (Radius * Radius);
            return _squere;
        }
    }
    class Program {
        static void Main(string[] args) {
            Rectangle myRectangle = new Rectangle();
            myRectangle.name = "ПРЯМОУГОЛЬНИК";
            Console.WriteLine("Фигура {0} имеет площадь {1} и периметр {2}", myRectangle.name, myRectangle.Square(), myRectangle.Perimeter());
            Squere2 mySquere = new Squere2();
           // Console.WriteLine("Фигура {0} имеет площадь {1} и периметр {2}", mySquere.name, mySquere.Square(), mySquere.Perimeter());
            Triangle myTriangle = new Triangle();
         //   Console.WriteLine("Фигура {0} имеет площадь {1} и периметр {2}", myTriangle.name, myTriangle.Square(), myTriangle.Perimeter());
            Сircle myСircle = new Сircle();
          //  Console.WriteLine("Фигура {0} имеет площадь {1} и периметр {2}", myСircle.name, myСircle.Square(), myСircle.Perimeter());
            Console.WriteLine("Сколько фигур хотите создать?:");
            int count = Convert.ToInt32(Console.ReadLine());
            GeoFigure[] myArray = new GeoFigure[count];
            Console.WriteLine("Какую фигуру хотите создать?:\n1 - ПРЯМОУГОЛЬНИК\n2 - КВАДРАТ\n3 - TРЕУГОЛЬНИК\n4 - КРУГ");

            myArray[0] = myRectangle;
            myArray[1] = mySquere;
            myArray[2] = myTriangle;
            myArray[3] = myСircle;


        }
    }
}

