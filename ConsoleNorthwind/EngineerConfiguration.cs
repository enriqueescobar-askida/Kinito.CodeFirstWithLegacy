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

    // engineer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class EngineerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Engineer>
    {
        public EngineerConfiguration()
            : this("dbo")
        {
        }

        public EngineerConfiguration(string schema)
        {
            Property(x => x.Forename).IsUnicode(false);
            Property(x => x.Surname).IsUnicode(false);
        }
    }

}
// </auto-generated>
