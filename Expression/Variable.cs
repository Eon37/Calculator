namespace lab5
{
    ///<summary>
    ///Contains methods to store and operate with variables
    ///</summary>
    class Variable : Expression
    {
        ///<summary>
        ///Contains the name of variable
        ///</summary>
         public readonly string name;
         
        ///<summary>
        ///Public constructor with parameters
        ///</summary>
        ///<param name="name">The name of variable</param>
         public Variable(string name)
         {
             this.name = name;
         }

         public override T acceptVisitor<T>(IVisitor<T> v)
         {
             return v.visit(this);
         }
    }
}