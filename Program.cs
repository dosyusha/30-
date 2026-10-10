using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== 30 ЗАДАНИЙ ООП =====");
            Console.WriteLine("Введите номер задания от 1 до 30");
            Console.WriteLine("0 - Выход");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Введите число.");
                continue;
            }

            if (choice == 0)
                break;

            switch (choice)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                case 3: Task3(); break;
                case 4: Task4(); break;
                case 5: Task5(); break;
                case 6: Task6(); break;
                case 7: Task7(); break;
                case 8: Task8(); break;
                case 9: Task9(); break;
                case 10: Task10(); break;
                case 11: Task11(); break;
                case 12: Task12(); break;
                case 13: Task13(); break;
                case 14: Task14(); break;
                case 15: Task15(); break;
                case 16: Task16(); break;
                case 17: Task17(); break;
                case 18: Task18(); break;
                case 19: Task19(); break;
                case 20: Task20(); break;
                case 21: Task21(); break;
                case 22: Task22(); break;
                case 23: Task23(); break;
                case 24: Task24(); break;
                case 25: Task25(); break;
                case 26: Task26(); break;
                case 27: Task27(); break;
                case 28: Task28(); break;
                case 29: Task29(); break;
                case 30: Task30(); break;
                default: Console.WriteLine("Нет такого задания."); break;
            }
        }
    }

    // 1. Класс Animal
    static void Task1()
    {
        Animal animal = new Animal("Кошка");
        animal.Eat();
    }

    // 2. Наследование
    static void Task2()
    {
        Dog dog = new Dog("Бобик");
        dog.Eat();
        dog.Bark();
    }

    // 3. Полиморфизм
    static void Task3()
    {
        Animal[] animals =
        {
            new Dog("Рекс"),
            new Cat("Мурка")
        };

        foreach (Animal animal in animals)
            animal.MakeSound();
    }

    // 4. Абстрактный класс Shape
    static void Task4()
    {
        Shape shape = new Circle(5);
        Console.WriteLine($"Площадь круга: {shape.GetArea():F2}");
    }

    // 5. Интерфейс IMovable
    static void Task5()
    {
        Car car = new Car();
        car.Move();
    }

    // 6. Инкапсуляция Person
    static void Task6()
    {
        Person person = new Person("Дарина", 18);
        person.ShowInfo();
    }

    // 7. BankAccount
    static void Task7()
    {
        BankAccount account = new BankAccount(1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Баланс: {account.Balance}");
    }

    // 8. Employee и Manager
    static void Task8()
    {
        Manager manager = new Manager("Анна", 300000, 50000);
        manager.ShowSalary();
    }

    // 9. Vehicle и Car
    static void Task9()
    {
        Vehicle vehicle = new Vehicle("Toyota");
        vehicle.ShowInfo();
    }

    // 10. Скидка на товар
    static void Task10()
    {
        Product product = new Product("Ноутбук", 200000);
        Console.WriteLine($"Цена со скидкой: {product.GetDiscountedPrice(10)}");
    }

    // 11. Абстрактная оплата
    static void Task11()
    {
        Payment payment = new CardPayment();
        payment.Pay(5000);
    }

    // 12. Интерфейс ILogger
    static void Task12()
    {
        ILogger logger = new ConsoleLogger();
        logger.Log("Программа запущена.");
    }

    // 13. Класс Book
    static void Task13()
    {
        Book book = new Book("Война и мир", "Лев Толстой");
        book.ShowInfo();
    }

    // 14. Библиотека
    static void Task14()
    {
        Library library = new Library();
        library.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков"));
        library.ShowBooks();
    }

    // 15. Оценки студента
    static void Task15()
    {
        Student student = new Student("Дарина");
        student.AddGrade(90);
        student.AddGrade(85);
        student.AddGrade(95);
        Console.WriteLine($"Средний балл: {student.GetAverage():F2}");
    }

    // 16. Прямоугольник
    static void Task16()
    {
        Rectangle rectangle = new Rectangle(5, 4);
        Console.WriteLine($"Площадь: {rectangle.GetArea()}");
        Console.WriteLine($"Периметр: {rectangle.GetPerimeter()}");
    }

    // 17. Скорость автомобиля
    static void Task17()
    {
        SpeedCar car = new SpeedCar();
        car.Accelerate(50);
        car.Accelerate(30);
        Console.WriteLine($"Скорость: {car.Speed} км/ч");
    }

    // 18. Заказ и товары
    static void Task18()
    {
        Order order = new Order();
        order.AddProduct(new Product("Мышка", 5000));
        order.AddProduct(new Product("Клавиатура", 12000));
        order.ShowTotal();
    }

    // 19. Интерфейс IShape
    static void Task19()
    {
        IShape circle = new Circle(3);
        IShape square = new Square(4);

        Console.WriteLine($"Круг: {circle.GetArea():F2}");
        Console.WriteLine($"Квадрат: {square.GetArea()}");
    }

    // 20. Корзина покупок
    static void Task20()
    {
        ShoppingCart cart = new ShoppingCart();
        cart.Add("Хлеб", 200);
        cart.Add("Молоко", 450);
        cart.ShowTotal();
    }

    // 21. Статическое поле
    static void Task21()
    {
        Counter a = new Counter();
        Counter b = new Counter();
        Counter c = new Counter();

        Console.WriteLine($"Создано объектов: {Counter.Count}");
    }

    // 22. Конструкторы
    static void Task22()
    {
        CarInfo car = new CarInfo("BMW", 2022);
        car.Show();
    }

    // 23. Перегрузка методов
    static void Task23()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine(calculator.Add(5, 3));
        Console.WriteLine(calculator.Add(5, 3, 2));
        Console.WriteLine(calculator.Add(2.5, 3.5));
    }

    // 24. Перечисление enum
    static void Task24()
    {
        Day today = Day.Monday;
        Console.WriteLine($"Сегодня: {today}");
    }

    // 25. Композиция классов
    static void Task25()
    {
        Engine engine = new Engine("V8");
        CarWithEngine car = new CarWithEngine("Ford", engine);
        car.Start();
    }

    // 26. Проверка возраста
    static void Task26()
    {
        try
        {
            AgePerson person = new AgePerson(-5);
            Console.WriteLine(person.Age);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // 27. Перегрузка операторов
    static void Task27()
    {
        Money a = new Money(100);
        Money b = new Money(250);
        Money result = a + b;

        Console.WriteLine($"Сумма: {result.Amount}");
    }

    // 28. Интерфейс для печати
    static void Task28()
    {
        IPrintable document = new Document("Мой документ");
        document.Print();
    }

    // 29. Система уведомлений
    static void Task29()
    {
        Notifier email = new EmailNotifier();
        Notifier sms = new SmsNotifier();

        email.Send("Привет!");
        sms.Send("Привет!");
    }

    // 30. Животные и полиморфизм
    static void Task30()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Рекс"),
            new Cat("Мурка"),
            new Animal("Животное")
        };

        foreach (Animal animal in animals)
            animal.MakeSound();
    }
}

