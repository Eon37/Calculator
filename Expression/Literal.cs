namespace lab5
{
    ///<summary>
    ///Contains methods to store and operate with literals
    ///</summary>
    class Literal : Expression
    {
        ///<summary>
        ///Contains the value of literal
        ///</summary>
         public readonly int value;

        ///<summary>
        ///Public constructor with parameters
        ///</summary>
        ///<param name="val">The value of literal</param>
         public Literal(int val)
         {
             value = val;
         }

         public override T acceptVisitor<T>(IVisitor<T> v)
         {
             return v.visit(this);
         }
    }
}