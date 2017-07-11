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

    // Employees
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class EmployeeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
            : this("dbo")
        {
        }

        public EmployeeConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional();
            Property(x => x.TitleOfCourtesy).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.HireDate).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.HomePhone).IsOptional();
            Property(x => x.Extension).IsOptional();
            Property(x => x.Photo).IsOptional();
            Property(x => x.Notes).IsOptional();
            Property(x => x.ReportsTo).IsOptional();
            Property(x => x.PhotoPath).IsOptional();

            HasMany(t => t.Territories).WithMany(t => t.Employees).Map(m =>
            {
                m.ToTable("EmployeeTerritories", "dbo");
                m.MapLeftKey("EmployeeID");
                m.MapRightKey("TerritoryID");
            });
        }
    }

}
// </auto-generated>
