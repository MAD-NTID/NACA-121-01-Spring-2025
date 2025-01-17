/*
Justin works at a car dealership.  He gets a commission on his car sales.
What we need is a tool to help us calculate Justin’s commission.

Start Here
Justin gets a 7% commission of the total sale
Justin only gets the commission if the sale is $10,000 or more
Examples:
If Justin sells a car for $15,000 his commission is $1,050
If Justin sells a car for $7,000 his commission is $0
*/
const double COMMISSION = .07;

Console.Write("Enter the Price of the car: ");

double carPrice = double.Parse(Console.ReadLine());
double earnedCommission = 0;

if(carPrice >= 10000)
    earnedCommission = carPrice * COMMISSION;

Console.WriteLine($"Justin sold a car for {carPrice:C} and earned {earnedCommission:C}");