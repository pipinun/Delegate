using Person;


Message message;
message = Hello;
Operation operationAdd;
Operation operationMultipy;
AddDelegates addDelegates = Person.Hello.HelloH;
addDelegates += Person.Hello.HelloHowAreYu;

AddDelegates addDelegates1 = Person.Hello.HelloH;
AddDelegates addDelegates2 = Person.Hello.HelloHowAreYu;
AddDelegates addDelegates3 = addDelegates1 + addDelegates2;

OperSomeDelegate op = new Hello().Subtract;
op += new Hello().Add;
op += new Hello().Multiply;
Console.WriteLine(op(7, 2)); 

//Вызов метода через делегата 
Message message1 = Welcome.Print;
Message message2 = new Hello().Display;
operationAdd = new Hello().Add; // или можно создать объект каласса затем обращаться к методу
operationMultipy = new Welcome().Multiply; // или можно создать объект каласса затем обращаться к методу

//Вызов делегата
message();
message1();
message2();
operationAdd(1, 2);
operationMultipy(3, 4);
addDelegates();
addDelegates -= Person.Hello.HelloHowAreYu;
if (addDelegates != null)
{
    addDelegates();
}

Console.WriteLine($"делегат возвращает некоторое значение, то возвращается значение последнего метода из списка вызова {op(3,5)}");
void Hello() => Console.WriteLine("First delegate");

delegate void Message();

delegate int Operation(int a, int b);

delegate void AddDelegates();

delegate int  OperSomeDelegate(int c, int d);