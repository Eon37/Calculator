namespace lab5
{
    ///<summary>
    ///Stores left and right expressions of operator
    ///</summary>
    abstract class Operator : Expression
    {
        ///<summary>
        ///Expression to the left of operator
        ///</summary>
        public readonly Expression left;
        ///<summary>
        ///Expression to the left of operator
        ///</summary>
        public readonly Expression right;

        ///<summary>
        ///Public constructor with parameters
        ///</summary>
        ///<param name="l">Parameter to the left of the addition operator</param>
        ///<param name="r">Parameter to the right of the addition operator</param>
        public Operator(Expression l, Expression r)
        {
            left = l;
            right = r;
        }
        public abstract override T acceptVisitor<T>(IVisitor<T> v);
    }
}