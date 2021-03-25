namespace Wallee.Test
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using Wallee.Model;

    [TestFixture]
    public sealed class EntityQueryFilterTests
    {
        [Test]
        public void EqualityWithoutChildrenTest()
        {
            var leafFilter1 = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "field",
                Operator = CriteriaOperator.EQUALS,
                Value = "value"
            };

            var leafFilter2 = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "field2",
                Operator = CriteriaOperator.EQUALS,
                Value = "value2"
            };

            var andFilter = new EntityQueryFilter(EntityQueryFilterType.AND)
            {
                Children = new List<EntityQueryFilter>
                {
                    leafFilter1,
                    leafFilter2
                }
            };

            Assert.DoesNotThrow(() => andFilter.Equals(leafFilter1));
        }
    }
}
