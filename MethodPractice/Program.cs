

//using MethodPractice;

//static Doctor[] GetDoctors()
//{
//    Doctor doctor1 = new Doctor()
//    {
//        Name="Javid",
//        Surname="Ismayilzade",
//        Address="Sulutepe",
//        Birthday=new DateTime(1993,10,05)
//    };
//    Doctor doctor2 = new Doctor()
//    {
//        Name="Elekber",
//        Surname = "Hesenov",
//        Address = "Bayil",
//        Birthday=new DateTime(2001,11,25)
//    };
//    Doctor doctor3 = new Doctor()
//    {
//        Name="Mubariz",
//        Surname = "Agayev",
//        Address = "Nesimi",
//        Birthday=new DateTime(2004,12,02)
//    };
//    Doctor doctor4 = new Doctor()
//    {
//        Name="Ismayil",
//        Surname="Esedov",
//        Address="Yasaml",
//        Birthday=new DateTime(2004,05,20)
//    };

//    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4 };
//    return doctors;
//}


//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 15);

//GetDoctorsByBirthday(startDate, endDate);
//static void GetDoctorsByBirthday(DateTime startDate, DateTime endDate)
//{
//    var doctors = GetDoctors();
//    foreach(var doctor in doctors)
//    {
//        if(doctor.Birthday>startDate && doctor.Birthday<endDate)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.Surname} {doctor.Address} {doctor.Birthday}");
//        }
//    }
//}





//Calculate task


//using MethodPractice;
//Calculate();
//static void Calculate()
//{
//    Calculator calculator= new Calculator();
//    Console.WriteLine("Add first number :");
//Number1: string number1 = Console.ReadLine();
//    int checkednumber1;
//    bool isParseNum1=int.TryParse(number1, out checkednumber1);


//    if (!isParseNum1)
//    {
//        Console.ForegroundColor= ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 1");
//        Console.ReadLine();
//        goto Number1;
//    }


//    Console.WriteLine("Add operation :");
//    string operation= Console.ReadLine();

//    Console.WriteLine("Add second number :");


//Number2: string number2 = Console.ReadLine();
//    int checkednumber2;
//    bool isParseNum2=int.TryParse(number2, out checkednumber2);

//    if (!isParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 2");
//        Console.ReadLine();
//        goto Number2;
//    }

//        var result=calculator.Calculation(checkednumber1,checkednumber2,operation);

//        Console.ForegroundColor= ConsoleColor.Green;
//        Console.WriteLine(result);
//        Console.ResetColor();

//}





//Task


//using MethodPractice;

//static Order[] GetOrders()
//{
//    Order order1= new Order()
//    {
//        Date=new DateTime(2022,12,20),
//            Price=25
//    };
//    Order order2 = new Order()
//    {
//        Date = new DateTime(2022, 12, 21),
//        Price=27
//    };
//    Order order3 = new Order()
//    {
//        Date = new DateTime(2022, 12, 21),
//        Price = 18
//    };
//    Order order4 = new Order()
//    {
//        Date = new DateTime(2022, 12, 20),
//        Price = 40
//    };
//    Order order5 = new Order()
//    {
//        Date = new DateTime(2022, 12, 22),
//        Price = 30
//    };
//    Order order6 = new Order()
//    {
//        Date = new DateTime(2022, 12, 28),
//        Price = 31
//    };

//    return new Order[] { order1, order2, order3, order4, order5, order6 };
//}


//DateTime filteredDate=DateTime.Now.AddDays(1);
//double filteredPrice = 20;


//GetFilteredOrders(filteredDate, filteredPrice);
//static void GetFilteredOrders(DateTime date,double price)
//{
//    var orders = GetOrders();
//    foreach(var item in orders)
//    {
//        if(item.Price>price  && item.Date <= date)
//        {
//            Console.WriteLine(item.Date.ToString("MM-dd-yyyy")+":"+item.Price);
//        }
//    }
//}





//using MethodPractice;

//static Person[] GetPersons()
//{
//    Person person1 = new Person()
//    {
//        Name = "Roya",
//        Surname = "Meherremova",
//        Age = 26,
//        IsMarried = true,
//    };
//    Person person2 = new Person()
//    {
//        Name="Konul",
//        Surname="Ibrahimova",
//        Age = 26,
//        IsMarried = true,
//    };
//    Person person3 = new Person()
//    {
//        Name="Javid",
//        Surname="Ismayilzade",
//        Age = 23,
//        IsMarried = false,
//    };
//    Person person4 = new Person()
//    {
//        Name = "Mubariz",
//        Surname = "Agayev",
//        Age = 18,
//        IsMarried = false,
//    };
//    Person person5 = new Person()
//    {
//        Name = "Shaiq",
//        Surname = "Kazimov",
//        Age = 25,
//        IsMarried = false,
//    };

//    return new Person[] { person1, person2, person3, person4,person5 };
//}


//PersonIsMarried(24);
//static void PersonIsMarried(int n)
//{
//    int count = 0;
//    var persons= GetPersons();
//    foreach (var person in persons)
//    {
//        if (person.Age > n && person.IsMarried == true)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}


