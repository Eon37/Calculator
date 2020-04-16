namespace lab5
{
    ///<summary>
    ///Describes operator that perform division
    ///</summary>
    class DivOp : Operator
    {
        ///<summary>
        ///Public constructor with parameters
        ///</summary>
        ///<param name="l">Parameter to the left of the addition operator</param>
        ///<param name="r">Parameter to the right of the addition operator</param>
        public DivOp(Expression l, Expression r) : base(l,r){}

        public override T acceptVisitor<T>(IVisitor<T> v)
        {
            return v.visit(this);
        }
    }
}