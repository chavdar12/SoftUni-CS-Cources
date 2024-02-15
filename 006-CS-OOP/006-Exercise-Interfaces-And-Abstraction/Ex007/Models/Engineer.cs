﻿using System.Text;
using Ex007.Interfaces;

namespace Ex007.Models;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private ICollection<Repair> repairs;

    public Engineer(string id, string firstName, string lastName, decimal salary, string corps, IList<Repair> repairs)
        : base(id, firstName, lastName, salary, corps)
    {
        Repairs = repairs;
    }

    public IList<Repair> Repairs { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine("Repairs:");

        foreach (var repair in Repairs) sb.AppendLine(repair.ToString());

        return sb.ToString().TrimEnd();
    }
}