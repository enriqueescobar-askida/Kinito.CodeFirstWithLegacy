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

    // Products by Category
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ProductsByCategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryConfiguration()
            : this("dbo")
        {
        }

        public ProductsByCategoryConfiguration(string schema)
        {
            Property(x => x.QuantityPerUnit).IsOptional();
            Property(x => x.UnitsInStock).IsOptional();
        }
    }

}
// </auto-generated>
