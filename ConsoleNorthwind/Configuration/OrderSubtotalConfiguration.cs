// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ConsoleNorthwind.Configuration
{
    using ConsoleNorthwind.Context;
    using Entities;

    // Order Subtotals
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class OrderSubtotalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderSubtotal>
    {
        public OrderSubtotalConfiguration()
            : this("dbo")
        {
        }

        public OrderSubtotalConfiguration(string schema)
        {
            Property(x => x.Subtotal).IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
