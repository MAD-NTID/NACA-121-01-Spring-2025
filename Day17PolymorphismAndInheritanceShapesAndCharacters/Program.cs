using System.Runtime.CompilerServices;

Professor mb = new Professor("Michael B", "123-00-1234");
Professor kc = new Professor("Kemoy C", "123-00-1234");
Student yt = new Student("Yarin Tellez", "123-00-1235", "AS", 5);
Student sa = new Student("Skylar A", "678-00-1234", "AS", 4);
Student ak = new Student("Amber K", "678-00-1235", "AS", 3.5);
Student nj = new Student("Nai J", "678-00-1236", "AS", 1.5);
Student ur = new Student("Usfer R", "678-00-1237", "AS", 2.5);

IRITMember[] ritMembers = new RITMember[]
{
    mb, 
    kc,
    yt,
    sa,
    ak,
    nj,
    ur
};

for(int i = 0; i < ritMembers.Length; i++)
{
    Console.WriteLine(ritMembers[i]);
    ritMembers[i].Work();

    Console.WriteLine();
}
