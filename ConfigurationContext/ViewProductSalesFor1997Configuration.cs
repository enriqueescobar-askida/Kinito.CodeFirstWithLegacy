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


namespace ConfigurationContext
{
    using Entities;
    using Interfaces;

    // Product Sales for 1997
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewProductSalesFor1997Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewProductSalesFor1997>
    {
        public ViewProductSalesFor1997Configuration()
            : this("dbo")
        {
        }

        public ViewProductSalesFor1997Configuration(string schema)
        {
            Property(x => x.ProductSales).IsOptional().HasPrecision(19,4);
        }
    }

}
// </auto-generated>