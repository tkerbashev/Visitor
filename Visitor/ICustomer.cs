namespace Visitor
{
    public interface ICustomer
    {
        void Accept(IVisitor visitor);
    }
}
