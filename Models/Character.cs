using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Character : IEntity
{
    public string Name { get; set; }
    public int AttackDmg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
    }

    public void Defend(IEntity target)
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        Console.WriteLine($"{Name} moves forward.");
    }
}
