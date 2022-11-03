Console.Write("Enter day number - ");
string sa = Console.Readline();
int a = int.Parse(sa);

if (a ==6 && a==7){
    Console.WriteLine("weekend");
}
if (a >= 1 && a  <= 5){
    Console.WriteLine("working day");
}

