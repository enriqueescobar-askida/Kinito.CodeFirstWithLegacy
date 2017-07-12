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

    // Customers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class CustomerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
            : this("dbo")
        {
        }

        public CustomerConfiguration(string schema)
        {
            Property(x => x.CustomerId).IsFixedLength();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.ContactTitle).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.Fax).IsOptional();
            HasMany(t => t.CustomerDemographics).WithMany(t => t.Customers).Map(m =>
            {
                m.ToTable("CustomerCustomerDemo", "dbo");
                m.MapLeftKey("CustomerID");
                m.MapRightKey("CustomerTypeID");
            });
        }
    }

}
// </auto-generated>
