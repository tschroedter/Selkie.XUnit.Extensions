using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit;

namespace Selkie.XUnit.Extensions
{
    [ExcludeFromCodeCoverage]
    [UsedImplicitly]
    public class AutoNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoNSubstituteDataAttribute()
            : base(new Fixture().Customize(new AutoConfiguredNSubstituteCustomization()))
        {
        }
    }
}