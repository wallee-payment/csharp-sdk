/**
* wallee SDK
*
* This library allows to interact with the wallee payment service.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;


using Wallee.Model;
using Wallee.Service;
using Wallee.Client;

namespace Wallee.Test
{
    /// <summary>
    ///  Class for testing EntityQueryFilterTests
    /// </summary>
    [TestFixture]
    public class EntityQueryFilterTests
    {
        private EntityQueryFilter EntityQueryFilter;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            EntityQueryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChargeAttemptService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<EntityQueryFilter>(EntityQueryFilter, "instance is a EntityQueryFilter");
        }

        /// <summary>
        /// Test EqualityWithoutChildrenTest
        /// </summary>
        [Test]
        public void EqualityWithoutChildrenTest()
        {
            EntityQueryFilter entityQueryFilter1 = new EntityQueryFilter(EntityQueryFilterType.LEAF);
            entityQueryFilter1.FieldName = "charge.transaction.id";
            entityQueryFilter1.Operator = CriteriaOperator.EQUALS;
            entityQueryFilter1.Value = "transaction.value";

            EntityQueryFilter entityQueryFilter2 = new EntityQueryFilter(EntityQueryFilterType.LEAF);
            entityQueryFilter2.FieldName = "charge.transaction.id";
            entityQueryFilter2.Operator = CriteriaOperator.EQUALS;
            entityQueryFilter2.Value = "transaction.value";

            EntityQueryFilter andFilter = new EntityQueryFilter(EntityQueryFilterType.AND)
            {
                Children = new List<EntityQueryFilter>
                {
                    entityQueryFilter1,
                    entityQueryFilter2
                }
            };

            Assert.DoesNotThrow(() => andFilter.Equals(entityQueryFilter1));
        }
    }
}