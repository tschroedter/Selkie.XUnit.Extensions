using System.Diagnostics.CodeAnalysis;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit;

namespace Selkie.XUnit.Extensions
{
    [ExcludeFromCodeCoverage]
    //ncrunch: no coverage start
    public class AutoNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoNSubstituteDataAttribute()
            : base(new Fixture().Customize(new AutoConfiguredNSubstituteCustomization()))
        {
        }
    }

    //ncrunch: no coverage end
}