namespace lab5
{
    interface IVisitor<T>
    {
        T visit(Literal lit);
        T visit(Variable var);
        T visit(AddOp addOp);        
        T visit(MultOp subOp);
        T visit(DivOp subOp);
    }
}