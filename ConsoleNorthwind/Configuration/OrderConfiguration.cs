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
    using Context;
    using Entities;

    // Orders
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class OrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
            : this("dbo")
        {
        }

        public OrderConfiguration(string schema)
        {
            Property(x => x.CustomerId).IsOptional().IsFixedLength();
            Property(x => x.EmployeeId).IsOptional();
            Property(x => x.OrderDate).IsOptional();
            Property(x => x.RequiredDate).IsOptional();
            Property(x => x.ShippedDate).IsOptional();
            Property(x => x.ShipVia).IsOptional();
            Property(x => x.Freight).IsOptional().HasPrecision(19,4);
            Property(x => x.ShipName).IsOptional();
            Property(x => x.ShipAddress).IsOptional();
            Property(x => x.ShipCity).IsOptional();
            Property(x => x.ShipRegion).IsOptional();
            Property(x => x.ShipPostalCode).IsOptional();
            Property(x => x.ShipCountry).IsOptional();

        }
    }

}
// </auto-generated>
