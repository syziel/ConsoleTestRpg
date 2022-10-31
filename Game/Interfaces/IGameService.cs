using ConsoleTestRpg.Adventures;

namespace ConsoleTestRpg.Game.Interfaces
{
    public interface IGameService
    {
        bool StartGame(Adventure adventure = null);
    }
}