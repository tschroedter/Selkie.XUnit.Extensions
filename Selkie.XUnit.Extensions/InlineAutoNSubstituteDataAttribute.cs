using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Ploeh.AutoFixture.Xunit;
using Xunit.Extensions;

namespace Selkie.XUnit.Extensions
{
    [ExcludeFromCodeCoverage]
    [UsedImplicitly]
    public class InlineAutoNSubstituteDataAttribute : CompositeDataAttribute
    {
        public InlineAutoNSubstituteDataAttribute([NotNull] params object[] values)
            : base(new InlineDataAttribute(values),
                   new AutoNSubstituteDataAttribute())
        {
        }
    }
}