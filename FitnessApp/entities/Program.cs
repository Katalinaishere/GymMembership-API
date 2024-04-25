// See https://aka.ms/new-console-template for more information
using Fitness.entities;
var allMembers = new List<Members.Test.Members>()
{
    new Members.Test.Members()
    {
        FirstName = "Member"
    },
    new Members.Test.Members()
    {
        FirstName = "Member second"
    }
};


foreach (var member in allMembers)
{
    Console.WriteLine(Members.FirstName);
}

Console.ReadLine();