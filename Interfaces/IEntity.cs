namespace W5_assignment_template.Interfaces
{
    public interface IEntity
    {
        void Attack(IEntity target);
        void Defend(IEntity target);
        void Move();
        int AttackDmg { get; set; }
        int HP { get; set; }
        string Name { get; set; }
    }

}
