﻿using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;

        public GameEngine(IEntity character, IFearsome goblin, IFearful ghost)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            if (_ghost is IFlyable flyableEntity) {
                ((Ghost) _ghost).Fly();
            }
        }
    }
}
