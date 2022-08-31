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
            name = "ПРЯМОУГОЛЬНИК";
            Console.Write("Введите длину: ");
            Lengh = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите высоту: ");
            Heigth = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
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
            bool isCorrect = false;
            name = "КВАДРАТ";
            do
            {
                Console.Write("Введите 1-ую строну квадрата: ");
                Lengh = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Введите 2-ую строну квадрата: ");
                Heigth = Convert.ToDecimal(Console.ReadLine());
                if (Lengh == Heigth)
                    isCorrect = true;
            } while (isCorrect != true);
            Console.WriteLine();
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
            Console.Write("Введите 1-ую строну треугольника: ");
            AB = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите 2-ую строну треугольника: ");
            BC = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите 3-ую строну треугольника: ");
            AC = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
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
            decimal _perimeter = this.AB + this.AC + this.BC;
            return _perimeter;
        }
        public override decimal Square() {
            decimal P = (this.AB + this.AC + this.BC) / 2;
            return (decimal)Math.Sqrt((double)(P * (P - this.AB) * (P - this.BC) * (P - this.AC)));
        }
    }
    class Сircle : GeoFigure {
        public Сircle() {
            name = "КРУГ";
            Console.Write("Введите радиус круга: ");
            Radius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
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
            decimal _perimeter = 2 * this.Radius * this.PI;
            return _perimeter;
        }
        public override decimal Square() {
            decimal _squere = this.PI * (this.Radius * this.Radius);
            return _squere;
        }
    }
    class createFigure {
        private int numberOfFigures, count = 0;
        private GeoFigure[] myArray;
        private string answer, request;
        private bool isCorrect;
        private GeoFigure[] createAndWriteToArr()
        {
            do {
                Console.Write("Сколько фигур хотите создать?:\nВвод -> ");
                request = Console.ReadLine();
                isCorrect = Int32.TryParse(request, out int res);
                if (isCorrect)
                {
                    numberOfFigures = Convert.ToInt32(request);
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте ещё раз: ");
                    isCorrect = false;
                }
            }while (isCorrect == false);
            Console.WriteLine();
            myArray = new GeoFigure[numberOfFigures];
            do
            {
                Console.WriteLine("Какую фигуру хотите создать?:\n" +
                    "1 - ПРЯМОУГОЛЬНИК\n" +
                    "2 - КВАДРАТ\n" +
                    "3 - TРЕУГОЛЬНИК\n" +
                    "4 - КРУГ");
                Console.Write("Ввод -> ");
                answer = Console.ReadLine();
                Console.WriteLine();
                if (answer == "1")
                {
                    Rectangle myRectangle = new Rectangle();
                    myArray[count] = myRectangle;
                    count++;
                }
                else if (answer == "2")
                {
                    Squere2 mySquere = new Squere2();
                    myArray[count] = mySquere;
                    count++;
                }
                else if (answer == "3")
                {
                    Triangle myTriangle = new Triangle();
                    myArray[count] = myTriangle;
                    count++;
                }
                else if (answer == "4")
                {
                    Сircle myСircle = new Сircle();
                    myArray[count] = myСircle;
                    count++;
                }
                else
                {
                    Console.WriteLine("Такого варианта нет, попробуйте ещё раз.\n");
                }
                
            } while (count < numberOfFigures);
            return myArray;
        }
        public void PrintResult()
        {
            myArray = createAndWriteToArr();
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("{0}) {1}, площадь - {2} и периметр - {3} ",
                    i + 1, myArray[i].name, myArray[i].Square(), myArray[i].Perimeter());
            }
            Console.WriteLine();
        }
    }
    class Program {
        static void Main(string[] args) {
            createFigure CF = new createFigure();
            CF.PrintResult();
        }
    }
}

