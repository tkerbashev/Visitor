namespace Visitor
{
    public interface IVisitor
    {
        void VisttOffice( Office destination );
        void VisitPrivateHome( PrivateHome destination );
    }
}
