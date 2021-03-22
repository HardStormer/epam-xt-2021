using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyGAME2
{
    public class Game
    {
        private readonly ConsoleWriter _writer;
        private Player _player;
        private readonly Random _random = new Random();

        private List<Enemy> _enemies;
        private List<Bullet> _bullets;
        private List<Walls> _walls;
        private List<Bonus> _bonus;

        private string direction = "RIGHT";

        private int money = 0;

        public Game(ConsoleWriter writer)
        {
            _writer = writer;
        }

        public void Run()
        {
            Startup();
            MainLoop();
        }

        private void Startup()
        {
            _player = new Player(60, 25);

            _enemies = Enumerable.Range(0, 10).Select(x => CreateRandomEnemy())
                .ToList();

            _bullets = new List<Bullet>();

            _walls = new List<Walls>();

            _bonus = Enumerable.Range(0, 30).Select(x => CreateRandomBonus())
                .ToList(); 

            int xGame = 0;
            int yGame = 0;
            for (int i = 0; i < 100; ++i)
            {
                xGame = _random.Next(1, _writer.Width - 2);
                yGame = _random.Next(1, _writer.Height - 2);
                Walls newB = new Walls(xGame, yGame);
                _walls.Add(newB);
            }
            for (int i = 0; i < _writer.Width; ++i)
            {
                _walls.Add(new Walls(i, 0));
                _walls.Add(new Walls(i, _writer.Height - 1));
            }
            for (int i = 0; i < _writer.Height; ++i)
            {
                _walls.Add(new Walls(0, i));
                _walls.Add(new Walls(_writer.Width - 1, i));
            }
        }

        Enemy CreateRandomEnemy()
        {
            return new Enemy(_random.Next(3, _writer.Width - 3), _random.Next(3, _writer.Height - 3));
        }
        Bonus CreateRandomBonus()
        {
            return new Bonus(_random.Next(2, _writer.Width - 2), _random.Next(2, _writer.Height - 2));
        }

        private void MainLoop()
        {
            while (true)
            {
                if (ReadInput()) return;
                var logic = GameLogic();

                if (logic is true)
                {
                    _writer.WriteText(0, 0, "WIN", ConsoleColor.White);
                    _writer.Flush();
                    return;
                }
                else if (logic is false)
                {
                    _writer.WriteText(0, 0, "LOSE", ConsoleColor.White);
                    _writer.Flush();
                    return;
                }

                Render();
                Thread.Sleep(100);
            }
        }

        private bool? GameLogic()
        {
            foreach (var enemy in _enemies)
            {
                enemy.Move(1);
            }
            var before = _enemies.Count;
            _enemies.RemoveAll(e => e.Y > _writer.Height);
            _enemies.RemoveAll(e => e.X > _writer.Width);
            var dlta = before - _enemies.Count;
            if (dlta > 0)
            {
                _enemies.AddRange(Enumerable.Range(0, dlta).Select(x => CreateRandomEnemy()));
            }

            foreach (var bullet in _bullets)
            {
                bullet.Move(1);
            }
            _bullets.RemoveAll(e => e.Y < 0);


            foreach (var enemy in _enemies.ToArray())
            {
                foreach (var bullet in _bullets.ToArray())
                {
                    if (enemy.Hit(bullet.X, bullet.Y))
                    {
                        _enemies.Remove(enemy);
                        _bullets.Remove(bullet);
                        break;
                    }
                }
            }

            foreach (var wall in _walls.ToArray())
            {
                foreach (var enemy in _enemies.ToArray())
                {
                    if (enemy.Hit(wall.X, wall.Y))
                    {
                        enemy.Back();
                        break;
                    }
                }
            }

            foreach (var wall in _walls.ToArray())
            {
                foreach (var bullet in _bullets.ToArray())
                {
                    if (wall.Hit(bullet.X, bullet.Y))
                    {
                        _bullets.Remove(bullet);
                        break;
                    }
                }
            }

            foreach (var bonus in _bonus.ToArray())
            {
                if (bonus.Hit(_player.X, _player.Y))
                {
                    money++;
                    _bonus.Remove(bonus);

                    _bonus.AddRange(Enumerable.Range(0, 1).Select(x => CreateRandomBonus()));
                }
            }
            

            if (_walls.Any(wall => wall.Hit(_player.X, _player.Y)))
            {
                _player.Back();
            }

            if (_enemies.Any(enemy => enemy.Hit(_player.X, _player.Y)))
            {
                return false;
            }

            if (_enemies.Count == 0) return true;

            return null;
        }
        private bool ReadInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return true;
                    case ConsoleKey.LeftArrow:
                        _player.Move(-1, 0);
                        direction = "LEFT";
                        break;
                    case ConsoleKey.RightArrow:
                        _player.Move(1, 0);
                        direction = "RIGHT";
                        break;
                    case ConsoleKey.UpArrow:
                        _player.Move(0, -1);
                        direction = "UP";
                        break;
                    case ConsoleKey.DownArrow:
                        _player.Move(0, 1);
                        direction = "DOWN";
                        break;
                    case ConsoleKey.Spacebar:
                        _bullets.Add(new Bullet(_player.X, _player.Y, direction));
                        break;
                    default:
                        break;
                }
            }

            return false;
        }


        private void Render()
        {
            foreach (var enemy in _enemies)
            {
                enemy.Draw(_writer);
            }

            foreach (var bullet in _bullets)
            {
                bullet.Draw(_writer);
            }
            foreach (var wall in _walls)
            {
                wall.Draw(_writer);
            }
            foreach (var bonus in _bonus)
            {
                bonus.Draw(_writer);
            }

            _player.Draw(_writer);

            _writer.WriteText(0, 0, $"Enemies left {_enemies.Count} Money gained {money}", ConsoleColor.Cyan);

            _writer.WriteText(0, _writer.Height - 1, $"Arrows - move/Spacebar - shoot", ConsoleColor.Magenta);


            _writer.Flush();
        }
    }
}
