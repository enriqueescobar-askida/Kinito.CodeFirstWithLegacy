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

    // Region
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class RegionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
            : this("dbo")
        {
        }

        public RegionConfiguration(string schema)
        {
            Property(x => x.RegionDescription).IsFixedLength();
        }
    }

}
// </auto-generated>
