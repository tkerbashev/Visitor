using Visitor;

Console.WriteLine( "Visitor Behavioural Design Pattern example\n" );

List<ICustomer> customers =
[
    new Office(),
    new PrivateHome()
];

PizzaDeliveryService service = new();
PizzaDeliverySystem.ListDeliveries(customers, service);