// ===== КЛАССЫ ДЛЯ ЗАДАНИЙ =====

class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} издает звук.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public void Bark()
    {
        Console.WriteLine($"{Name}: Гав!");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав-гав!");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу!");
    }
}

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape, IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Автомобиль движется.");
    }
}

class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, возраст: {Age}");
    }
}

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }
}

class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Manager : Employee
{
    public decimal Bonus { get; set; }

    public Manager(string name, decimal salary, decimal bonus)
        : base(name, salary)
    {
        Bonus = bonus;
    }

    public void ShowSalary()
    {
        Console.WriteLine($"{Name}: зарплата {Salary + Bonus}");
    }
}

class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Марка транспорта: {Brand}");
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public decimal GetDiscountedPrice(decimal discount)
    {
        return Price * (1 - discount / 100);
    }
}

abstract class Payment
{
    public abstract void Pay(decimal amount);
}

class CardPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата картой: {amount}");
    }
}

class CashPayment : Payment
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата наличными: {amount}");
    }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Лог: {message}");
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Книга: {Title}, автор: {Author}");
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ShowBooks()
    {
        foreach (Book book in books)
            book.ShowInfo();
    }
}

class Student
{
    public string Name { get; set; }
    private List<int> grades = new List<int>();

    public Student(string name)
    {
        Name = name;
    }

    public void AddGrade(int grade)
    {
        if (grade >= 0 && grade <= 100)
            grades.Add(grade);
    }

    public double GetAverage()
    {
        if (grades.Count == 0)
            return 0;

        double sum = 0;

        foreach (int grade in grades)
            sum += grade;

        return sum / grades.Count;
    }
}

class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

class SpeedCar
{
    public int Speed { get; private set; }

    public void Accelerate(int value)
    {
        if (value > 0)
            Speed += value;
    }
}

class Order
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowTotal()
    {
        decimal total = 0;

        foreach (Product product in products)
            total += product.Price;

        Console.WriteLine($"Сумма заказа: {total}");
    }
}

interface IShape
{
    double GetArea();
}

class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }
}

class ShoppingCart
{
    private List<(string Name, decimal Price)> items =
        new List<(string Name, decimal Price)>();

    public void Add(string name, decimal price)
    {
        items.Add((name, price));
    }

    public void ShowTotal()
    {
        decimal total = 0;

        foreach (var item in items)
            total += item.Price;

        Console.WriteLine($"Итого в корзине: {total}");
    }
}

class Counter
{
    public static int Count { get; private set; }

    public Counter()
    {
        Count++;
    }
}

class CarInfo
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public CarInfo(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Show()
    {
        Console.WriteLine($"{Brand}, {Year} год");
    }
}

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Engine
{
    public string Type { get; set; }

    public Engine(string type)
    {
        Type = type;
    }
}

class CarWithEngine
{
    public string Brand { get; set; }
    private Engine engine;

    public CarWithEngine(string brand, Engine engine)
    {
        Brand = brand;
        this.engine = engine;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} запускается. Двигатель: {engine.Type}");
    }
}

class AgePerson
{
    private int age;

    public int Age
    {
        get { return age; }
    }

    public AgePerson(int age)
    {
        if (age < 0)
            throw new ArgumentException("Возраст не может быть отрицательным.");

        this.age = age;
    }
}

class Money
{
    public decimal Amount { get; set; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }
}

interface IPrintable
{
    void Print();
}

class Document : IPrintable
{
    public string Title { get; set; }

    public Document(string title)
    {
        Title = title;
    }

    public void Print()
    {
        Console.WriteLine($"Печать документа: {Title}");
    }
}

abstract class Notifier
{
    public abstract void Send(string message);
}

class EmailNotifier : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine($"Email: {message}");
    }
}

class SmsNotifier : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine($"SMS: {message}");
    }
}