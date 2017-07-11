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

    // Alphabetical list of products
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class AlphabeticalListOfProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public AlphabeticalListOfProductConfiguration()
            : this("dbo")
        {
        }

        public AlphabeticalListOfProductConfiguration(string schema)
        {
            Property(x => x.SupplierId).IsOptional();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.QuantityPerUnit).IsOptional();
            Property(x => x.UnitPrice).IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).IsOptional();
            Property(x => x.UnitsOnOrder).IsOptional();
            Property(x => x.ReorderLevel).IsOptional();
        }
    }

}
// </auto-generated>
