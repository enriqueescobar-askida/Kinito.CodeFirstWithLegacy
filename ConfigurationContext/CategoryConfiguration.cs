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

    // Categories
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class CategoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
            : this("dbo")
        {
        }

        public CategoryConfiguration(string schema)
        {
            Property(x => x.Description).IsOptional();
            Property(x => x.Picture).IsOptional();
        }
    }

}
// </auto-generated>
