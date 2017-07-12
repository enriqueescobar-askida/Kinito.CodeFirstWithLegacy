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


namespace ConsoleNorthwind
{
    using Entities;
    using Interfaces;

    // Order Details Extended
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class OrderDetailsExtendedConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OrderDetailsExtended>
    {
        public OrderDetailsExtendedConfiguration()
            : this("dbo")
        {
        }

        public OrderDetailsExtendedConfiguration(string schema)
        {
            Property(x => x.UnitPrice).HasPrecision(19,4);
            Property(x => x.ExtendedPrice).IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>
