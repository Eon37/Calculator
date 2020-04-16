using System.Collections;

namespace lab5
{
    ///<summary>
    ///Contains methods to calculate different kinds of expression (e.g. variables, literals or other expressions)
    ///</summary>
    ///<remarks>
    ///Implements interface IVisitor of type Expression
    ///</remarks>
    class CalcExpr : IVisitor<Expression>
    {
        ///<summary>
        ///Returns literal
        ///</summary>
        ///<param name="lit">Literal to return</param>
        ///<returns>
        ///Literal
        ///</returns>
        Expression IVisitor<Expression>.visit(Literal lit)
        {
            return lit;
        }
        
        ///<summary>
        ///Returns variable
        ///</summary>
        ///<param name="var">Variable to return</param>
        ///<returns>
        ///Variable
        ///</returns>
        Expression IVisitor<Expression>.visit(Variable var)
        {
            return var;
        }
        
        ///<summary>
        ///Calculates addition
        ///</summary>
        ///<param name="addOp">Addition operator that represents a tree of expressions</param>
        ///<returns>
        ///Calculated expression
        ///</returns>
        Expression IVisitor<Expression>.visit(AddOp addOp)
        {
            Expression left = addOp.left.acceptVisitor(this);
            Expression right = addOp.right.acceptVisitor(this);

            if(left is Literal && right is Literal)
            {
                return new Literal(((Literal)left).value + ((Literal)right).value);
            }
            
            return new AddOp(left, right); 
        }
        
        ///<summary>
        ///Calculates multiplication
        ///</summary>
        ///<param name="multOp">Meltiplication operator that represents a tree of expressions</param>
        ///<returns>
        ///Calculated expression
        ///</returns>
        Expression IVisitor<Expression>.visit(MultOp multOp)
        {
            Expression left = multOp.left.acceptVisitor(this);
            Expression right = multOp.right.acceptVisitor(this);

            if(left is Literal && right is Literal)
            {
                return new Literal(((Literal)left).value * ((Literal)right).value);
            }

            return new MultOp(left, right);   
        }

        ///<summary>
        ///Calculates division
        ///</summary>
        ///<param name="divOp">Division operator that represents a tree of expressions</param>
        ///<returns>
        ///Calculated expression
        ///</returns>
        Expression IVisitor<Expression>.visit(DivOp divOp)
        {
            Expression left = divOp.left.acceptVisitor(this);
            Expression right = divOp.right.acceptVisitor(this);

            if(left is Literal && right is Literal)
            {
                return new Literal(((Literal)left).value / ((Literal)right).value);
            }

            return new DivOp(left, right);   
        }
    }
}