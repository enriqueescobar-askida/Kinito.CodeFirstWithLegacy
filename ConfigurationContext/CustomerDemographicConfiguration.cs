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

    // CustomerDemographics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class CustomerDemographicConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CustomerDemographic>
    {
        public CustomerDemographicConfiguration()
            : this("dbo")
        {
        }

        public CustomerDemographicConfiguration(string schema)
        {
            Property(x => x.CustomerTypeId).IsFixedLength();
            Property(x => x.CustomerDesc).IsOptional();
        }
    }

}
// </auto-generated>