namespace Kuhpik
{
    public enum EGamestate
    {
        // Don't change int values in the middle of development.
        // Otherwise all of your settings in inspector can be messed up.

        Loading = 1,
        Game = 2,
        Win = 3,
        Lose = 4,
        Result = 10,

        CurrencyShared = 100

        // Extend just like that
        //
        // Shop = 20,
        // Settings = 30,
        // Revive = 100
    }
}