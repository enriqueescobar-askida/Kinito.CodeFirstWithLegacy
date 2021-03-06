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

    // Customer and Suppliers by City
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ViewCustomerAndSuppliersByCityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ViewCustomerAndSuppliersByCity>
    {
        public ViewCustomerAndSuppliersByCityConfiguration()
            : this("dbo")
        {
        }

        public ViewCustomerAndSuppliersByCityConfiguration(string schema)
        {
            Property(x => x.City).IsOptional();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.Relationship).IsUnicode(false);
        }
    }

}
// </auto-generated>
