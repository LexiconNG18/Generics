namespace Generics
{
    internal class Pair<T> : Pair<T, T>
    {
        public Pair(T first, T second) : base(first, second) { }
    }

    internal class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()
        {
            return $"[{First}, {Second}]";
        }
    }
}