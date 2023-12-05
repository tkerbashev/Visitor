﻿using System.Reflection.Metadata.Ecma335;

namespace Visitor
{
    public class PrivateHome : ICustomer
    {
        public static string Name => "A Private Home";
        public void Accept( IVisitor visitor )
        {
            visitor.VisitPrivateHome( this );
        }
    }
}
