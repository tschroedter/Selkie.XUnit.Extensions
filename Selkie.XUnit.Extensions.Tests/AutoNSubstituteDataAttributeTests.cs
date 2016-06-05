using JetBrains.Annotations;
using NSubstitute;
using Ploeh.AutoFixture.Xunit;
using Xunit.Extensions;

namespace Selkie.XUnit.Extensions.Tests
{
    public class AutoNSubstituteDataAttributeTests
    {
        [Theory]
        [AutoNSubstituteData]
        public void AutoNSubstituteData_Resolves_Dependency_And_Sut(
            [NotNull, Frozen] IDependency dependency,
            [NotNull] TestClass sut)
        {
            // Arrange


            // Act
            sut.DoSomething();

            // Assert
            dependency.Received().DoNothing();
        }

        public class TestClass
        {
            private readonly IDependency m_Dependency;

            public TestClass([NotNull] IDependency dependency)
            {
                m_Dependency = dependency;
            }

            public void DoSomething()
            {
                m_Dependency.DoNothing();
            }
        }

        public interface IDependency
        {
            void DoNothing();
        }
    }
}