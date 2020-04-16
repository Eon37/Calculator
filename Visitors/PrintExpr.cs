namespace lab5
{
    ///<summary>
    ///Contains methods to print different kinds of expression (e.g. variables, literals or other expressions)
    ///</summary>
    ///<remarks>
    ///Implements interface IVisitor of type string
    ///</remarks>
    class PrintExpr : IVisitor<string>
    {
        ///<summary>
        ///Prints literal
        ///</summary>
        ///<param name="lit">Literal to print</param>
        ///<returns>
        ///String of literal value
        ///</returns>
        string IVisitor<string>.visit(Literal lit)
        {
            return lit.value.ToString();
        }

        ///<summary>
        ///Prints variable
        ///</summary>
        ///<param name="var">Variable to print</param>
        ///<returns>
        ///String of variable name
        ///</returns>
        string IVisitor<string>.visit(Variable var)
        {
            return var.name;
        }
        
        ///<summary>
        ///Prints addition
        ///</summary>
        ///<param name="addOp">Addition operator that represents a tree of expressions</param>
        ///<returns>
        ///String to print
        ///</returns>
        string IVisitor<string>.visit(AddOp addOp)
        {
            return new string("(" + addOp.left.acceptVisitor(this) + "+" + addOp.right.acceptVisitor(this) + ")");
        }

        ///<summary>
        ///Prints multiplication
        ///</summary>
        ///<param name="multOp">Multiplication operator that represents a tree of expressions</param>
        ///<returns>
        ///String to print
        ///</returns>
        string IVisitor<string>.visit(MultOp multOp)
        {
            return new string("(" + multOp.left.acceptVisitor(this) + "*" + multOp.right.acceptVisitor(this) + ")");
        }

        ///<summary>
        ///Prints division
        ///</summary>
        ///<param name="divOp">Division operator that represents a tree of expressions</param>
        ///<returns>
        ///String to print
        ///</returns>
        string IVisitor<string>.visit(DivOp divOp)
        {
            return new string("(" + divOp.left.acceptVisitor(this) + "/" + divOp.right.acceptVisitor(this) + ")");
        }
    }
}