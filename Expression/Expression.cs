namespace lab5
{
    abstract class Expression
    {
        public abstract T acceptVisitor<T>(IVisitor<T> v);
    }
}