namespace W5_assignment_template.Interfaces
{
    public interface IFearful : IEntity
    {
        public void MultiplyStats(IEntity target)
        {
            AttackDmg /= target.AttackDmg;
            HP /= target.HP;
            System.Console.WriteLine($"{Name} multiplies stats: New AttackDamage = {AttackDmg}, New Health = {HP}");
        }
    }

}